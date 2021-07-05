using System.Windows.Controls;

using Demo.UILayer.WPF.Windows.Singleton;

namespace Demo.UILayer.WPF.WindowExposers
{
    /// <summary>
    /// Expose elements from the <see cref="SingletonWindow"/>.
    /// </summary>
    public interface ISingletonWindowExposer
    {
        /// <summary>
        /// Send a message from a singleton window.
        /// </summary>
        Button Message { get; }
    }
}
