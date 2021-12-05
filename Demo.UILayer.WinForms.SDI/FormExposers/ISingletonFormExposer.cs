using System.Windows.Forms;

using Demo.UILayer.WinForms.SDI.Forms.Singleton;

namespace Demo.UILayer.WinForms.SDI.FormExposers
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
