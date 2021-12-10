using System;
using System.Windows.Forms;

using Demo.PresentationLayer.Presenters;
using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.TDI.FormEventBinders.TransientForm.Interface;
using Demo.UILayer.WinForms.TDI.FormExposers;

namespace Demo.UILayer.WinForms.TDI.Forms.Transient
{
    internal sealed partial class TransientForm : BaseForm,
        ITransientFormView, ITransientFormExposer
    {
        private readonly ITransientFormEventBinder _binder;
        private readonly IMainFormExposer _form;
        private readonly TabPage _tab = new TabPage();

        public TransientForm(
            IMainView main,
            ITransientFormEventBinder binder)
        {
            InitializeComponent();
            _binder = binder;
            _binder.OnElementExpose(this);

            TopLevel = false;
            Dock = DockStyle.Fill;

            _form = main as IMainFormExposer;

            _tab.Controls.Add(this);
            _tab.Text = Text;
        }

        public new void Show()
        {
            var hash = GetHashCode().ToString();
            IdLabel.Text += hash;

            _form.TabsCtrl.TabPages.Add(_tab);
            _form.TabsCtrl.SelectedTab = _tab;

            base.Show();
        }

        public new void Close()
        {
            _form.TabsCtrl.TabPages.Remove(_form.TabsCtrl.SelectedTab);
            base.Close();
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Delete)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            Close();
            return true;
        }
    }
}
