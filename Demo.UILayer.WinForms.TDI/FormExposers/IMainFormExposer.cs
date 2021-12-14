using System.Windows.Forms;

using Demo.UILayer.WinForms.TDI.Forms.Main;

namespace Demo.UILayer.WinForms.TDI.FormExposers
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
