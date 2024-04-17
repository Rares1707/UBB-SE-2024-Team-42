using System.Collections.ObjectModel;
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
using UBB_SE_2024_Team_42.Domain;

namespace UBB_SE_2024_Team_42
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Question> Posts { get; set; }
        public MainWindow()
        {

            InitializeComponent();
            DataContext = this;
            Posts = new ObservableCollection<Question>
            {
               new Question(1, 1, "How to use WPF?", "UI", "I'm having trouble understanding WPF. Can someone help me?", new DateOnly(2024, 4, 16), false, "Question", new List<Vote>()),
               new Question(1, 1, "How to use WPF?", "UI", "I'm having trouble understanding WPF. Can someone help me?", new DateOnly(2024, 4, 16), false, "Question", new List<Vote>()),
               new Question(1, 1, "How to use WPF?", "UI", "I'm having trouble understanding WPF. Can someone help me?", new DateOnly(2024, 4, 16), false, "Question", new List<Vote>())
            };
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}