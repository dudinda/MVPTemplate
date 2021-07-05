using System;
using System.Threading;
using System.Windows.Forms;

using ImageProcessing.Microkernel.MVP.Controller.Implementation;
using ImageProcessing.Microkernel.MVP.Controller.Interface;
using ImageProcessing.Microkernel.MVP.View;

namespace Demo.UILayer.WinForms.Forms
{
    /// <summary>
    /// Represents the base form with the contextual
    /// information about an application thread.
    /// </summary>
    public class BaseForm : Form, IView
    {
        private IAppController? _controller;
        private ApplicationContext? _context;

        /// <inheritdoc cref="IAppController"/>
        protected IAppController Controller
            => _controller ??= AppController.Controller;

        /// <inheritdoc cref="ApplicationContext"/>
        protected ApplicationContext Context
        {
            get
            {
                if(_context is null)
                {
                    var ioc = Controller.IoC;

                    if(!ioc.IsRegistered<ApplicationContext>())
                    {
                        ioc.RegisterSingleton<ApplicationContext>();
                    }

                    _context = ioc.Resolve<ApplicationContext>();
                }

                return _context;
            }
        }

        protected virtual TElement Read<TElement>(Func<object> func)
        {
            object? result = null;

            if (SynchronizationContext.Current is null)
            {
                Invoke((Action)(() => result = func() ));
            }
            else
            {
                result = func();
            } 

            if(result is  TElement ele)
            {
                return ele;
            }

            throw new ArgumentNullException(nameof(result));
        }

        protected virtual void Write(Action action)
        {
            if(SynchronizationContext.Current is null)
            {
                Invoke(action);
            }
            else
            {
                action();
            } 
        }
    }
}
