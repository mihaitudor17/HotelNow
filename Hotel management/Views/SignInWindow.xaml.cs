using Hotel_management.Models.Business_Logic_Layer;
using Hotel_management.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
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

namespace Hotel_management.Views
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((DataContext as SignInVM).Password == (DataContext as SignInVM).Password2) {
                UserBLL userBLL = new UserBLL();
                var dc = DataContext as SignInVM;
                userBLL.AddUser(new User()
                {
                    name = dc.Username,
                    surname = dc.Surname,
                    password = dc.Password,
                    type = "Client",
                    deleted = false
                });
            } else {
                MessageBox.Show("The passwords don't match!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
