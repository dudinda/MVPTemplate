using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;

namespace Demo.UILayer.ConsoleApp.CommandEventBinders.Singleton.Interface
{
    public interface ISingletonCommandEventBinder
    {
        void Bind(ISingletonFormView view);
        bool ProcessCmd(SingletonCmd command, params string[] args);
    }
}
