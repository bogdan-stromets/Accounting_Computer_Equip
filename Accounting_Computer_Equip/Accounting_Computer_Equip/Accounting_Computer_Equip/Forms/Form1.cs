using Accounting_Computer_Equip.Models;
using Accounting_Computer_Equip.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.CodeDom;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Accounting_Computer_Equip
{
    public partial class Form1 : Form
    {
        private bool permissionChange = false;
        private bool saved = true;
        private List<object> entities = new List<object>();
        private Type? type;
        private int prev_list_ind = 0;

        public Form1()
        {
            InitializeComponent();
            InitForm();
        }
        private void InitForm()
        {
           // DB_Controller.mainForm = this;
            DB_Grid.AutoGenerateColumns = true;
            DB_Grid.ReadOnly = true;

            table_List.Items.AddRange(DB_Controller.Table.Keys.ToArray());
            table_List.SelectedIndex = 0;

            System.Windows.Forms.ToolTip tip = new System.Windows.Forms.ToolTip();
            tip.SetToolTip(Change_btn, "Редагування\r\n(Вимк/Увім)");
            tip.SetToolTip(Add_Row_Btn, "Додати рядок");
            tip.SetToolTip(Remove_Row_Btn, "Видалити рядок");
            tip.SetToolTip(save_btn, "Зберегти зміни");
            tip.SetToolTip(Search_Btn, "Пошук");
        }

        private void GetSelectedTable()
        {
            entities = new List<object>();
            switch (table_List.SelectedItem as String)
            {
                case "Користувачі":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.Users.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
                case "Видатковий матеріал":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.Supplies.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
                case "Периферійні пристрої":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.PeripheralDevices.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
                case "Комплектуючі ПК":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.PcСomponents.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
                case "Офісне обладнання":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.OfficeEquipments.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
                case "Мережеве устаткування":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.NetworkDevices.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
                case "Персональні комп'ютери":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.Computers.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
            }

            DB_Grid.DataSource = entities;

            foreach (DataGridViewColumn column in DB_Grid.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Consolas", 11, FontStyle.Regular);
            }
        }

        private void table_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!saved)
            {
                int chooseInd = table_List.SelectedIndex;

                if (table_List.SelectedIndex == prev_list_ind) return;

                table_List.SelectedIndex = prev_list_ind;
                DialogResult result = MessageBox.Show("Ви забули зберегти зміни! Зберегти?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        SaveBtn_Click(sender, e);
                        table_List.SelectedIndex = chooseInd;
                        break;
                    default:
                        saved = true;
                        table_List.SelectedIndex = chooseInd;
                        break;
                }
            }

            GetSelectedTable();
            type = DB_Controller.Table[table_List.SelectedItem as String];
            prev_list_ind = table_List.SelectedIndex;
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            permissionChange = !permissionChange;
            Text = permissionChange ? "Редагування: Увімкнено" : "Редагування: Вимкнено";
            Change_btn.BackgroundImage = permissionChange ? Resources.on : Resources.off;
            DB_Grid.ReadOnly = !permissionChange;
            DB_Grid.Columns[0].ReadOnly = true;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<List<object>> table_values = DB_Controller.GetRowValues();
            using (AccountingContext dbContext = new AccountingContext())
            {
                try
                {
                    switch (table_List.SelectedItem as String)
                    {
                        case "Користувачі":
                            {
                                List<User> entities = new List<User>();
                                for (int i = 0; i < table_values.Count; i++)
                                {
                                    object instance = Activator.CreateInstance(typeof(User), table_values[i].ToArray());
                                    entities.Add(instance as User);
                                }
                                dbContext.Users.RemoveRange(dbContext.Users.ToList());
                                dbContext.Users.AddRange(entities);
                            }
                            break;
                        case "Видатковий матеріал":
                            {
                                List<Supply> entities = new List<Supply>();
                                for (int i = 0; i < table_values.Count; i++)
                                {
                                    object instance = Activator.CreateInstance(typeof(Supply), table_values[i].ToArray());
                                    entities.Add(instance as Supply);
                                }
                                dbContext.Supplies.RemoveRange(dbContext.Supplies.ToList());
                                dbContext.Supplies.AddRange(entities);
                            }
                            break;
                        case "Периферійні пристрої":
                            {
                                List<PeripheralDevice> entities = new List<PeripheralDevice>();
                                for (int i = 0; i < table_values.Count; i++)
                                {
                                    object instance = Activator.CreateInstance(typeof(PeripheralDevice), table_values[i].ToArray());
                                    entities.Add(instance as PeripheralDevice);
                                }
                                dbContext.PeripheralDevices.RemoveRange(dbContext.PeripheralDevices.ToList());
                                dbContext.PeripheralDevices.AddRange(entities);
                            }
                            break;
                        case "Комплектуючі ПК":
                            {
                                List<PcСomponent> entities = new List<PcСomponent>();
                                for (int i = 0; i < table_values.Count; i++)
                                {
                                    object instance = Activator.CreateInstance(typeof(PcСomponent), table_values[i].ToArray());
                                    entities.Add(instance as PcСomponent);
                                }
                                dbContext.PcСomponents.RemoveRange(dbContext.PcСomponents.ToList());
                                dbContext.PcСomponents.AddRange(entities);
                            }
                            break;
                        case "Офісне обладнання":
                            {
                                List<OfficeEquipment> entities = new List<OfficeEquipment>();
                                for (int i = 0; i < table_values.Count; i++)
                                {
                                    object instance = Activator.CreateInstance(typeof(OfficeEquipment), table_values[i].ToArray());
                                    entities.Add(instance as OfficeEquipment);
                                }
                                dbContext.OfficeEquipments.RemoveRange(dbContext.OfficeEquipments.ToList());
                                dbContext.OfficeEquipments.AddRange(entities);
                            }
                            break;
                        case "Мережеве устаткування":
                            {
                                List<NetworkDevice> entities = new List<NetworkDevice>();
                                for (int i = 0; i < table_values.Count; i++)
                                {
                                    object instance = Activator.CreateInstance(typeof(NetworkDevice), table_values[i].ToArray());
                                    entities.Add(instance as NetworkDevice);
                                }
                                dbContext.NetworkDevices.RemoveRange(dbContext.NetworkDevices.ToList());
                                dbContext.NetworkDevices.AddRange(entities);
                            }
                            break;
                        case "Персональні комп'ютери":
                            {
                                List<Computer> entities = new List<Computer>();
                                for (int i = 0; i < table_values.Count; i++)
                                {
                                    object instance = Activator.CreateInstance(typeof(Computer), table_values[i].ToArray());
                                    entities.Add(instance as Computer);
                                }
                                dbContext.Computers.RemoveRange(dbContext.Computers.ToList());
                                dbContext.Computers.AddRange(entities);
                            }
                            break;
                    }
                    dbContext.SaveChanges();
                    saved = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Не всі дані було введено!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    saved = true;
                }
            };
        }


        private void Add_Row_Btn_Click(object sender, EventArgs e)
        {
            int id = DB_Controller.GetNextId();
            var new_inst = Activator.CreateInstance(type);
            type.GetProperty("Id").SetValue(new_inst, id);

            entities.Add(new_inst);

            DB_Grid.DataSource = null;
            DB_Grid.DataSource = entities;
            DB_Grid.Refresh();
            saved = false;
        }

        private void Remove_Row_Btn_Click(object sender, EventArgs e)
        {
            List<object> del_entities = new List<object>();
            foreach (DataGridViewRow row in DB_Grid.SelectedRows)
            {
                foreach (var item in entities)
                {
                    if ((int)item.GetType().GetProperty("Id").GetValue(item) == (int)row.Cells[0].Value)
                    {
                        entities.Remove(item);
                        break;
                    }
                }
            }
            DB_Grid.DataSource = null;
            DB_Grid.DataSource = entities;
            saved = false;
        }

        private void DB_Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            saved = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DB_Grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DialogResult result = MessageBox.Show("Ви забули зберегти зміни Перед виходом! Зберегти?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        SaveBtn_Click(sender, e);
                        break;
                    default:
                        return;
                }

            }
        }

        private void table_List_MouseWheel(object sender, MouseEventArgs e)
        {
            //відключення прокрутки ComboBox колесиком миші
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void DB_Grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            List<object> listInd = DB_Controller.GetIndexNonStringColumns();
            if (listInd.Contains(DB_Grid.CurrentCell.ColumnIndex) && e.Control is System.Windows.Forms.TextBox textBox)
            {
                textBox.KeyPress += (s, args) =>
                {
                    if (!char.IsControl(args.KeyChar) && !char.IsDigit(args.KeyChar))
                    {
                        args.Handled = true; // Забороняємо введення символів, які не є цифрами
                    }
                };
            }
        }
        private void Search_Btn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();

            searchForm.StartPosition = FormStartPosition.CenterParent;
            using (var dbContext = new AccountingContext())
            {
                searchForm.nameTable = dbContext.Model.FindEntityType(DB_Controller.Table[table_List.SelectedItem as string]).GetTableName();
                searchForm.table = dbContext.Model.FindEntityType(DB_Controller.Table[table_List.SelectedItem as string]);
            };
            searchForm.ShowDialog();
        }
    }
}