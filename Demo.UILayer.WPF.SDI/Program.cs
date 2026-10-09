using System;

using Demo.PresentationLayer.Presenters;
using Demo.UILayer.WPF.SDI;

using ImageProcessing.Microkernel;
using ImageProcessing.Microkernel.MVP.Code.Enums;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        using (var app = new AppLifecycle())
        {
            app.Build<Startup>(DiContainer.Ninject);
            app.Run<MainPresenter>();
        }
    }
}