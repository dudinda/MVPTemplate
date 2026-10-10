using Demo.Presentation.Views;
using Demo.UI.WinForms.SDI.Forms.Main;
using Demo.UI.WinForms.SDI.Forms.Singleton;
using Demo.UI.WinForms.SDI.Forms.Transient;
using Demo.UI.WinForms.SDI.Services.FormEventBinders.Main.Implementation;
using Demo.UI.WinForms.SDI.Services.FormEventBinders.Main.Interface;
using Demo.UI.WinForms.SDI.Services.FormEventBinders.SingletonForm.Implementation;
using Demo.UI.WinForms.SDI.Services.FormEventBinders.SingletonForm.Interface;
using Demo.UI.WinForms.SDI.Services.FormEventBinders.TransientForm.Implementation;
using Demo.UI.WinForms.SDI.Services.FormEventBinders.TransientForm.Interface;

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;

namespace Demo.UI.WinForms.SDI
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
