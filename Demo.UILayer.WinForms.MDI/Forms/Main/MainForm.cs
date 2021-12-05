using System.Windows.Forms;

using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.MDI.FormEventBinders.Main.Interface;
using Demo.UILayer.WinForms.MDI.FormExposers;

namespace Demo.UILayer.WinForms.MDI.Forms.Main
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
