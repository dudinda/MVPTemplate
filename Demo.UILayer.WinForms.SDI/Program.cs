using System;

using Demo.PresentationLayer.Presenters;

using ImageProcessing.Microkernel;
using ImageProcessing.Microkernel.MVP.Code.Enums;

namespace Demo.UILayer.WinForms.SDI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            using (var app = new AppLifecycle())
            {
                app.Build<Startup>(DiContainer.Ninject);
                app.Run<MainPresenter>();
            }
        }
    }
}
