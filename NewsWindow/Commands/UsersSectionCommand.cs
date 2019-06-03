using NewsWindow.ViewModels;
using NewsWindow.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NewsWindow.Commands
{
    public class UsersSectionCommand : ICommand
    {
        public UsersSectionCommand(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public MainViewModel MainViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        int count = 0;
        public void SetNoOfFilials()
        {
            var count = UserViewModel.AllUsers.Count;
            for (int i = 0, i2 = 1; i < count; i++, i2++)
            {

                UserViewModel.AllUsers[i].No = i2;
            }
        }
        public UserViewModel UserViewModel { get; set; }
        public void Execute(object parameter)
        {
            
            UserViewModel = new UserViewModel();
            using (PostDbEntities4 dbcontext = new PostDbEntities4())
            {
                UserViewModel.AllUsers = new ObservableCollection<User>(dbcontext.Users.ToList());

                //dbcontext.SaveChanges();
            }
            SetNoOfFilials();

            UsersWindow usersWindow = new UsersWindow(UserViewModel);
            usersWindow.ShowDialog();
        }
    }
}
