using System.Windows.Forms;

using Demo.Presentation.Views;
using Demo.UI.WinForms.MDI.Servcies.FormEventBinders.Main.Interface;
using Demo.UI.WinForms.MDI.Servcies.FormExposers;

namespace Demo.UI.WinForms.MDI.Forms.Main
{
    public partial class MainForm : BaseForm,
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

        public new void Close()
        {
            base.Close();
            Controller.Dispose();
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
