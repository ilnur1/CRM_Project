using CRM_Project.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.ViewModel
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private User user;
        private Team team;
        private Project project;
        private Note note;

        public User User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }

        public Team Team
        {
            get
            {
                return team;
            }
            set
            {
                team = value;
                OnPropertyChanged("Team");
            }
        }

        public Project Project
        {
            get
            {
                return project;
            }
            set
            {
                project = value;
                OnPropertyChanged("Project");
            }
        }

        public Note Note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
                OnPropertyChanged("Note");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
