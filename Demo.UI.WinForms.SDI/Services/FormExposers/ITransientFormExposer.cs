using System.Windows.Forms;

namespace Demo.UI.WinForms.SDI.Services.FormExposers
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
