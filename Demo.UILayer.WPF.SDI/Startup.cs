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

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;


namespace Demo.UILayer.WPF.SDI
{
    internal sealed class Startup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            new PresentationLayer.Startup().Build(builder);

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
