using Demo.PresentationLayer.Presenters;

using ImageProcessing.Microkernel;
using ImageProcessing.Microkernel.MVP.Code.Enums;

namespace Demo.UILayer.ConsoleApp
{
    internal sealed class Program
    {
        internal static void Main(string[] args)
        {
            using (var app = new AppLifecycle())
            {
                app.Build<Startup>(DiContainer.Ninject);
                app.Run<MainPresenter>();
            }
        }
    }
}
