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

namespace GoldenRhinoGameDistribution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int UserId;
        public MainWindow(int userID)
        {
            UserId = userID;
            InitializeComponent();
        }

        private void btnLibrary_Click(object sender, RoutedEventArgs e)
        {
            new Library(UserId).Show();
        }

        private void btnAddGame_Click(object sender, RoutedEventArgs e)
        {
            new AddGame().Show();
        }
    }
}
