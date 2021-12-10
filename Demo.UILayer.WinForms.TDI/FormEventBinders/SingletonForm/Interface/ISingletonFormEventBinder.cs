using Demo.UILayer.WinForms.TDI.FormExposers;

namespace Demo.UILayer.WinForms.TDI.FormEventBinders.SingletonForm.Interface
{
    internal interface ISingletonFormEventBinder
    {
        void OnElementExpose(ISingletonFormExposer source);
    }
}
