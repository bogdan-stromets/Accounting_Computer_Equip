using DB_CourseWork.Models;
using System.CodeDom;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace DB_CourseWork
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
            DB_Grid.AutoGenerateColumns= true;
            DB_Grid.ReadOnly= true;

            table_List.Items.AddRange(DB_Controller.Table.Keys.ToArray());
            table_List.SelectedIndex= 0;
        }

        private void GetSelectedTable()
        {
            entities = new List<object>();
            switch (table_List.SelectedItem as String)
            {
                case "�����������":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.Users.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
                case "���������� �������":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.Supplies.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
                case "��������� �������":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.PeripheralDevices.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
                case "������������ ��":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.Pc�omponents.ToList().ForEach(u => entities.Add(u));
                    };
                    break;              
                case "������ ����������":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.OfficeEquipments.ToList().ForEach(u => entities.Add(u));
                    };
                    break;                
                case "�������� ������������":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.NetworkDevices.ToList().ForEach(u => entities.Add(u));
                    };
                    break;                
                case "���������� ����'�����":
                    using (AccountingContext dbContext = new AccountingContext())
                    {
                        dbContext.Computers.ToList().ForEach(u => entities.Add(u));
                    };
                    break;
            }

            DB_Grid.DataSource = entities;
        }


        private void table_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!saved)
            {
                int chooseInd = table_List.SelectedIndex;

                if (table_List.SelectedIndex == prev_list_ind) return;
                
                table_List.SelectedIndex = prev_list_ind;
                DB_Grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DialogResult result = MessageBox.Show("�� ������ �������� ����! ��������?","����������",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        SaveBtn_Click(sender,e);
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
            Change_btn.Text = permissionChange ? "Change: true" : "Change: false";
            DB_Grid.ReadOnly= !permissionChange;
            DB_Grid.Columns[0].ReadOnly = true;
        }
        private List<List<object>> GetRowValues() 
        {
            List<object> row_values = new List<object>();
            List<List<object>> table_values = new List<List<object>>();

            for (int i = 0; i < DB_Grid.RowCount; i++)
            {
                for (int j = 0; j < DB_Grid.ColumnCount; j++)
                {
                    row_values.Add(DB_Grid.Rows[i].Cells[j].Value);
                }
                
                table_values.Add(new List<object>());
                table_values.Last().AddRange(row_values);
                row_values.Clear();
            }
            return table_values;
        }

        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
                List<List<object>> table_values = GetRowValues();
                using (AccountingContext dbContext = new AccountingContext())
                {
                    try
                    {
                        switch (table_List.SelectedItem as String)
                        {
                            case "�����������":
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
                            case "���������� �������":
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
                            case "��������� �������":
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
                            case "������������ ��":
                            {
                                List<Pc�omponent> entities = new List<Pc�omponent>();
                                for (int i = 0; i < table_values.Count; i++)
                                {
                                    object instance = Activator.CreateInstance(typeof(Pc�omponent), table_values[i].ToArray());
                                    entities.Add(instance as Pc�omponent);
                                }
                                dbContext.Pc�omponents.RemoveRange(dbContext.Pc�omponents.ToList());
                                dbContext.Pc�omponents.AddRange(entities);
                            }
                            break;
                            case "������ ����������":
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
                            case "�������� ������������":
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
                            case "���������� ����'�����":
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
                        MessageBox.Show("ALERT");
                    }
                };
        }

        private int GetNextId()
        {
            List<List<object>> values = GetRowValues();
            int maxInd = int.MinValue;
            foreach (var item in values)
            {
                maxInd = (int)((int)item[0] > maxInd ? item[0] : maxInd);
            }

            return maxInd + 1;
        }
        private void Add_Row_Btn_Click(object sender, EventArgs e)
        {
            int id = GetNextId();
            var new_inst = Activator.CreateInstance(type);
            type.GetProperty("Id").SetValue(new_inst,id);
            
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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                saved = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DB_Grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DialogResult result = MessageBox.Show("�� ������ �������� ���� ����� �������! ��������?", "����������", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
    }
}