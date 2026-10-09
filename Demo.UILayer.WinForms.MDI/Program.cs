using Demo.PresentationLayer.Presenters;
using Demo.UILayer.WinForms.MDI;

using ImageProcessing.Microkernel;
using ImageProcessing.Microkernel.MVP.Code.Enums;

using (var app = new AppLifecycle())
{
    app.Build<Startup>(DiContainer.Ninject);
    app.Run<MainPresenter>();
}