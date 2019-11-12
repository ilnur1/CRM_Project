using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CRM_Project.Model
{
   public class Project : INotifyPropertyChanged
    {
        private uint id;
        private string projectName;
        private DateTime dateCreate;

        public uint ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }

        public string ProjectName
        {
            get
            {
                return projectName;
            }
            set
            {
                projectName = value;
                OnPropertyChanged("ProjectName");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
