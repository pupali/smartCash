using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCasherProject.Entities.StorageManagmentEntities
{
    public class Storage
    {
        public int id { get; set; }
        public string storageName { get; set; }
        public string storageAddress { get; set; }
        public string storagePhone { get; set; }

        public virtual ObservableCollection<StoredProduct> products { get; set; }
    }
}

