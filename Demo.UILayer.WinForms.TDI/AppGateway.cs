using System;

using Demo.PresentationLayer.Presenters;

using ImageProcessing.Microkernel.DIAdapter;
using ImageProcessing.Microkernel.EntryPoint;

namespace Demo.UILayer.WinForms.TDI
{
    internal static class AppGateway
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            try
            {
                AppLifecycle.Build<WinformsTDIStartup>(DiContainer.Ninject);
                AppLifecycle.Run<MainPresenter>();
            }
            catch (Exception ex)
            {
                AppLifecycle.Exit();
            }
        }
    }
}
