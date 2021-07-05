using System.Windows.Forms;

using Demo.UILayer.WinForms.Forms.Singleton;

namespace Demo.UILayer.WinForms.FormExposers
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
