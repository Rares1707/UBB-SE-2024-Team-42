using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using UBB_SE_2024_Team_42.Service;

namespace UBB_SE_2024_Team_42.GUI
{
    /// <summary>
    /// Interaction logic for ViewQuestionPage.xaml
    /// </summary>
    
    public partial class ViewQuestionPage : Page
    {
        private WindowManager _manager;
        public ObservableCollection<Post> Comments { get; set; }
        public ObservableCollection<Tag> Tags { get; set; }
        public ViewQuestionPage(WindowManager manager)
        {

            _manager = manager;
            InitializeComponent();
            DataContext = this;
            Comments = new ObservableCollection<Post>
            {
                new Post(1, 1, "Lorem Ipsum Dolor est sit amet", "Comment", new List<Vote> { new Vote(1, 4) }, new DateTime(2, 2, 2), new DateTime(4, 4, 4)),
                new Post(2, 2, "Lorem Ipsum Dolor est sit amet", "Comment", new List<Vote> { new Vote(1, 4) }, new DateTime(2, 2, 2), new DateTime(4, 4, 4))
            };
            Tags = new ObservableCollection<Tag>
            {
                new Tag(1, "Hello"),
                new Tag(2, "Good"),
                new Tag(3, "Bye"),
            };
            
    }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ViewQuestionFrame.Navigate(new SearchQuestionPage(_manager));
            //ViewQuestionFrame.Visibility = Visibility.Collapsed;
        }
    }
}

