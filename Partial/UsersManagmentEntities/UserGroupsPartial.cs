using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    public partial class UserGroup : INotifyPropertyChanged
    {
        [Key]
        public int id
        {
            get
            { return idU; }
            set
            {
                if (value == idU) return;
                idU = value;
                OnPropertyChanged();
            }
        }
        public string groupName
        {
            get
            { return groupNameU; }
            set
            {
                if (value == groupNameU) return;
                groupNameU = value;
                OnPropertyChanged();
            }
        }
        public string groupDescription
        {
            get
            { return groupDescriptionU; }
            set
            {
                if (value == groupDescriptionU) return;
                groupDescriptionU = value;
                OnPropertyChanged();
            }
        }
        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
