using Demo.Presentation.Views;
using Demo.UI.WinForms.MDI.Forms.Main;
using Demo.UI.WinForms.MDI.Forms.Singleton;
using Demo.UI.WinForms.MDI.Forms.Transient;
using Demo.UI.WinForms.MDI.Servcies.FormEventBinders.Main.Implementation;
using Demo.UI.WinForms.MDI.Servcies.FormEventBinders.Main.Interface;
using Demo.UI.WinForms.MDI.Servcies.FormEventBinders.SingletonForm.Implementation;
using Demo.UI.WinForms.MDI.Servcies.FormEventBinders.SingletonForm.Interface;
using Demo.UI.WinForms.MDI.Servcies.FormEventBinders.TransientForm.Implementation;
using Demo.UI.WinForms.MDI.Servcies.FormEventBinders.TransientForm.Interface;

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;

namespace Demo.UI.WinForms.MDI
{
    internal sealed class Startup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            new Presentation.Startup().Build(builder);

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
