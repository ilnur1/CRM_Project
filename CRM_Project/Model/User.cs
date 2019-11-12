using System.ComponentModel;
using System.Runtime.CompilerServices;

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
                return ID;
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
                return FirstName;
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

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName ="")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
