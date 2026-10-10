using Demo.UI.WinForms.SDI.Services.FormExposers;

namespace Demo.UI.WinForms.SDI.Services.FormEventBinders.TransientForm.Interface
{
    internal interface ITransientFormEventBinder
    {
        void OnElementExpose(ITransientFormExposer source);
    }
}
