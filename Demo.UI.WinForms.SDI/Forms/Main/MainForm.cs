using System.Windows.Forms;

using Demo.Presentation.Views;
using Demo.UI.WinForms.SDI.Services.FormEventBinders.Main.Interface;
using Demo.UI.WinForms.SDI.Services.FormExposers;

namespace Demo.UI.WinForms.SDI.Forms.Main
{
    internal sealed partial class MainForm : BaseForm,
        IMainView, IMainFormExposer
    {
        private readonly IMainFormEventBinder _binder;

        public MainForm(IMainFormEventBinder binder)
        {
            InitializeComponent();

            _binder = binder;
            _binder.OnElementExpose(this);
        }

        public new void Show()
        {
            Context.MainForm = this;
            Application.Run(Context);
        }

        public void Tooltip(string msg)
        {
            Message.Text = msg;
        }

        public ToolStripMenuItem TransientMenu
            => TransientMenuBtn;

        public ToolStripMenuItem SingletonMenu
            => SingletonFormBtn;
    }
}
