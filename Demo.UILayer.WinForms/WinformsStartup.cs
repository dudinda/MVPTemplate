
using Demo.PresentationLayer;
using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.FormEventBinders.Main.Implementation;
using Demo.UILayer.WinForms.FormEventBinders.Main.Interface;
using Demo.UILayer.WinForms.FormEventBinders.SingletonForm.Implementation;
using Demo.UILayer.WinForms.FormEventBinders.SingletonForm.Interface;
using Demo.UILayer.WinForms.FormEventBinders.TransientForm.Implementation;
using Demo.UILayer.WinForms.FormEventBinders.TransientForm.Interface;
using Demo.UILayer.WinForms.Forms.Main;
using Demo.UILayer.WinForms.Forms.Singleton;
using Demo.UILayer.WinForms.Forms.Transient;

using ImageProcessing.Microkernel.AppConfig;
using ImageProcessing.Microkernel.MVP.IoC.Interface;

namespace Demo.UILayer.WinForms
{
    internal sealed class WinformsStartup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            new Startup().Build(builder);

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
