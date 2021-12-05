using System.Windows.Forms;

using Demo.UILayer.WinForms.MDI.Forms.Transient;

namespace Demo.UILayer.WinForms.MDI.FormExposers
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
