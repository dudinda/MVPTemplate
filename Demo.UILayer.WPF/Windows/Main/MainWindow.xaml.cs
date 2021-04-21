
using System.Windows.Controls;

using Demo.PresentationLayer.Views;
using Demo.UILayer.WPF.WindowEventBinders.Main.Interface;
using Demo.UILayer.WPF.WindowExposers;
using Demo.UILayer.WPF.Windows;

namespace Demo.UILayer.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : BaseWindow, 
        IMainView, IMainWindowExposer
    {
        private readonly IMainWindowEventBinder _binder;

        public MainWindow(IMainWindowEventBinder binder) : base()
        {
            InitializeComponent();

            _binder = binder;
            _binder.OnElementExpose(this);
        }

        /// <inheritdoc/>
        public MenuItem TransientMenu
            => Transient;

        /// <inheritdoc/>
        public MenuItem SingletonMenu
            => Singleton;

        public new void Show()
        {
            App.Run(this);
        }
    }
}
