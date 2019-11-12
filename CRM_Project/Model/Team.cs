using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CRM_Project.Model
{
    public class Team : INotifyPropertyChanged
    {
        private uint id;
        private string name;

        public uint ID
        {
            get
            {
                return ID;
            }
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
