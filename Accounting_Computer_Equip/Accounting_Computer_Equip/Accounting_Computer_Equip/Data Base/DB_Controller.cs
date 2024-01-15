using Accounting_Computer_Equip.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Accounting_Computer_Equip
{
    public static class DB_Controller
    {
        public static Accounting? mainForm { get; set; }
        public static SearchForm? searchForm { get; set; }
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
        public static List<object> GetIndexNonStringColumns()
        {
            List<object> listInd = new List<object>();
            foreach (var item in mainForm.DB_Grid.Columns)
            {
                if (!(item is DataGridViewTextBoxColumn)) continue;
                DataGridViewTextBoxColumn? conv_item = item as DataGridViewTextBoxColumn;
                Type type = conv_item.ValueType;
                if (type == typeof(int) || type == typeof(int?))
                    listInd.Add(conv_item.Index);
            }
            return listInd;
        }

        public static List<List<object>> GetRowValues()
        {
            List<object> row_values = new List<object>();
            List<List<object>> table_values = new List<List<object>>();

            for (int i = 0; i < mainForm.DB_Grid.RowCount; i++)
            {
                for (int j = 0; j < mainForm.DB_Grid.ColumnCount; j++)
                {
                    row_values.Add(mainForm.DB_Grid.Rows[i].Cells[j].Value);
                }

                table_values.Add(new List<object>());
                table_values.Last().AddRange(row_values);
                row_values.Clear();
            }
            return table_values;
        }

        public static int GetNextId()
        {
            List<List<object>> values = GetRowValues();
            int maxInd = int.MinValue;
            foreach (var item in values)
            {
                maxInd = (int)((int)item[0] > maxInd ? item[0] : maxInd);
            }

            return maxInd + 1;
        }


        public static void GetResult(object property, string query,string nameTable)
        {
            object? result = null;
            switch (nameTable)
            {
                case "users":
                    result = ((DbSet<User>)property).FromSqlRaw(query).ToList();
                    break;
                case "supplies":
                    result = ((DbSet<Supply>)property).FromSqlRaw(query).ToList();
                    break;
                case "peripheral_devices":
                    result = ((DbSet<PeripheralDevice>)property).FromSqlRaw(query).ToList();
                    break;
                case "pc_Сomponents":
                    result = ((DbSet<PcСomponent>)property).FromSqlRaw(query).ToList();
                    break;
                case "office_equipment":
                    result = ((DbSet<OfficeEquipment>)property).FromSqlRaw(query).ToList();
                    break;
                case "network_devices":
                    result = ((DbSet<NetworkDevice>)property).FromSqlRaw(query).ToList();
                    break;
                case "computers":
                    result = ((DbSet<Computer>)property).FromSqlRaw(query).ToList();
                    break;
            }
            mainForm.DB_Grid.DataSource = result;
        }


    }
}
