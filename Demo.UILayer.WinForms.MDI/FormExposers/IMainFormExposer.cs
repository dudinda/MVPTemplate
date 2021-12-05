using System.Windows.Forms;

using Demo.UILayer.WinForms.MDI.Forms.Main;

namespace Demo.UILayer.WinForms.MDI.FormExposers
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
    }
}
