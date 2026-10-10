using System.Windows.Forms;

using Demo.UI.WinForms.MDI.Forms.Transient;

namespace Demo.UI.WinForms.MDI.Servcies.FormExposers
{
    /// <summary>
    /// Expose elements from the <see cref="TransientForm"/>.
    /// </summary>
    public interface ITransientFormExposer
    {
        /// <summary>
        /// Send a message from a transient form.
        /// </summary>
        Button SendMessage { get; }
    }
}
