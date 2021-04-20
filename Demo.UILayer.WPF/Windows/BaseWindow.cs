using System;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

using ImageProcessing.Microkernel.MVP.Controller.Implementation;
using ImageProcessing.Microkernel.MVP.Controller.Interface;
using ImageProcessing.Microkernel.MVP.View;

namespace Demo.UILayer.WPF.Windows
{
    // <summary>
    /// Interaction logic for BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : Window, IView
    {

        private IAppController? _controller;
        private Application? _app;

        public BaseWindow() : base()
        {
            
        }
        /// <inheritdoc cref="IAppController"/>
        protected IAppController Controller
            => _controller ??= AppController.Controller;

        /// <inheritdoc cref="ApplicationContext"/>
        protected Application App
        {
            get
            {
                if (Application.Current is null)
                {
                    var ioc = AppController.Controller.IoC;

                    if (!ioc.IsRegistered<Application>())
                    {
                        ioc.RegisterSingleton<Application>();
                    }

                    _app = ioc.Resolve<Application>();
                }

                return _app;
            }
        }

        protected virtual TElement Read<TElement>(Func<object> func)
        {
            object? result = null;

            if (SynchronizationContext.Current is null)
            {
                Dispatcher.Invoke((Action)(() => result = func()));
            }
            else
            {
                result = func();
            }

            return (TElement)(result ?? throw new ArgumentNullException(nameof(result)));
        }

        protected virtual void Write(Action action)
        {
            if (SynchronizationContext.Current is null)
            {
                Dispatcher.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
