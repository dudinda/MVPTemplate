using Demo.Presentation.Views;
using Demo.UI.WinForms.TDI.Forms.Main;
using Demo.UI.WinForms.TDI.Forms.Singleton;
using Demo.UI.WinForms.TDI.Forms.Transient;
using Demo.UI.WinForms.TDI.Services.FormEventBinders.Main.Implementation;
using Demo.UI.WinForms.TDI.Services.FormEventBinders.Main.Interface;
using Demo.UI.WinForms.TDI.Services.FormEventBinders.SingletonForm.Implementation;
using Demo.UI.WinForms.TDI.Services.FormEventBinders.SingletonForm.Interface;
using Demo.UI.WinForms.TDI.Services.FormEventBinders.TransientForm.Implementation;
using Demo.UI.WinForms.TDI.Services.FormEventBinders.TransientForm.Interface;

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;

namespace Demo.UI.WinForms.TDI
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
