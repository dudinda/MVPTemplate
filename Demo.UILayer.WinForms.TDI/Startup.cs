using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.TDI.FormEventBinders.Main.Implementation;
using Demo.UILayer.WinForms.TDI.FormEventBinders.Main.Interface;
using Demo.UILayer.WinForms.TDI.FormEventBinders.SingletonForm.Implementation;
using Demo.UILayer.WinForms.TDI.FormEventBinders.SingletonForm.Interface;
using Demo.UILayer.WinForms.TDI.FormEventBinders.TransientForm.Implementation;
using Demo.UILayer.WinForms.TDI.FormEventBinders.TransientForm.Interface;
using Demo.UILayer.WinForms.TDI.Forms.Main;
using Demo.UILayer.WinForms.TDI.Forms.Singleton;
using Demo.UILayer.WinForms.TDI.Forms.Transient;

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;

namespace Demo.UILayer.WinForms.TDI
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
