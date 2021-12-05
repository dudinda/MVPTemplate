using System.Windows.Forms;

using Demo.PresentationLayer.Presenters;
using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.SDI.FormEventBinders.TransientForm.Interface;
using Demo.UILayer.WinForms.SDI.FormExposers;

namespace Demo.UILayer.WinForms.SDI.Forms.Transient
{
    internal sealed partial class TransientForm : BaseForm,
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
        /// Used by the generated <see cref="Dispose(bool)"/> call.
        /// Can be used by a DI container in a singleton scope on Release();
        public new void Dispose()
        {
            if (components != null)
            {
                components.Dispose();
            }

            Controller
               .Aggregator
               .Unsubscribe(typeof(TransientWindowPresenter), this);

            base.Dispose(true);
        }
    }
}
