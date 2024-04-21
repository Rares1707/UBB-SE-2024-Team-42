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
    /// Interaction logic for ViewQuestionPage.xaml
    /// </summary>
    public partial class ViewQuestionPage : Page
    {
        private WindowManager _manager;

        public ViewQuestionPage(WindowManager manager) { 
        
            _manager = manager;
            InitializeComponent();
        }
    }
}
