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
using UBB_SE_2024_Team_42.Service;
using UBB_SE_2024_Team_42.Repository;
namespace UBB_SE_2024_Team_42.GUI
{
    /// <summary>
    /// Interaction logic for SearchQuestionPage.xaml
    /// </summary>
    public partial class SearchQuestionPage : Page
    {
        public ObservableCollection<Question> Posts { get; set; }
        //static Repository.Repository repository = new Repository.Repository("placeholder");
        //public Service.Service service = new Service.Service(repository);
        private Service.Service service;

        public SearchQuestionPage(WindowManager manager)
        {
            InitializeComponent();
            service = manager.Service;
            Posts = new ObservableCollection<Question>(service.sortQuestionsByDateDescending());
            DataContext = this; // Set DataContext to enable data binding
        }

        private void QuestionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            List<Question> searchedQuestions = service.searchQuestion(this.SearchBox.Text);
            Posts.Clear();
            foreach (Question question in searchedQuestions)
            {
                Posts.Add(question);
            }
            DataContext = this;
        }
    }
}
