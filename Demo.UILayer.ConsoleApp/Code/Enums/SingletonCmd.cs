using System.ComponentModel;

namespace Demo.UILayer.ConsoleApp.Code.Enums
{
    public enum SingletonCmd
    {
        Unknown     = 0,

        [Description("send_message")]
        SendMessage = 1,

        [Description("exit")]
        Exit        = 2,
    }
}
