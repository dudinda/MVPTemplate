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
            var hash = GetHashCode().ToString();

            if(!IdLabel.Text.Contains(hash))
            {
                IdLabel.Text += hash;
            }
          
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

        /// <summary>
        /// Used by a DI container to dispose the singleton form
        /// on Release().
        public new void Dispose()
        {
            if (components != null)
            {
                components.Dispose();
            }

            base.Dispose(true);
        }

        /// <summary>
        /// Restrict the generated <see cref="Dispose(bool)"/> call
        /// on a non-context form closing.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
