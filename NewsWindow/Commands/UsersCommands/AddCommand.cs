using NewsWindow.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            using (PostDbEntities2 cashDbContext = new PostDbEntities2())
            {

                List<string> errorMessages = new List<string>();
                try
                {
                    var item = UserViewModel.CurrentUser;
                    cashDbContext.Users.Add(item);
                    cashDbContext.SaveChanges();
                    UserViewModel.AllUsers.Add(item);
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (DbEntityValidationResult validationResult in ex.EntityValidationErrors)
                    {
                        string entityName = validationResult.Entry.Entity.GetType().Name;
                        foreach (DbValidationError error in validationResult.ValidationErrors)
                        {
                            errorMessages.Add(entityName + "." + error.PropertyName + ": " + error.ErrorMessage);
                        }
                    }
                }

            }

        }
    }
}
