using System.Windows.Controls;

using Demo.UILayer.WPF.SDI.Windows.Transient;

namespace Demo.UILayer.WPF.SDI.WindowExposers
{
    /// <summary>
    /// Expose elements from the <see cref="TransientWindow"/>.
    /// </summary>
    internal interface ITransientWindowExposer
    {
        /// <summary>
        /// Send a message from a transient window.
        /// </summary>
        Button Message { get; }
    }
}
