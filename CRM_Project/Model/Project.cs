using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Project.Model
{
   public class Project : INotifyPropertyChanged
    {
        private uint id;
        private string projectName;
        private DateTime dateCreate;
        private uint idUser;
        private uint idTeam;

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

        public uint IdUser
        {
            get
            {
                return idUser;
            }
            set
            {
                idUser = value;
                OnPropertyChanged("IdUser");
            }
        }

        public uint IdTeam
        {
            get
            {
                return idTeam;
            }
            set
            {
                idTeam = value;
                OnPropertyChanged("IdTeam");
            }
        }

        [ForeignKey("idUser")]
        public virtual User User
        {
            get
            {
                return User;
            }
            set
            {
                User = value;
                OnPropertyChanged("User");
            }
        }

        [ForeignKey("idTeam")]
        public virtual Team Team
        {
            get
            {
                return Team;
            }
            set
            {
                Team = value;
                OnPropertyChanged("Team");
            }
        }

        public virtual ICollection<TeamProjectMM> TeamProjectMMs
        {
            get
            {
                return TeamProjectMMs;
            }
            set
            {
                TeamProjectMMs = value;
                OnPropertyChanged("TeamProjectMMs");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
