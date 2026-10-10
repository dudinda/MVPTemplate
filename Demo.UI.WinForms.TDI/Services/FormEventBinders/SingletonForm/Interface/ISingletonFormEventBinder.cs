using Demo.UI.WinForms.TDI.Services.FormExposers;

namespace Demo.UI.WinForms.TDI.Services.FormEventBinders.SingletonForm.Interface
{
    internal interface ISingletonFormEventBinder
    {
        void OnElementExpose(ISingletonFormExposer source);
    }
}
