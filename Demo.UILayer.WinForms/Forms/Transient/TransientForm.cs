using System.Windows.Forms;

using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.FormEventBinders.TransientForm.Interface;
using Demo.UILayer.WinForms.FormExposers;

namespace Demo.UILayer.WinForms.Forms.Transient
{
    public partial class TransientForm : BaseForm,
        ITransientFormView, ITransientFormExposer
    {
        private readonly ITransientFormEventBinder _binder;

        public TransientForm(ITransientFormEventBinder binder)
        {
            InitializeComponent();

            _binder = binder;
            _binder.OnElementExpose(this);
        }

        public new void Show()
        {
            IdLabel.Text += GetHashCode();
            MdiParent = Context.MainForm;
            base.Show();
        }

        public void Tooltip(string msg)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Button SendMessage
            => SendMessageBtn;
    }
}
