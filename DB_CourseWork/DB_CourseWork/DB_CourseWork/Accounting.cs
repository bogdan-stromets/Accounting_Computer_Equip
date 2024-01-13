﻿using DB_CourseWork.Models;
using DB_CourseWork.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using System.CodeDom;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_CourseWork
{

    public partial class Accounting : Form
    {
        bool is_anim_menu, is_anim_table, is_anim_search;
        bool tables_expand = true;
        int tables_curr_time, menu_curr_time, search_curr_time = 0;
        bool menu_expand = true;
        bool grid_expand = true;
        bool search_expand = true;
        private bool permissionChange = false;
        private bool saved = true;
        private List<object> entities = new List<object>();
        private Type? type;
        private string current_table = "";




        public Accounting()
        {
            InitializeComponent();
            InitForm();
        }

        private void Tables_btn_timer_Tick(object sender, EventArgs e)
        {
            tables_curr_time++;
            if (tables_expand)
            {
                Ease ease = new Ease(tables_curr_time, panel_Tables.Height, 10, 100, EaseType.ExpOut);
                panel_Tables.Height = (int)ease.GetValue;

                if (panel_Tables.Height == panel_Tables.MaximumSize.Height)
                {
                    tables_expand = false;
                    Tables_btn_timer.Stop();
                    is_anim_table = false;
                }
            }
            else
            {
                Ease ease = new Ease(tables_curr_time, panel_Tables.Height, -10, 100, EaseType.ExpOut);
                panel_Tables.Height = (int)ease.GetValue;
                if (panel_Tables.Height == panel_Tables.MinimumSize.Height)
                {
                    tables_expand = true;
                    Tables_btn_timer.Stop();
                    is_anim_table = false;
                }
            }
        }

        private void btn_Tables_Click(object sender, EventArgs e)
        {
            if (is_anim_table) return;

            is_anim_table = true;
            if (flowLayoutPanelMenu.Width < flowLayoutPanelMenu.MaximumSize.Width)
                btn_Menu_Click(sender, e);
            Tables_btn_timer.Start();
            tables_curr_time = 1;
        }
        private bool Is_Table_Picked()
        {
            if (current_table == String.Empty)
            {
                MessageBox.Show("Таблиця не обрана!");
                return true;
            }
            return false;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (Is_Table_Picked()) return;
            if (is_anim_search) return;

            is_anim_search = true;
            if (flowLayoutPanelMenu.Width < flowLayoutPanelMenu.MaximumSize.Width)
                btn_Menu_Click(sender, e);
            Search_timer.Start();
            search_curr_time = 1;
        }

        private void InitForm()
        {
            DB_Controller.mainForm = this;

            DB_Grid.AutoGenerateColumns = true;
            DB_Grid.ReadOnly = true;
            DoubleBuffered = true;
            //table_List.Items.AddRange(DB_Controller.Table.Keys.ToArray());
            // table_List.SelectedIndex = 0;

            System.Windows.Forms.ToolTip tip = new System.Windows.Forms.ToolTip();
            tip.SetToolTip(btn_Change, "Changing\r\n(off/on)");
            tip.SetToolTip(btn_Add, "Add row or rows");
            tip.SetToolTip(btn_Remove, "Delete row or rows");
            tip.SetToolTip(btn_Save, "Save changes");
            tip.SetToolTip(btn_Tables, "Tables");
            tip.SetToolTip(btn_Menu, "Menu");
            tip.SetToolTip(btn_Search, "Search");
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
        private void SetTextStyle()
        {
            type = DB_Controller.Table[current_table];
            DB_Grid.DataSource = entities;
            foreach (DataGridViewColumn column in DB_Grid.Columns)
                column.DefaultCellStyle.Font = new Font("Consolas", 11, FontStyle.Regular);
        }
        private void CheckSave(object sender, EventArgs e)
        {
            if (!saved)
            {
                DialogResult result = MessageBox.Show("Ви забули зберегти зміни! Зберегти?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        btn_Save_Click(sender, e);
                        break;
                    default:
                        saved = true;
                        break;
                }
            }
            // prev_list_ind = table_List.SelectedIndex;
        }
        #region Tables data
        private void btn_Computers_Click(object sender, EventArgs e)
        {
            entities = new List<object>();
            using (AccountingContext dbContext = new AccountingContext())
            {
                dbContext.Computers.ToList().ForEach(u => entities.Add(u));
            };
            current_table = "Персональні комп'ютери";
            SetTextStyle();
            CheckSave(sender, e);
        }

        private void btn_OfficeEquip_Click(object sender, EventArgs e)
        {
            entities = new List<object>();
            using (AccountingContext dbContext = new AccountingContext())
            {
                dbContext.OfficeEquipments.ToList().ForEach(u => entities.Add(u));
            };
            current_table = "Офісне обладнання";
            SetTextStyle();
            CheckSave(sender, e);
        }

        private void btn_NetworkDevices_Click(object sender, EventArgs e)
        {
            entities = new List<object>();
            using (AccountingContext dbContext = new AccountingContext())
            {
                dbContext.NetworkDevices.ToList().ForEach(u => entities.Add(u));
            };
            current_table = "Мережеве устаткування";
            SetTextStyle();
            CheckSave(sender, e);
        }

        private void btn_Supplies_Click(object sender, EventArgs e)
        {
            entities = new List<object>();
            using (AccountingContext dbContext = new AccountingContext())
            {
                dbContext.Supplies.ToList().ForEach(u => entities.Add(u));
            };
            current_table = "Видатковий матеріал";
            SetTextStyle();
            CheckSave(sender, e);
        }

        private void btn_Components_Click(object sender, EventArgs e)
        {
            entities = new List<object>();
            using (AccountingContext dbContext = new AccountingContext())
            {
                dbContext.PcСomponents.ToList().ForEach(u => entities.Add(u));
            };
            current_table = "Комплектуючі ПК";
            SetTextStyle();
            CheckSave(sender, e);
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            entities = new List<object>();
            using (AccountingContext dbContext = new AccountingContext())
            {
                dbContext.Users.ToList().ForEach(u => entities.Add(u));
            };
            current_table = "Користувачі";
            SetTextStyle();
            CheckSave(sender, e);
        }
        private void btn_PeripheralDevices_Click(object sender, EventArgs e)
        {
            entities = new List<object>();
            using (AccountingContext dbContext = new AccountingContext())
            {
                dbContext.PeripheralDevices.ToList().ForEach(u => entities.Add(u));
            };
            current_table = "Периферійні пристрої";
            SetTextStyle();
            CheckSave(sender, e);
        }
        #endregion

        private void btn_Save_Click(object sender, EventArgs e)
        {
            List<List<object>> table_values = DB_Controller.GetRowValues();
            using (AccountingContext dbContext = new AccountingContext())
            {
                try
                {
                    switch (current_table)
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

        private void Accounting_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckSave(sender, e);
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Is_Table_Picked()) return;
            int id = DB_Controller.GetNextId();
            var new_inst = Activator.CreateInstance(type);
            type.GetProperty("Id").SetValue(new_inst, id);

            entities.Add(new_inst);

            DB_Grid.DataSource = null;
            DB_Grid.DataSource = entities;
            DB_Grid.Refresh();
            saved = false;
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (Is_Table_Picked()) return;
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
        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (Is_Table_Picked()) return;
            permissionChange = !permissionChange;
            Text = permissionChange ? "Редагування: Увімкнено" : "Редагування: Вимкнено";
            //Change_btn.BackgroundImage = permissionChange ? Resources.on : Resources.off;
            DB_Grid.ReadOnly = !permissionChange;
            DB_Grid.Columns[0].ReadOnly = true;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (is_anim_menu) return;

            is_anim_menu = true;
            Menu_Timer.Start();
            Grid_timer.Start();
            menu_curr_time = 0;
            if (panel_Tables.Height > panel_Tables.MinimumSize.Height)
                Tables_btn_timer.Start();
            if (search_panel.Height > search_panel.MinimumSize.Height)
                Search_timer.Start();

        }

        private void Menu_Timer_Tick(object sender, EventArgs e)
        {
            menu_curr_time++;
            if (menu_expand)
            {
                Ease ease = new Ease(menu_curr_time, flowLayoutPanelMenu.Width, 10, 100, EaseType.CubicOut);
                flowLayoutPanelMenu.Width = (int)ease.GetValue;
                if (flowLayoutPanelMenu.Width == flowLayoutPanelMenu.MaximumSize.Width)
                {
                    menu_expand = false;
                    Menu_Timer.Stop();
                    is_anim_menu = false;
                }
            }
            else
            {
                Ease ease = new Ease(menu_curr_time, flowLayoutPanelMenu.Width, -10, 100, EaseType.CubicOut);
                flowLayoutPanelMenu.Width = (int)ease.GetValue;
                if (flowLayoutPanelMenu.Width == flowLayoutPanelMenu.MinimumSize.Width)
                {
                    menu_expand = true;
                    Menu_Timer.Stop();
                    is_anim_menu = false;
                }
            }
        }

        private void Grid_timer_Tick(object sender, EventArgs e)
        {
            if (!grid_expand)
            {
                bool width_done = false, location_done = false;
                if (Grid_panel.Width < Grid_panel.MaximumSize.Width)
                {
                    Ease ease = new Ease(menu_curr_time, Grid_panel.Width, 35, 100, EaseType.Linear);
                    Grid_panel.Width = (int)ease.GetValue;
                }
                else width_done = true;

                if (Grid_panel.Location.X > 90)
                {
                    Ease ease = new Ease(menu_curr_time, Grid_panel.Location.X, -28, 100, EaseType.Linear);
                    Grid_panel.Location = ease.GetValue < 90 ? new Point(90, Grid_panel.Location.Y) : new Point((int)ease.GetValue, Grid_panel.Location.Y);
                }
                else location_done = true;

                if (width_done && location_done)
                {
                    Grid_timer.Stop();
                    grid_expand = true;
                }
            }
            else
            {
                bool width_done = false, location_done = false;
                if (Grid_panel.Width > Grid_panel.MinimumSize.Width)
                {
                    Ease ease = new Ease(menu_curr_time, Grid_panel.Width, -21, 100, EaseType.Linear);
                    Grid_panel.Width = (int)ease.GetValue;
                }
                else width_done = true;

                if (Grid_panel.Location.X < 205)
                {
                    Ease ease = new Ease(menu_curr_time, Grid_panel.Location.X, 28, 100, EaseType.Linear);
                    Grid_panel.Location = ease.GetValue > 205 ? new Point(205, Grid_panel.Location.Y) : new Point((int)ease.GetValue, Grid_panel.Location.Y);
                }
                else location_done = true;

                if (width_done && location_done)
                {
                    Grid_timer.Stop();
                    grid_expand = false;
                }
            }
        }

        private void search_textbox_Click(object sender, EventArgs e)
        {
            search_textbox.Clear();
        }

        private void Search_timer_Tick(object sender, EventArgs e)
        {
            search_curr_time++;
            if (search_expand)
            {
                Ease ease = new Ease(search_curr_time, search_panel.Height, 10, 1000, EaseType.ExpOut);
                search_panel.Height = (int)ease.GetValue;

                if (search_panel.Height == search_panel.MaximumSize.Height)
                {
                    search_expand = false;
                    Search_timer.Stop();
                    is_anim_search = false;
                }
            }
            else
            {
                Ease ease = new Ease(search_curr_time, search_panel.Height, -10, 1000, EaseType.ExpOut);
                search_panel.Height = (int)ease.GetValue;
                if (search_panel.Height == search_panel.MinimumSize.Height)
                {
                    search_expand = true;
                    Search_timer.Stop();
                    is_anim_search = false;
                }
            }
        }

        private void search_btn_small_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();

            searchForm.StartPosition = FormStartPosition.CenterParent;
            using (var dbContext = new AccountingContext())
            {
                searchForm.nameTable = dbContext.Model.FindEntityType(DB_Controller.Table[current_table]).GetTableName();
                searchForm.table = dbContext.Model.FindEntityType(DB_Controller.Table[current_table]);
            };
            searchForm.ShowDialog();
        }
    }
}
