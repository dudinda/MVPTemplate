using Demo.UI.WinForms.SDI.Services.FormExposers;

namespace Demo.UI.WinForms.SDI.Services.FormEventBinders.SingletonForm.Interface
{
    internal interface ISingletonFormEventBinder
    {
        void OnElementExpose(ISingletonFormExposer source);
    }
}
