using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
using SmartCasherProject.Entities.ProductManagmentEntities;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartCasherProject.Entities.UsersManagmentEntities
    
{
    
    public class User : IEntityDates,INotifyPropertyChanged
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

        private DateTime _createdAt;
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;

        private DateTime? _deletedAt;
        public DateTime? deletedAt
        {
            get
            { return _deletedAt; }
            set
            {
                if (value == _deletedAt) return;
                _deletedAt = value;
                OnPropertyChanged();
            }
        }

        private string _firstName;
        public string firstName
        {
            get
            { return _firstName; }
            set
            {
                if (value == _firstName) return;
                _firstName = value;
                OnPropertyChanged();
            }
        }

        private string _lastName;
        public string lastName
        {
            get
            { return _lastName; }
            set
            {
                if (value == _lastName) return;
                _lastName = value;
                OnPropertyChanged();
            }
        }

        private string _nickName;
        public string nickName
        {
            get
            { return _nickName; }
            set
            {
                if (value == _nickName) return;
                _nickName = value;
                OnPropertyChanged();
            }
        }

        private string _address;
        public string address
        {
            get
            { return _address; }
            set
            {
                if (value == _address) return;
                _address = value;
                OnPropertyChanged();
            }
        }

        private string _description;
        public string description
        {
            get
            { return _description; }
            set
            {
                if (value == _description) return;
                _description = value;
                OnPropertyChanged();
            }
        }

        private string _imageUrl;
        public string imageUrl
        {
            get
            { return _imageUrl; }
            set
            {
                if (value == _imageUrl) return;
                _imageUrl = value;
                OnPropertyChanged();
            }
        }

        private string _password;
        public string password
        {
            get
            { return _password; }
            set
            {
                if (value == _password) return;
                _password = value;
                OnPropertyChanged();
            }
        }

        private bool _isAdmin;
        public bool isAdmin
        {
            get
            { return _isAdmin; }
            set
            {
                if (value == _isAdmin) return;
                _isAdmin = value;
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


        private int? _groupId;
        [ForeignKey("group")]
        public int? groupId
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

        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
