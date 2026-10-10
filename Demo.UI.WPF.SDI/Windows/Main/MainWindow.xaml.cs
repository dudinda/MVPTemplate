using System;
using System.ComponentModel;
using System.Windows.Controls;

using Demo.Presentation.Presenters;
using Demo.Presentation.Views;
using Demo.UI.WPF.SDI.Services.WindowEventBinders.Main.Interface;
using Demo.UI.WPF.SDI.Services.WindowExposers;

using ImageProcessing.Microkernel.MVP.Services.Controller.Implementation;

namespace Demo.UI.WPF.SDI.Windows.Main
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

            AppController.Controller.Dispose();
            base.OnClosing(e);
            Environment.Exit(0);
        }
    }
}
