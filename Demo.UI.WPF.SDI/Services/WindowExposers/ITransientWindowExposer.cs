using System.Windows.Controls;

using Demo.UI.WPF.SDI.Windows.Transient;

namespace Demo.UI.WPF.SDI.Services.WindowExposers
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
