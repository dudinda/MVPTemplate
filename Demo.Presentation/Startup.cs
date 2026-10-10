using ImageProcessing.Microkernel.MVP.Models;
using ImageProcessing.Microkernel.MVP.Services.Providers;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Serilog;
using Serilog.Extensions.Logging;

namespace Demo.Presentation
{
    public sealed class Startup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            builder
                 .RegisterSingleton<IConfiguration>((prov) =>
                 {
                     var config = new ConfigurationBuilder()
                         .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                     return config.Build();
                 })
                 .RegisterSingleton(prov =>
                 {
                     var conf = prov.Resolve<IConfiguration>();
                     var serilog = new LoggerConfiguration()
                     .ReadFrom.Configuration(conf).CreateLogger();
                     return LoggerFactory.Create(builder =>
                     {
                         builder.ClearProviders();
                         builder.AddProvider(new SerilogLoggerProvider(serilog));
                     });
                 });
        }
    }
}
