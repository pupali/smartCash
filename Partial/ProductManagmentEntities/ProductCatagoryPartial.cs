using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.ProductManagmentEntities
{
    public partial class ProductCatagory : INotifyPropertyChanged
    {
        [Key]
        public int catagoryId
        {
            get
            { return catagoryIdP; }
            set
            {
                if (value == catagoryIdP) return;
                catagoryIdP = value;
                OnPropertyChanged();
            }
        }
        public string catagoryName
        {
            get
            { return catagoryNameP; }
            set
            {
                if (value == catagoryNameP) return;
                catagoryNameP = value;
                OnPropertyChanged();
            }
        }
        public string catagoryImage
        {
            get
            { return catagoryImageP; }
            set
            {
                if (value == catagoryImageP) return;
                catagoryImageP = value;
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
