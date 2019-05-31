using NewsWindow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NewsWindow.Commands.UsersCommands
{
    public class AddCommand : ICommand
    {
        public AddCommand(UserViewModel userViewModel)
        {
            UserViewModel = userViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public UserViewModel UserViewModel { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           

        }
    }
}
