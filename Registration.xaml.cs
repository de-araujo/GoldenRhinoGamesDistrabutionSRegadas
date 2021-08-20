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

namespace GoldenRhinoGameDistribution
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (tbPassword.Password == tbVerifyPassword.Password)
            {
                GoldenRhinoGameDistribution.GoldenRhinoDataContext context = new GoldenRhinoDataContext();
                Login_reg user = context.Login_regs.FirstOrDefault(User => User.Username == tbUsername.Text);
                if (user != default)
                    return;
            
                Login_reg newUser = new Login_reg() { Email = tbEmail.Text, Password = BCrypt.Net.BCrypt.HashPassword(tbPassword.Password), Username = tbUsername.Text };
                context.Login_regs.InsertOnSubmit(newUser);
                context.SubmitChanges();
                new MainWindow(newUser.ID).Show();
                this.Close();
            }
        }
    }
}
