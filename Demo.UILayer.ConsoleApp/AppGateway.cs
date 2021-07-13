using System;

using Demo.PresentationLayer.Presenters;

using ImageProcessing.Microkernel.DIAdapter;
using ImageProcessing.Microkernel.EntryPoint;

namespace Demo.UILayer.ConsoleApp
{
    internal sealed class AppGateway
    {
        internal static void Main(string[] args)
        {
            try
            {
                AppLifecycle.Build<ConsoleStartup>(DiContainer.Ninject);
                AppLifecycle.Run<MainPresenter>();
            }
            catch (Exception ex)
            {
                AppLifecycle.Exit();
            }
        }
    }
}
