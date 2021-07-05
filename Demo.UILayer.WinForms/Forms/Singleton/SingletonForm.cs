using System.Windows.Forms;

using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.FormEventBinders.SingletonForm.Interface;
using Demo.UILayer.WinForms.FormExposers;

namespace Demo.UILayer.WinForms.Forms.Singleton
{
    public partial class SingletonForm : BaseForm,
        ISingletonFormView, ISingletonFormExposer
    {
        private readonly ISingletonFormEventBinder _binder;

        public SingletonForm(ISingletonFormEventBinder binder)
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
