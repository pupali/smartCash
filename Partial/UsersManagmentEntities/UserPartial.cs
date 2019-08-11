using SmartCasherProject.Entities.UsersManagmentEntities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.UsersManagmentEntities
{
    public partial class User:INotifyPropertyChanged
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

        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;
        public DateTime? deletedAt
        {
            get
            { return deletedAtU; }
            set
            {
                if (value == deletedAtU) return;
                deletedAtU = value;
                OnPropertyChanged();
            }
        }
        public string firstName
        {
            get
            { return firstNameU; }
            set
            {
                if (value == firstNameU) return;
                firstNameU = value;
                OnPropertyChanged();
            }
        }
        public string lastName
        {
            get
            { return lastNameU; }
            set
            {
                if (value == lastNameU) return;
                lastNameU = value;
                OnPropertyChanged();
            }
        }
        public string nickName
        {
            get
            { return nickNameU; }
            set
            {
                if (value == nickNameU) return;
                nickNameU = value;
                OnPropertyChanged();
            }
        }
        public string address
        {
            get
            { return addressU; }
            set
            {
                if (value == addressU) return;
                addressU = value;
                OnPropertyChanged();
            }
        }
        public string description
        {
            get
            { return descriptionU; }
            set
            {
                if (value == descriptionU) return;
                descriptionU = value;
                OnPropertyChanged();
            }
        }
        public string imageUrl
        {
            get
            { return imageUrlU; }
            set
            {
                if (value == imageUrlU) return;
                imageUrlU = value;
                OnPropertyChanged();
            }
        }
        public string password
        {
            get
            { return passwordU; }
            set
            {
                if (value == passwordU) return;
                passwordU = value;
                OnPropertyChanged();
            }
        }
        public bool isAdmin
        {
            get
            { return isAdminU; }
            set
            {
                if (value == isAdminU) return;
                isAdminU = value;
                OnPropertyChanged();
            }
        }


        


        [ForeignKey("group")]
        public int? groupId
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
       
        internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
