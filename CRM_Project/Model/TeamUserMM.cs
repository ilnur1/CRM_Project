using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CRM_Project.Model
{
    /// <summary>
    /// класс для связи многие ко многоим Team-User
    /// </summary>
    public class TeamUserMM : INotifyPropertyChanged
    {
        private uint id;
        private uint idTeam;
        private uint idUser;

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

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
