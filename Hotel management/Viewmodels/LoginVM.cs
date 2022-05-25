using Hotel_management.Commands;
using Hotel_management.Models.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Hotel_management.Viewmodels
{
    internal class LoginVM : BasePropertyChanged
    {
        private string name;
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }
        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                NotifyPropertyChanged("Surname");
            }
        }
        private string password;
        public string Password {
            get
            {
                return password;
            }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }
        //private LoginCommand login;
        //public ICommand Login { get => login; }
        public ObservableCollection<User> Users {get;set;}

        public LoginVM()
        {
            UserBLL userBLL = new UserBLL();
            //login = new LoginCommand(this);
            Users = userBLL.GetAllUsers();
        }
    }
}
