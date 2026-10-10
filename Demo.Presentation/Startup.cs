using System.Diagnostics;

using Demo.Presentation.Code.Constants;

using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;

namespace Demo.Presentation
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
