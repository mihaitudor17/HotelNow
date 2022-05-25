using Hotel_management.Models.Business_Logic_Layer;
using Hotel_management.Viewmodels;
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

namespace Hotel_management.Views
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            var dc = DataContext as AdminVM;

            User user = new User()
            {
                name = dc.SelectedUser.name,
                surname = dc.SelectedUser.surname,
                password = dc.SelectedUser.password,
                type = dc.SelectedUser.type,
            };
            dc.Users.Add(user);
            userBLL.AddUser(user);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            var dc = DataContext as AdminVM;
            var newUser = new User();
            newUser = dc.SelectedUser;
            var user = dc.Users.First(x => x.id == newUser.id);
            dc.Users[dc.Users.IndexOf(user)]= newUser;
            userBLL.ModifyUser(newUser);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            var dc = DataContext as AdminVM;
            var newUser = new User();
            newUser = dc.SelectedUser;
            var user = dc.Users.First(x => x.id == newUser.id);
            dc.Users.Remove(user);
            userBLL.DeleteUser(newUser.id);
        }
    }
}
