using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClientWPF.DataBinding.Elements
{
    public class EnableButtons : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool enable = false;
        public bool Enable
        {
            get { return enable; }
            set
            {
                enable = value;
                OnPropertyChanged(nameof(enable));
            }
        }

        public EnableButtons()
        {
            enable = false;
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
