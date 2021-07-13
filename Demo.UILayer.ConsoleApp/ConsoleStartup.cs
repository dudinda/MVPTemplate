
using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Main.Implementation;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Main.Interface;
using Demo.UILayer.ConsoleApp.Commands;

using ImageProcessing.Microkernel.AppConfig;
using ImageProcessing.Microkernel.MVP.IoC.Interface;

namespace Demo.UILayer.ConsoleApp
{
    public class ConsoleStartup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            builder
                .RegisterTransient<IMainView, MainCommand>()
                .RegisterSingleton<ISingletonFormView, SingletonCommand>()
                .RegisterTransient<ITransientFormView, TransientCommand>()
                .RegisterTransient<IMainCommandEventBinder, MainCommandEventBinder>();
        }
    }
}
