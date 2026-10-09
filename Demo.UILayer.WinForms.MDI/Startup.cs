using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.MDI.FormEventBinders.Main.Implementation;
using Demo.UILayer.WinForms.MDI.FormEventBinders.Main.Interface;
using Demo.UILayer.WinForms.MDI.FormEventBinders.SingletonForm.Implementation;
using Demo.UILayer.WinForms.MDI.FormEventBinders.SingletonForm.Interface;
using Demo.UILayer.WinForms.MDI.FormEventBinders.TransientForm.Implementation;
using Demo.UILayer.WinForms.MDI.FormEventBinders.TransientForm.Interface;
using Demo.UILayer.WinForms.MDI.Forms.Main;
using Demo.UILayer.WinForms.MDI.Forms.Singleton;
using Demo.UILayer.WinForms.MDI.Forms.Transient;

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;

namespace Demo.UILayer.WinForms.MDI
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
