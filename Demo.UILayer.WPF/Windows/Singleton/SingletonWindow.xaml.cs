using Demo.PresentationLayer.Views;
using Demo.UILayer.WPF.WindowExposers;

namespace Demo.UILayer.WPF.Windows.Singleton
{
    /// <summary>
    /// Interaction logic for SingletonWindow.xaml
    /// </summary>
    public partial class SingletonWindow : BaseWindow,
        ISingletonFormView, ISingletonWindowExposer
    {
        public SingletonWindow()
        {
            InitializeComponent();
        }

        public void ShowInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}
