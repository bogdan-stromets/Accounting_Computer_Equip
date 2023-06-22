using DB_CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CourseWork
{
    public static class DB_Controller
    {
        private static Dictionary<string, Type> table = new Dictionary<string, Type>()
        {
            { "Користувачі",typeof(User)},
            { "Видатковий матеріал",typeof(Supply)  },            
            { "Периферійні пристрої" ,typeof(PeripheralDevice)  },
            { "Комплектуючі ПК"  ,typeof(PcСomponent)},           
            {  "Офісне обладнання"  ,typeof(OfficeEquipment)},
            { "Мережеве устаткування" ,typeof(NetworkDevice)},
            {  "Персональні комп'ютери",typeof(Computer)}
        };

        public static Dictionary<string, Type> Table { get => table; }

    }
}
