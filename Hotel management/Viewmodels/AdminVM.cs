using Hotel_management.Models.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Viewmodels
{
    internal class AdminVM : BasePropertyChanged
    {
        public ObservableCollection<User> Users { get; set; }

        private User selectedUser = new User();
        public User SelectedUser {
            get
            {
                return selectedUser;
            }
            set
            {
                selectedUser = value;
                NotifyPropertyChanged("SelectedUser");
            }
        }
        public AdminVM()
        {
            UserBLL userBLL = new UserBLL();
            Users = new ObservableCollection<User>();
            Users = userBLL.GetAllUsers();
        }
    }
}
