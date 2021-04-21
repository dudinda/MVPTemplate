
using System.Windows.Forms;

using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.FormExposers;

using ImageProcessing.App.UILayer.Forms;

namespace Demo.UILayer.WinForms.Forms.Main
{
    public partial class MainForm : BaseForm,
        IMainView, IMainFormExposer
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            Context.MainForm = this;
            Application.Run(Context);
        }
    }
}
