using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UBB_SE_2024_Team_42.GUI;
namespace UBB_SE_2024_Team_42
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WindowManager manager;
        public MainWindow()
        {
            manager = new WindowManager();
            InitializeComponent();
            
        }

        private void Start_Click4(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Statistics(manager));
        }

        private void Statistics_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SearchQuestionPage(manager));
        }
    }
}