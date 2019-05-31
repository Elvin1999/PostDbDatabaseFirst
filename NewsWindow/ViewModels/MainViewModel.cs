using NewsWindow.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWindow.ViewModels
{
   public class MainViewModel:BaseViewModel
    {
        public CommentsSectionCommand CommentsSectionCommand => new CommentsSectionCommand(this);
        public NewsSectionCommand NewsSectionCommand => new NewsSectionCommand(this);
        public UsersSectionCommand UsersSectionCommand => new UsersSectionCommand(this);
    }
}
