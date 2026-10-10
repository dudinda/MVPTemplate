using System.Windows.Controls;

using Demo.UI.WPF.SDI.Windows.Main;

namespace Demo.UI.WPF.SDI.Services.WindowExposers
{
    /// <summary>
    /// Expose elements from the <see cref="MainWindow"/>.
    /// </summary>
    internal interface IMainWindowExposer
    {
        /// <summary>
        /// Menu item to open a transient window.
        /// </summary>
        MenuItem TransientMenu { get; }

        /// <summary>
        /// Menu item to open a singleton window.
        /// </summary>
        MenuItem SingletonMenu { get; }
    }
}
