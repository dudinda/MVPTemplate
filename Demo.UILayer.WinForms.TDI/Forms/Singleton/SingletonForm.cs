using System;
using System.Windows.Forms;

using Demo.PresentationLayer.Presenters;
using Demo.PresentationLayer.Views;
using Demo.UILayer.WinForms.TDI.FormEventBinders.SingletonForm.Interface;
using Demo.UILayer.WinForms.TDI.FormExposers;

namespace Demo.UILayer.WinForms.TDI.Forms.Singleton
{
    internal sealed partial class SingletonForm : BaseForm,
        ISingletonFormView, ISingletonFormExposer
    {
        private readonly ISingletonFormEventBinder _binder;
        private readonly IMainFormExposer _form;
        private readonly TabPage  _tab = new TabPage();

        public SingletonForm(
            IMainView main,
            ISingletonFormEventBinder binder)
        {
            InitializeComponent();
            _binder = binder;
            _binder.OnElementExpose(this);

            TopLevel = false;
            Dock = DockStyle.Fill;

            _tab.Controls.Add(this);
            _tab.Text = Text;

            _form = main as IMainFormExposer;
        }

        public new void Show()
        {
            var hash = GetHashCode().ToString();

            if(!IdLabel.Text.Contains(hash))
            {
                IdLabel.Text += hash;
            }

            if (!_form.TabsCtrl.TabPages.Contains(_tab))
            {
                _form.TabsCtrl.TabPages.Add(_tab);
                _form.TabsCtrl.SelectedTab = _tab;
            }

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData != Keys.Delete)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            Close();
            return true;
        }
    }
}
