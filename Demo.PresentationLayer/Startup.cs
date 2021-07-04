using System.Diagnostics;

using Demo.PresentationLayer.Code.Constants;

using ImageProcessing.Microkernel.AppConfig;
using ImageProcessing.Microkernel.MVP.IoC.Interface;

namespace Demo.PresentationLayer
{
    public sealed class Startup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            builder
                .RegisterSingletonInstance(
                new EventLog() 
                {
                    Source = Messages.Demo
                });
        }
    }
}
