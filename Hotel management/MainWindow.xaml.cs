using Hotel_management.Viewmodels;
using Hotel_management.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace Hotel_management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            //BrowseRooms br = new BrowseRooms(new User()
            //{
            //    id = -1,
            //    name = "Guest",
            //    surname = "",
            //    password = "",
            //    type = "Guest",
            //    deleted = false
            //});
            //br.Show();
            //Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //UserBLL userBLL = new UserBLL();
            ////login = new LoginCommand(this);
            //Users = userBLL.GetAllUsers();
            var foundUser = (DataContext as LoginVM).Users.FirstOrDefault(
                x => /*x.name == (DataContext as LoginVM).Name &&*/
                x.surname == (DataContext as LoginVM).Surname &&
                x.password == (DataContext as LoginVM).Password
                );
            if (foundUser != null)
            {
                BrowseRooms br = new BrowseRooms(foundUser);
                br.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect authentification credentials!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SignInWindow sw = new SignInWindow();
            sw.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BrowseRooms br = new BrowseRooms(new User() { 
                id = -1,
                name = "Guest",
                surname = "",
                password = "",
                type = "Guest",
                deleted = false
            });
            br.Show();
            Close();
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            //SecureString theSecureString = new NetworkCredential("",(string)sender).SecurePassword;
            if (this.DataContext != null)
            {
                string temp = new NetworkCredential("", ((PasswordBox)sender).SecurePassword).Password;
                ((dynamic)this.DataContext).Password = temp;
            }
        }
    }
}
