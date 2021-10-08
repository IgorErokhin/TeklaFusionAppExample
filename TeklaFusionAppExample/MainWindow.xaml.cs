using System.Windows;

namespace TeklaFusionAppExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        
            new System.Windows.Interop.WindowInteropHelper(this).Owner = Tekla.Structures.Dialog.MainWindow.Frame.Handle;
        }
    }
}
