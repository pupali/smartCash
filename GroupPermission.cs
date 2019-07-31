using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    public class GroupPermission:INotifyPropertyChanged
    {

        private long _id;
        [Key]
        public long id
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

        private bool _delete;
        public bool delete
        {
            get
            { return _delete; }
            set
            {
                if (value == _delete) return;
                _delete = value;
                OnPropertyChanged();
            }
        }

        private bool _create;
        public bool create
        {
            get
            { return _create; }
            set
            {
                if (value == _create) return;
                _create = value;
                OnPropertyChanged();
            }
        }

        private bool _edit;
        public bool edit
        {
            get
            { return _edit; }
            set
            {
                if (value == _edit) return;
                _edit = value;
                OnPropertyChanged();
            }
        }

        private bool _read;
        public bool read
        {
            get
            { return _read; }
            set
            {
                if (value == _read) return;
                _read = value;
                OnPropertyChanged();
            }
        }

        private int _groupId;
        [ForeignKey("group")]
        public int groupId
        {
            get
            { return _groupId; }
            set
            {
                if (value == _groupId) return;
                _groupId = value;
                OnPropertyChanged();
            }
        }

        private UserGroup _group;
        public UserGroup group
        {
            get
            { return _group; }
            set
            {
                if (value == _group) return;
                _group = value;
                OnPropertyChanged();
            }
        }

        private int _moduleId;
        [ForeignKey("module")]
        public int moduleId
        {
            get
            { return _moduleId; }
            set
            {
                if (value == _moduleId) return;
                _moduleId = value;
                OnPropertyChanged();
            }
        }

        private Module _module;
        public Module module
        {
            get
            { return _module; }
            set
            {
                if (value == _module) return;
                _module = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
