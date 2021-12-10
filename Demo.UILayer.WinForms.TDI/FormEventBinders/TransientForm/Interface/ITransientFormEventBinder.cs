using Demo.UILayer.WinForms.TDI.FormExposers;

namespace Demo.UILayer.WinForms.TDI.FormEventBinders.TransientForm.Interface
{
    internal interface ITransientFormEventBinder
    {
        void OnElementExpose(ITransientFormExposer source);
    }
}
