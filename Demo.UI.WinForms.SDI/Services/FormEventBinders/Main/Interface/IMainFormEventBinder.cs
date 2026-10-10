using Demo.UI.WinForms.SDI.Services.FormExposers;

namespace Demo.UI.WinForms.SDI.Services.FormEventBinders.Main.Interface
{
    internal interface IMainFormEventBinder
    {
        void OnElementExpose(IMainFormExposer source);
    }
}
