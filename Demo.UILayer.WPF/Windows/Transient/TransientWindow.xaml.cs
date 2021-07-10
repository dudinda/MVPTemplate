using System.Windows.Controls;

using Demo.PresentationLayer.Views;
using Demo.UILayer.WPF.WindowEventBinders.Transient.Interface;
using Demo.UILayer.WPF.WindowExposers;

namespace Demo.UILayer.WPF.Windows.Transient
{
    /// <summary>
    /// Interaction logic for TransientWindow.xaml
    /// </summary>
    public partial class TransientWindow : BaseWindow,
        ITransientFormView, ITransientWindowExposer
    {
        private readonly ITransientWindowEventBinder _binder;

        public TransientWindow(ITransientWindowEventBinder binder)
        {
            InitializeComponent();

            _binder = binder;
            _binder.OnElementExpose(this);
        }

        public new void Show()
        {
            Header.Content += GetHashCode().ToString();

            base.Show();
        }

        public Button Message
            => SendMessage;

        public void Tooltip(string msg)
        {
            
        }
    }
}
