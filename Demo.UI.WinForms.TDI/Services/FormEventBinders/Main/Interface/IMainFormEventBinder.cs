using Demo.UI.WinForms.TDI.Services.FormExposers;

namespace Demo.UI.WinForms.TDI.Services.FormEventBinders.Main.Interface
{
    internal interface IMainFormEventBinder
    {
        void OnElementExpose(IMainFormExposer source);
    }
}
