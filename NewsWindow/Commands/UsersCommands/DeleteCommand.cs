using NewsWindow.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NewsWindow.Commands.UsersCommands
{
    public class DeleteCommand : ICommand
    {
        public DeleteCommand(UserViewModel userViewModel)
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
                //bool oldvalid = cashDbContext.Configuration.ValidateOnSaveEnabled;
                try
                {
                    //cashDbContext.Configuration.ValidateOnSaveEnabled = false;
                var item = UserViewModel.SelectedUser;
                    //cashDbContext.Users.Attach(item);
                    cashDbContext.Entry(item).State = EntityState.Deleted;
                    cashDbContext.SaveChanges();
                    UserViewModel.AllUsers.Remove(item);
                    UserViewModel.CurrentUser = new User();
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
