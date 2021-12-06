using System;
using System.ComponentModel;
using System.Windows.Controls;

using Demo.PresentationLayer.Presenters;
using Demo.PresentationLayer.Views;
using Demo.UILayer.WPF.SDI.WindowEventBinders.Main.Interface;
using Demo.UILayer.WPF.SDI.WindowExposers;

using ImageProcessing.Microkernel.EntryPoint;

namespace Demo.UILayer.WPF.SDI.Windows.Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    internal sealed partial class MainWindow : BaseWindow, 
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

        public void Tooltip(string message)
        {
            MessageLabel.Content = message;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Controller
                .Aggregator
                .Unsubscribe(typeof(MainPresenter), this);

            AppLifecycle.Exit();
            base.OnClosing(e);
            Environment.Exit(0);
        }
    }
}
