using System.Windows.Controls;

using Demo.UILayer.WPF.Windows.Transient;

namespace Demo.UILayer.WPF.WindowExposers
{
    /// <summary>
    /// Expose elements from the <see cref="TransientWindow"/>.
    /// </summary>
    public interface ITransientWindowExposer
    {
        /// <summary>
        /// Send a message from a transient window.
        /// </summary>
        Button Message { get; }
    }
}
