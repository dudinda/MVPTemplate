
using Demo.PresentationLayer;
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

using ImageProcessing.Microkernel.AppConfig;
using ImageProcessing.Microkernel.MVP.IoC.Interface;

namespace Demo.UILayer.WinForms.SDI
{
    internal sealed class WinformsSDIStartup : IStartup
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
