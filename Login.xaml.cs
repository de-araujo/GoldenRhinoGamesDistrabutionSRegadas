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
using static BCrypt.Net.BCrypt;

namespace GoldenRhinoGameDistribution
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            GoldenRhinoGameDistribution.GoldenRhinoDataContext context = new GoldenRhinoDataContext();
            Login_reg user = context.Login_regs.FirstOrDefault(User => User.Username == tbUsername.Text);
            if (user == default)
                return;
            if (Verify(tbPassword.Password, user.Password))
            {
                new MainWindow(user.ID).Show();
                this.Close();
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
            this.Close();
        }
    }
}
