using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.UsersManagmentEntities
{
   
    public partial class GroupPermission : INotifyPropertyChanged
    {
        [Key]
        public long id
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
        public bool delete
        {
            get
            { return deleteU; }
            set
            {
                if (value == deleteU) return;
                deleteU = value;
                OnPropertyChanged();
            }
        }
        public bool create
        {
            get
            { return createU; }
            set
            {
                if (value == createU) return;
                createU = value;
                OnPropertyChanged();
            }
        }
        public bool edit
        {
            get
            { return editU; }
            set
            {
                if (value == editU) return;
                editU = value;
                OnPropertyChanged();
            }
        }
        public bool read
        {
            get
            { return readU; }
            set
            {
                if (value == readU) return;
                readU = value;
                OnPropertyChanged();
            }
        }

        [ForeignKey("group")]
        public int groupId
        {
            get
            { return groupIdU; }
            set
            {
                if (value == groupIdU) return;
                groupIdU = value;
                OnPropertyChanged();
            }
        }
       

        [ForeignKey("module")]
        public int moduleId
        {
            get
            { return moduleIdU; }
            set
            {
                if (value == moduleIdU) return;
                moduleIdU = value;
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
