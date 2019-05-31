﻿using NewsWindow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewsWindow.Views
{
    /// <summary>
    /// Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        public UserViewModel UserViewModel { get; set; }
        public UsersWindow(UserViewModel UserViewModel)
        {
            InitializeComponent();
            this.UserViewModel = UserViewModel;
            DataContext = UserViewModel;
        }
    }
}
