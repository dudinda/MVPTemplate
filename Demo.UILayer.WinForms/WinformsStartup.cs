
using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.Forms.Main;

using ImageProcessing.Microkernel.AppConfig;
using ImageProcessing.Microkernel.MVP.IoC.Interface;

namespace Demo.UILayer.WinForms
{
    internal sealed class WinformsStartup : IStartup
    {
        public void Build(IComponentProvider builder)
        {
            builder
                .RegisterSingleton<IMainView, MainForm>();
        }
    }
}
