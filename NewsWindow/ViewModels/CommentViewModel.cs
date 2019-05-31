
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWindow.ViewModels
{
   public class CommentViewModel:BaseViewModel
    {
        //public AddCommand AddCommand => new AddCommand(this);
        //public DeleteCommand DeleteCommand => new DeleteCommand(this);
        //public UpdateCommand UpdateCommand => new UpdateCommand(this);
        private ObservableCollection<Comment> allComments;
        public ObservableCollection<Comment> AllComments
        {
            get
            {
                return allComments;
            }
            set
            {
                allComments = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllComments)));
            }
        }
        public CommentViewModel()
        {
            CurrentComment = new Comment();

        }

        private Comment currentComment;
        public Comment CurrentComment
        {
            get
            {
                return currentComment;
            }
            set
            {
                currentComment = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentComment)));
            }
        }

        private Comment selectedComment;
        public Comment SelectedComment
        {
            get
            {
                return selectedComment;
            }
            set
            {
                selectedComment = value;
                if (value != null)
                {
                    //CurrentComment = SelectedComment.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedComment)));
            }
        }
    }
}
