using System;
using System.Collections.Generic;
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
using UBB_SE_2024_Team_42.Domain;
using System.Linq;
namespace UBB_SE_2024_Team_42.GUI
{
    /// <summary>
    /// Interaction logic for SearchQuestionPage.xaml
    /// </summary>
    public partial class SearchQuestionPage : Page
    {
        public ObservableCollection<Question> Posts { get; set; }

        public SearchQuestionPage(WindowManager manager)
        {
            InitializeComponent();

            Posts = new ObservableCollection<Question>
            {
               new Question(1, 1, "How to use WPF?1", new Category(1, "UI"), "I'm having trouble understanding WPF. Can someone help me?", new DateTime(2024, 4, 17), DateTime.Now, "Question", new List<Vote>(), new List<Tag>()),
               new Question(1, 1, "How to use WPF?2", new Category(1, "UI"), "I'm having trouble understanding WPF. Can someone help me?", new DateTime(2024, 4, 18), DateTime.Now, "Question", new List<Vote>(), new List<Tag>()),
               new Question(1, 1, "How to use WPF?3", new Category(1, "UI"), "I'm having trouble understanding WPF. Can someone help me?", new DateTime(2024, 4, 11), DateTime.Now, "Question", new List<Vote>(), new List<Tag>())
            };
            DataContext = this; // Set DataContext to enable data binding
        }

        private void QuestionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void QuestionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewestSort_Click(object sender, RoutedEventArgs e)
        {
            Posts = new ObservableCollection<Question>(Posts.OrderByDescending(q => q.datePosted));
            // Update the DataContext to refresh the UI
            DataContext = this;
        }

    }
}
