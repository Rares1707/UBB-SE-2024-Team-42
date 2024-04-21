using System;
using System.Collections.Generic;
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

namespace UBB_SE_2024_Team_42.GUI
{
    /// <summary>
    /// Interaction logic for Comment.xaml
    /// </summary>
    public partial class Comment : UserControl
    {
        public static readonly DependencyProperty ContentPropertyComment =
            DependencyProperty.Register("Content", typeof(string), typeof(Comment), new PropertyMetadata(""));

        public static readonly DependencyProperty DatePostedProperty =
            DependencyProperty.Register("Date", typeof(string), typeof(Comment), new PropertyMetadata(""));

        public string CommentContent
        {
            get { return (string)GetValue(ContentPropertyComment); }
            set { SetValue(ContentPropertyComment, value); }
        }


        public string Date
        {
            get { return (string)GetValue(DatePostedProperty); }
            set { SetValue(DatePostedProperty, value); }
        }

        public Comment()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
