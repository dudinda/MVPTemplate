using System.Windows.Forms;

using Demo.UILayer.WinForms.TDI.Forms.Singleton;

namespace Demo.UILayer.WinForms.TDI.FormExposers
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
