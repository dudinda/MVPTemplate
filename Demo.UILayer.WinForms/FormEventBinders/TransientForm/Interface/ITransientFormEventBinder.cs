using Demo.UILayer.WinForms.FormExposers;

namespace Demo.UILayer.WinForms.FormEventBinders.TransientForm.Interface
{
    public interface ITransientFormEventBinder
    {
        void OnElementExpose(ITransientFormExposer source);
    }
}
