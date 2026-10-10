using Demo.Presentation.Views;
using Demo.UI.ConsoleApp.Commands;
using Demo.UI.ConsoleApp.Services.CommandEventBinders.Main.Implementation;
using Demo.UI.ConsoleApp.Services.CommandEventBinders.Main.Interface;
using Demo.UI.ConsoleApp.Services.CommandEventBinders.Singleton.Implementation;
using Demo.UI.ConsoleApp.Services.CommandEventBinders.Singleton.Interface;
using Demo.UI.ConsoleApp.Services.CommandEventBinders.Transient.Implementation;
using Demo.UI.ConsoleApp.Services.CommandEventBinders.Transient.Interface;
using Demo.UI.ConsoleApp.Services.Pulse.Implementation;
using Demo.UI.ConsoleApp.Services.Pulse.Interface;

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;

namespace Demo.UI.ConsoleApp
{
    internal sealed class Startup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            new Presentation.Startup().Build(builder);

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
