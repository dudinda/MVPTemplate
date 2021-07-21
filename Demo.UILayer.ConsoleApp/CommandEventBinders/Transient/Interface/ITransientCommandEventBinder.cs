using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;

namespace Demo.UILayer.ConsoleApp.CommandEventBinders.Transient.Interface
{
    internal interface ITransientCommandEventBinder
    {
        void Bind(ITransientFormView view);
        bool ProcessCmd(TransientCmd command, params string[] args);
    }
}
