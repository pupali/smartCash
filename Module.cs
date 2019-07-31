using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    public class Module:INotifyPropertyChanged
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

        private string _moduleName;
        public string moduleName
        {
            get
            { return _moduleName; }
            set
            {
                if (value == _moduleName) return;
                _moduleName = value;
                OnPropertyChanged();
            }
        }

        private string _moduleDescription;
        public string moduleDescription
        {
            get
            { return _moduleDescription; }
            set
            {
                if (value == _moduleDescription) return;
                _moduleDescription = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<UserPermission> _permissions;
        public ObservableCollection<UserPermission> permissions
        {
            get
            { return _permissions; }
            set
            {
                if (value == _permissions) return;
                _permissions = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<GroupPermission> _groupPermissions;
        public ObservableCollection<GroupPermission> groupPermissions
        {
            get
            { return _groupPermissions; }
            set
            {
                if (value == _groupPermissions) return;
                _groupPermissions = value;
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
