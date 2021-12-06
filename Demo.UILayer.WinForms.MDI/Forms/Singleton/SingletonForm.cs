using System.Windows.Forms;

using Demo.PresentationLayer.Presenters;
using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.MDI.FormEventBinders.SingletonForm.Interface;
using Demo.UILayer.WinForms.MDI.FormExposers;

namespace Demo.UILayer.WinForms.MDI.Forms.Singleton
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

            Controller
                .Aggregator
                .Unsubscribe(typeof(SingletonWindowPresenter), this);

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
