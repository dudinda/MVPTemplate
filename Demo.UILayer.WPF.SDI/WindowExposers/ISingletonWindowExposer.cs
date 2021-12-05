using System.Windows.Controls;

using Demo.UILayer.WPF.SDI.Windows.Singleton;

namespace Demo.UILayer.WPF.SDI.WindowExposers
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
