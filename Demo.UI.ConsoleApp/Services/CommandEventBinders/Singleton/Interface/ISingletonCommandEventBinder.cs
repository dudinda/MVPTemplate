using Demo.Presentation.Views;
using Demo.UI.ConsoleApp.Code.Enums;

namespace Demo.UI.ConsoleApp.Services.CommandEventBinders.Singleton.Interface
{
    public interface ISingletonCommandEventBinder
    {
        void Bind(ISingletonFormView view);
        bool ProcessCmd(SingletonCmd command, params string[] args);
    }
}
