using NewsWindow.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWindow.ViewModels
{
   public class NewsViewModel:BaseViewModel
    {
        //public AddCommand AddCommand => new AddCommand(this);
        //public DeleteCommand DeleteCommand => new DeleteCommand(this);
        //public UpdateCommand UpdateCommand => new UpdateCommand(this);
        private ObservableCollection<News> allNews;
        public ObservableCollection<News> AllNews
        {
            get
            {
                return allNews;
            }
            set
            {
                allNews = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllNews)));
            }
        }
        public NewsViewModel()
        {
            CurrentNews = new News();

        }

        private News currentNews;
        public News CurrentNews
        {
            get
            {
                return currentNews;
            }
            set
            {
                currentNews = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentNews)));
            }
        }

        private News selectedNews;
        public News SelectedNews
        {
            get
            {
                return selectedNews;
            }
            set
            {
                selectedNews = value;
                if (value != null)
                {
                    CurrentNews = SelectedNews.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedNews)));
            }
        }
    }
}
