using System.Windows.Forms;

namespace Demo.UI.WinForms.TDI.Services.FormExposers
{
    /// <summary>
    /// Expose elements from the <see cref="MainForm"/>.
    /// </summary>
    internal interface IMainFormExposer
    {
        /// <summary>
        /// Menu item to open a transient form.
        /// </summary>
        ToolStripMenuItem TransientMenu { get; }

        /// <summary>
        /// Menu item to open a singleton form.
        /// </summary>
        ToolStripMenuItem SingletonMenu { get; }

        /// <summary>
        /// Container for the tabs.
        /// </summary>
        TabControl TabsCtrl { get; }

        ///<inheritdoc cref="FormClosedEventHandler"/>
        event FormClosedEventHandler FormClosed;
    }
}
