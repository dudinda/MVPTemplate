using System.Windows.Forms;

using Demo.UILayer.WinForms.TDI.Forms.Transient;

namespace Demo.UILayer.WinForms.TDI.FormExposers
{
    /// <summary>
    /// Expose elements from the <see cref="TransientForm"/>.
    /// </summary>
    internal interface ITransientFormExposer
    {
        /// <summary>
        /// Send a message from a transient form.
        /// </summary>
        Button SendMessage { get; }
    }
}
