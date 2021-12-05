using System.Windows.Forms;

using Demo.UILayer.WinForms.MDI.Forms.Singleton;

namespace Demo.UILayer.WinForms.MDI.FormExposers
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
