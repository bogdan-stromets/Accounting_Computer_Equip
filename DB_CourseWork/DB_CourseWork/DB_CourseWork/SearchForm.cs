using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.ActiveDirectory;
using DB_CourseWork.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DB_CourseWork
{
    public partial class SearchForm : Form
    {
        internal string? nameTable = string.Empty;
        internal object? table;

        public SearchForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex= 0;
            comboBox1.Items.AddRange(DB_Controller.Table.Keys.ToArray());
            DB_Controller.searchForm = this;
            System.Windows.Forms.ToolTip tip = new System.Windows.Forms.ToolTip();
            tip.SetToolTip(search_Btn, "Пошук");
        }
        
        private void search_Btn_Click(object sender, EventArgs e)
        {
            string seachTxt = textBox1.Text;
            switch (comboBox1.SelectedItem as string)
            {
                case "Остання обрана таблиця":
                    break;
                default:
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        nameTable = dbContext.Model.FindEntityType(DB_Controller.Table[comboBox1.SelectedItem as string]).GetTableName();
                        table = dbContext.Model.FindEntityType(DB_Controller.Table[comboBox1.SelectedItem as string]);
                    };
                    break;
            }

            IEntityType? entityType = table as IEntityType;
            string[] columnNames = entityType.GetProperties().Select(p => p.GetColumnName()).ToArray();
            string[] columnTypes = entityType.GetProperties().Select(p => p.GetColumnType()).ToArray();
            
            string query = $"SELECT * FROM {nameTable} WHERE ";
            for (int i = 0; i < columnNames.Length; i++)
            {
                string name = columnNames[i];
                string type = columnTypes[i];
                if (type == "integer" || type == "boolean") continue;

                query += $"{name} LIKE '%{seachTxt}%'";

                if (columnNames[columnNames.Length - 1] != name)
                    query += " OR ";
            }
            if (query.EndsWith(" OR ")) {
                int index = query.LastIndexOf(" OR ");
                query = query.Substring(0, index);
            }

            using (AccountingContext dbContext = new AccountingContext())
            {
                PropertyInfo[] properties = dbContext.GetType().GetProperties();                                                  
                PropertyInfo? chosenProperty = null;

                foreach (var item in properties)
                {
                    if (item.PropertyType.GetGenericArguments()[0] == Type.GetType(entityType.Name))
                    {
                        chosenProperty = item;
                        break;
                    }
                }
                if (chosenProperty != null)
                    DB_Controller.GetResult(chosenProperty?.GetValue(dbContext),query,nameTable);
            };
        }
    }
}
