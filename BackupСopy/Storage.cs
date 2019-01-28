using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupСopy
{
    public abstract class Storage
    {
        private string _storageName;
        private string _modelStorage;

        public Storage()
        {
            _storageName = "";
            _modelStorage = "";
        }

        public Storage(string storageName, string modelStorage)
        {
            _storageName = storageName;
           _modelStorage = modelStorage;
        }

        public string StrogeName
        {
            get { return _storageName; }
            set
            {
                    _storageName = value;
            }
        }
        public string ModelStorage
        {
            get {
                return _modelStorage;
            }
            set
            {
                    _modelStorage = value;
            }
        }
        public abstract void GetCountMemory();// получение объема памяти
        public abstract void Copy(double data);// Копирование данных
        public abstract void GetEmptyMemory();// Инф о свободном месте памяти
        public abstract void GetInformation();// Получение инф об устройствеё
    }
}
