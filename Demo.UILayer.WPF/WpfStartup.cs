using Demo.PresentationLayer.Views;
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
            builder
                .RegisterSingleton<IMainView, MainWindow>()
                .RegisterTransient<ITransientFormView, TransientWindow>()
                .RegisterSingleton<ISingletonFormView, SingletonWindow>();
        }
    }
}
