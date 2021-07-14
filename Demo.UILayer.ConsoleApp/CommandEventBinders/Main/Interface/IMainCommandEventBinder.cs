using Demo.PresentationLayer.Views;
using Demo.UILayer.ConsoleApp.Code.Enums;

namespace Demo.UILayer.ConsoleApp.CommandEventBinders.Main.Interface
{
    public interface IMainCommandEventBinder
    {
        void Bind(IMainView view);
        bool ProcessCmd(MainCmd command);
    }
}
