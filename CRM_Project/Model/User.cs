using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace CRM_Project.Model
{
    public class User : INotifyPropertyChanged
    {
        private uint id;
        private string firstName;
        private string lastName;
        private string login;
        private string password;

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

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public ICollection<Note> Notes
        {
            get
            {
                return Notes;
            }
            set
            {
                Notes = value;
                OnPropertyChanged("Notes");
            }
        }

        public ICollection<Project> Projects
        {
            get
            {
                return Projects;
            }
            set
            {
                Projects = value;
                OnPropertyChanged("Projects");
            }
        }

        public ICollection<TeamUserMM> TeamUserMMs
        {
            get
            {
                return TeamUserMMs;
            }
            set
            {
                TeamUserMMs = value;
                OnPropertyChanged("TeamUserMMs");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName ="")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
