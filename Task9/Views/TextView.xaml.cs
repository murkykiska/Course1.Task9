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
using System.Windows.Shapes;
using Task9.ViewModels;

namespace Task9.Views
{
    /// <summary>
    /// Логика взаимодействия для TextView.xaml
    /// </summary>
    public partial class TextView : Window
    {
        public TextView()
        {
            InitializeComponent();
            DataContext = new TextViewModel();
        }
    }
}
