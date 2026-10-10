using System.Windows.Forms;

using Demo.UI.WinForms.MDI.Forms.Singleton;

namespace Demo.UI.WinForms.MDI.Servcies.FormExposers
{
    /// <summary>
    /// Expose elements from <see cref="SingletonForm"/>.
    /// </summary>
    public interface ISingletonFormExposer
    {
        /// <summary>
        /// Send a message from a singleton form.
        /// </summary>
        Button SendMessage { get; }
    }
}
