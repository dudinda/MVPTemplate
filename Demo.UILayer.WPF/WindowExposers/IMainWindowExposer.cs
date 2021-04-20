using System.Windows.Controls;

namespace Demo.UILayer.WPF.WindowExposers
{
    internal interface IMainWindowExposer
    {
        /// <summary>
        /// Item to open transient menu.
        /// </summary>
        MenuItem TransientMenu { get; }

        /// <summary>
        /// Item to open singleton menu.
        /// </summary>
        MenuItem SingletonMenu { get; }
    }
}
