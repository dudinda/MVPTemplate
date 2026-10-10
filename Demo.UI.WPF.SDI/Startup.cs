using Demo.Presentation.Views;
using Demo.UI.WPF.SDI.Services.WindowEventBinders.Main.Implementation;
using Demo.UI.WPF.SDI.Services.WindowEventBinders.Main.Interface;
using Demo.UI.WPF.SDI.Services.WindowEventBinders.Singleton.Implementation;
using Demo.UI.WPF.SDI.Services.WindowEventBinders.Singleton.Interface;
using Demo.UI.WPF.SDI.Services.WindowEventBinders.Transient.Implementation;
using Demo.UI.WPF.SDI.Services.WindowEventBinders.Transient.Interface;
using Demo.UI.WPF.SDI.Windows.Main;
using Demo.UI.WPF.SDI.Windows.Singleton;
using Demo.UI.WPF.SDI.Windows.Transient;

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;


namespace Demo.UI.WPF.SDI
{
    internal sealed class Startup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            new Presentation.Startup().Build(builder);

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
