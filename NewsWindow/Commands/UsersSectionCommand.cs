using NewsWindow.ViewModels;
using System;
using System.Collections.Generic;
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

        public bool CanExecute(object parameter)F
        {
            return true;
        }
        int count = 0;
        public void SetNoOfFilials()
        {
            var count = MainViewModel.AllFilials.Count;
            for (int i = 0, i2 = 1; i < count; i++, i2++)
            {

                FilialViewModel.AllFilials[i].No = i2;
            }
        }
            UserViewModel userViewModel = new UserViewModel();
        public void Execute(object parameter)
        {
            using (UsersDbEntities dbcontext = new FilialDbEntities())
            {
                FilialViewModel.AllFilials = new ObservableCollection<Filials>(dbcontext.Filials.ToList());

                //dbcontext.SaveChanges();
            }
            SetNoOfFilials();
            DataContext = FilialViewModel;

        }
    }
}
