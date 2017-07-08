﻿
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace Library
{
    abstract class BaseNavigationViewModel : INotifyPropertyChanged
    {
        protected object selectedMenu;
        protected object selectedViewModel;

        public object SelectedViewModel
        {
            get { return selectedViewModel; }
            set { selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }
        }

        public object SelectedMenu
        {
            get { return selectedMenu; }
            set { selectedMenu = value; OnPropertyChanged("SelectedMenu"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }                    
    }
}

