using System;

using Demo.PresentationLayer.Views;
using Demo.UILayer.WPF.WindowExposers;

namespace Demo.UILayer.WPF.Windows.Transient
{
    /// <summary>
    /// Interaction logic for TransientWindow.xaml
    /// </summary>
    public partial class TransientWindow : BaseWindow,
        ITransientFormView, ITransientWindowExposer
    {
        public TransientWindow()
        {
            InitializeComponent();
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
