using NewsWindow.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NewsWindow.Commands.UsersCommands
{
    public class UpdateCommand : ICommand
    {
        public UpdateCommand(UserViewModel userViewModel)
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
            
            using (PostDbEntities5 DbContext = new PostDbEntities5())
            {

                DbContext.Entry(UserViewModel.CurrentUser).State = EntityState.Modified;
                DbContext.SaveChanges();
                UserViewModel.AllUsers = new ObservableCollection<User>(DbContext.Users.ToList());
            }
        }
    }
}
