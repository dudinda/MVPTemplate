using Demo.Presentation.Views;
using Demo.UI.ConsoleApp.Code.Enums;

namespace Demo.UI.ConsoleApp.Services.CommandEventBinders.Main.Interface
{
    public interface IMainCommandEventBinder
    {
        void Bind(IMainView view);
        bool ProcessCmd(MainCmd command, params string[] args);
    }
}
