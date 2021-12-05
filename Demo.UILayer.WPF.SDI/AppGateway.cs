using System;

using Demo.PresentationLayer.Presenters;

using ImageProcessing.Microkernel.DIAdapter;
using ImageProcessing.Microkernel.EntryPoint;

namespace Demo.UILayer.WPF.SDI
{
    internal static class AppGateway
    {
        [STAThread]
        internal static void Main()
       {
            try
            {
                AppLifecycle.Build<WpfSDIStartup>(DiContainer.Ninject);
                AppLifecycle.Run<MainPresenter>();
            }
            catch (Exception ex)
            {
                AppLifecycle.Exit();
            }
        }
    }
}
