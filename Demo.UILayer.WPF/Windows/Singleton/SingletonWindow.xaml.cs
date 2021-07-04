using System.ComponentModel;
using System.Windows.Controls;

using Demo.PresentationLayer.Views;
using Demo.UILayer.WPF.WindowEventBinders.Singleton.Interface;
using Demo.UILayer.WPF.WindowExposers;

namespace Demo.UILayer.WPF.Windows.Singleton
{
    /// <summary>
    /// Interaction logic for SingletonWindow.xaml
    /// </summary>
    public partial class SingletonWindow : BaseWindow,
        ISingletonFormView, ISingletonWindowExposer
    {
        private readonly ISingletonWindowEventBinder _binder;

        public SingletonWindow(ISingletonWindowEventBinder binder)
        {
            InitializeComponent();

            _binder = binder;
            _binder.OnElementExpose(this);
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
