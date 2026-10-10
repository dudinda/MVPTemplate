using System.Windows.Forms;

namespace Demo.UI.WinForms.SDI.Services.FormExposers
{
    /// <summary>
    /// Expose elements from <see cref="SingletonForm"/>.
    /// </summary>
    internal interface ISingletonFormExposer
    {
        /// <summary>
        /// Send a message from a singleton form.
        /// </summary>
        Button SendMessage { get; }
    }
}
