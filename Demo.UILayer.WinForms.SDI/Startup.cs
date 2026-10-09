using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.SDI.FormEventBinders.Main.Implementation;
using Demo.UILayer.WinForms.SDI.FormEventBinders.Main.Interface;
using Demo.UILayer.WinForms.SDI.FormEventBinders.SingletonForm.Implementation;
using Demo.UILayer.WinForms.SDI.FormEventBinders.SingletonForm.Interface;
using Demo.UILayer.WinForms.SDI.FormEventBinders.TransientForm.Implementation;
using Demo.UILayer.WinForms.SDI.FormEventBinders.TransientForm.Interface;
using Demo.UILayer.WinForms.SDI.Forms.Main;
using Demo.UILayer.WinForms.SDI.Forms.Singleton;
using Demo.UILayer.WinForms.SDI.Forms.Transient;

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;

namespace Demo.UILayer.WinForms.SDI
{
    internal sealed class Startup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            new PresentationLayer.Startup().Build(builder);

            builder
                .RegisterSingleton<IMainView, MainForm>()
                .RegisterTransient<ITransientFormView, TransientForm>()
                .RegisterSingleton<ISingletonFormView, SingletonForm>()
                .RegisterTransient<IMainFormEventBinder, MainFormEventBinder>()
                .RegisterTransient<ISingletonFormEventBinder, SingletonFormEventBinder>()
                .RegisterTransient<ITransientFormEventBinder, TransientFormEventBinder>();
        }
    }
}
