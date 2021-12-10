using Demo.UILayer.WinForms.TDI.FormExposers;

namespace Demo.UILayer.WinForms.TDI.FormEventBinders.Main.Interface
{
    internal interface IMainFormEventBinder
    {
        void OnElementExpose(IMainFormExposer source);
    }
}
