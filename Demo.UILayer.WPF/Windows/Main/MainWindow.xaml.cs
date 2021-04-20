
using System.Windows.Controls;

using Demo.PresentationLayer.Views;
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
        public MainWindow() : base()
        {
            InitializeComponent();
            
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
