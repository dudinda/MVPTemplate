using System.Windows.Controls;

using Demo.UI.WPF.SDI.Windows.Singleton;

namespace Demo.UI.WPF.SDI.Services.WindowExposers
{
    /// <summary>
    /// Expose elements from the <see cref="SingletonWindow"/>.
    /// </summary>
    internal interface ISingletonWindowExposer
    {
        /// <summary>
        /// Send a message from a singleton window.
        /// </summary>
        Button Message { get; }
    }
}
