using System;

using Demo.Presentation.Presenters;

using ImageProcessing.Microkernel;
using ImageProcessing.Microkernel.MVP.Code.Enums;

namespace Demo.UI.WinForms.SDI
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
