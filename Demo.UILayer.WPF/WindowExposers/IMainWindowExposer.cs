using System.Windows.Controls;

using Demo.UILayer.WPF.Windows.Main;

namespace Demo.UILayer.WPF.WindowExposers
{
    /// <summary>
    /// Expose elements from the <see cref="MainWindow"/>.
    /// </summary>
    public interface IMainWindowExposer
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
