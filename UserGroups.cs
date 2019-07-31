using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    public class UserGroup:INotifyPropertyChanged
    {
        private int _id;
        [Key]
        public int id
        {
            get
            { return _id; }
            set
            {
                if (value == _id) return;
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _groupName;
        public string groupName
        {
            get
            { return _groupName; }
            set
            {
                if (value == _groupName) return;
                _groupName = value;
                OnPropertyChanged();
            }
        }

        private string _groupDescription;
        public string groupDescription
        {
            get
            { return _groupDescription; }
            set
            {
                if (value == _groupDescription) return;
                _groupDescription = value;
                OnPropertyChanged();
            }
        }
        public virtual ObservableCollection<User> users { get; set; }
        public virtual ObservableCollection<GroupPermission> permissions { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
