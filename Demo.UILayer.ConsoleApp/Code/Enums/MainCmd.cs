using System.ComponentModel;

namespace Demo.UILayer.ConsoleApp.Code.Enums
{
    public enum MainCmd
    {
        Unknown       = 0,

        [Description("show_transient")]
        ShowTransient = 1,

        [Description("show_singleton")]
        ShowSingleton = 2,

        [Description("exit")]
        ExitMain      = 3,
    }
}
