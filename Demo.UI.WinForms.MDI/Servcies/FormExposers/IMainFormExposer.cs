using System.Windows.Forms;

using Demo.UI.WinForms.MDI.Forms.Main;

namespace Demo.UI.WinForms.MDI.Servcies.FormExposers
{
    /// <summary>
    /// Expose elements from the <see cref="MainForm"/>.
    /// </summary>
    public interface IMainFormExposer
    {
        /// <summary>
        /// Menu item to open a transient form.
        /// </summary>
        ToolStripMenuItem TransientMenu { get; }

        /// <summary>
        /// Menu item to open a singleton form.
        /// </summary>
        ToolStripMenuItem SingletonMenu { get; }

        ///<inheritdoc cref="FormClosedEventHandler"/>
        event FormClosedEventHandler FormClosed;
    }
}
