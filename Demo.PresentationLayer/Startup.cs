using System.Diagnostics;

using Demo.PresentationLayer.Code.Constants;

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;

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
