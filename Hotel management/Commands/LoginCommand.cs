using Hotel_management.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Hotel_management.Commands
{
    internal class LoginCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public LoginVM vm;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var foundUser = vm.Users.FirstOrDefault(x => 
            x.name == vm.Name && 
            x.surname==vm.Surname && 
            x.password == vm.Password);
            if(foundUser != null)
            {
                MessageBox.Show("Login succesfull");
            }
            else
            {
                MessageBox.Show("User not found");
            }

        }

        public LoginCommand(LoginVM vm)
        {
            this.vm = vm;
        }
    }
}
