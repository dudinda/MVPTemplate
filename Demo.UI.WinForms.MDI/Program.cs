using Demo.Presentation.Presenters;
using Demo.UI.WinForms.MDI;

using ImageProcessing.Microkernel;
using ImageProcessing.Microkernel.MVP.Code.Enums;

using (var app = new AppLifecycle())
{
    app.Build<Startup>(DiContainer.Ninject);
    app.Run<MainPresenter>();
}