using System.ComponentModel;

namespace Demo.UI.ConsoleApp.Code.Enums
{
    public enum TransientCmd
    {
        Unknown     = 0,

        [Description("send_message")]
        SendMessage = 1,

        [Description("exit")]
        Exit        = 2,
    }
}
