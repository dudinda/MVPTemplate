using System.ComponentModel;
using System.Windows.Controls;

using Demo.PresentationLayer.Views;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Singleton.Interface;
using Demo.UILayer.WPF.SDI.WindowExposers;

namespace Demo.UILayer.WPF.SDI.Windows.Singleton
{
    /// <summary>
    /// Interaction logic for SingletonWindow.xaml
    /// </summary>
    internal sealed partial class SingletonWindow : BaseWindow,
        ISingletonFormView, ISingletonWindowExposer
    {
        private readonly ISingletonWindowEventBinder _binder;

        public SingletonWindow(ISingletonWindowEventBinder binder)
        {
            InitializeComponent();

            _binder = binder;
            _binder.OnElementExpose(this);
        }

        public new void Show()
        {
            var hash = GetHashCode().ToString();
            var header = (string)Header.Content;

            if (!header.Contains(hash))
            {
                Header.Content += hash;
            }

            base.Show();
        }

        public Button Message
            => SendMessage;

        /// <summary>
        /// Used by a DI-container in a singleton scope.
        /// </summary>
        public void Dispose()
        {
            Close();
        }

        public void Tooltip(string msg)
        {
            throw new System.NotImplementedException();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
    }
}
