using Demo.PresentationLayer;
using Demo.PresentationLayer.Views;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Main.Implementation;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Main.Interface;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Singleton.Implementation;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Singleton.Interface;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Transient.Implementation;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Transient.Interface;
using Demo.UILayer.WPF.SDI.Windows.Main;
using Demo.UILayer.WPF.SDI.Windows.Singleton;
using Demo.UILayer.WPF.SDI.Windows.Transient;

using ImageProcessing.Microkernel.AppConfig;
using ImageProcessing.Microkernel.MVP.IoC.Interface;


namespace Demo.UILayer.WPF.SDI
{
    internal sealed class WpfSDIStartup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            new Startup().Build(builder);

            builder
                .RegisterSingleton<IMainView, MainWindow>()
                .RegisterTransient<ITransientFormView, TransientWindow>()
                .RegisterSingleton<ISingletonFormView, SingletonWindow>()
                .RegisterTransient<IMainWindowEventBinder, MainWindowEventBinder>()
                .RegisterTransient<ISingletonWindowEventBinder, SingletonWindowEventBinder>()
                .RegisterTransient<ITransientWindowEventBinder, TransientWindowEventBinder>();
        }
    }
}
