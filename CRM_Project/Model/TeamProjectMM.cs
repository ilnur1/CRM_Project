using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Model
{
    public class TeamProjectMM : INotifyPropertyChanged
    {
        private uint id;
        private uint idTeam;
        private uint idProject;

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

        public uint IdProject
        {
            get
            {
                return idProject;
            }
            set
            {
                idProject = value;
                OnPropertyChanged("IdProject");
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

        [ForeignKey("idProject")]
        public virtual Project Project
        {
            get
            {
                return Project;
            }
            set
            {
                Project = value;
                OnPropertyChanged("Project");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
