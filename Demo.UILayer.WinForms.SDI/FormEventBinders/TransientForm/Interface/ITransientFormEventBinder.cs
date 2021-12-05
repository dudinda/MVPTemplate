using Demo.UILayer.WinForms.SDI.FormExposers;

namespace Demo.UILayer.WinForms.SDI.FormEventBinders.TransientForm.Interface
{
    internal interface ITransientFormEventBinder
    {
        void OnElementExpose(ITransientFormExposer source);
    }
}
