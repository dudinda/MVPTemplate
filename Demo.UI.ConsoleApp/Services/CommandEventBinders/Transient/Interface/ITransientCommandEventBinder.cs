using Demo.Presentation.Views;
using Demo.UI.ConsoleApp.Code.Enums;

namespace Demo.UI.ConsoleApp.Services.CommandEventBinders.Transient.Interface
{
    internal interface ITransientCommandEventBinder
    {
        void Bind(ITransientFormView view);
        bool ProcessCmd(TransientCmd command, params string[] args);
    }
}
