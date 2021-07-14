
using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Main.Implementation;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Main.Interface;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Singleton.Implementation;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Singleton.Interface;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Transient.Implementation;
using Demo.UILayer.ConsoleApp.CommandEventBinders.Transient.Interface;
using Demo.UILayer.ConsoleApp.Commands;
using Demo.UILayer.ConsoleApp.Services.Pulse.Implementation;
using Demo.UILayer.ConsoleApp.Services.Pulse.Interface;

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
                .RegisterSingleton<IPulseService, PulseService>()
                .RegisterTransient<ITransientFormView, TransientCommand>()
                .RegisterTransient<IMainCommandEventBinder, MainCommandEventBinder>()
                .RegisterTransient<ITransientCommandEventBinder, TransientCommandEventBinder>()
                .RegisterTransient<ISingletonCommandEventBinder, SingletonCommandEventBinder>();
        }
    }
}
