using Demo.PresentationLayer;
using Demo.PresentationLayer.Views;
using Demo.UILayer.WPF.WindowEventBinders.Main.Implementation;
using Demo.UILayer.WPF.WindowEventBinders.Main.Interface;
using Demo.UILayer.WPF.WindowEventBinders.Singleton.Implementation;
using Demo.UILayer.WPF.WindowEventBinders.Singleton.Interface;
using Demo.UILayer.WPF.WindowEventBinders.Transient.Implementation;
using Demo.UILayer.WPF.WindowEventBinders.Transient.Interface;
using Demo.UILayer.WPF.Windows.Singleton;
using Demo.UILayer.WPF.Windows.Transient;

using ImageProcessing.Microkernel.AppConfig;
using ImageProcessing.Microkernel.MVP.IoC.Interface;


namespace Demo.UILayer.WPF
{
    internal sealed class WpfStartup : IStartup
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
