using Demo.UILayer.WinForms.SDI.FormExposers;

namespace Demo.UILayer.WinForms.SDI.FormEventBinders.SingletonForm.Interface
{
    internal interface ISingletonFormEventBinder
    {
        void OnElementExpose(ISingletonFormExposer source);
    }
}
