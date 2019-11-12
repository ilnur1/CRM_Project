using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CRM_Project.Model
{
    public class Note : INotifyPropertyChanged
    {
        private uint id;
        private string noteName;

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
        public string NoteName
        {
            get
            {
                return noteName;
            }
            set
            {
                noteName = value;
                OnPropertyChanged("NoteName");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
