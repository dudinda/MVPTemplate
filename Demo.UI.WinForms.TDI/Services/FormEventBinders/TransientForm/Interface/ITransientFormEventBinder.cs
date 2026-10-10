using Demo.UI.WinForms.TDI.Services.FormExposers;

namespace Demo.UI.WinForms.TDI.Services.FormEventBinders.TransientForm.Interface
{
    internal interface ITransientFormEventBinder
    {
        void OnElementExpose(ITransientFormExposer source);
    }
}
