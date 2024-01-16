using Accounting_Computer_Equip.Models;
using Accounting_Computer_Equip.Properties;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Computer_Equip.Forms
{
    public partial class AddictFunc : Form
    {
        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        public List<object> Entities { get; set; }
        public string? Table_name { get; set; }
        delegate void Invoke_Method();
        Invoke_Method? method;
        public AddictFunc()
        {
            InitializeComponent();
        }
        private void ReLocateElement(Control parent, Control child)
        {
            Point child_curr_pos = child.Location;
            child.Location = new Point(parent.Width / 2 - child.Width / 2, child_curr_pos.Y);
        }
        private void HeaderTextChange()
        {
            string text = Table_name switch
            {
                "Персональні комп'ютери" => "Computers",
                "Офісне обладнання" => "Office Equipment",
                "Мережеве устаткування" => "Network Devices",
                "Видатковий матеріал" => "Supplies",
                "Комплектуючі ПК" => "PC Components",
                "Користувачі" => "Users",
                "Периферійні пристрої" => "Peripheral Devices",
                _ => "Home"
            };
            label1.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Text = text;
            ReLocateElement(head_panel, label1);
        }
        private void Head_panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AddictFunc_Load(object sender, EventArgs e)
        {
            head_panel.MouseDown += Head_panel_MouseDown;
            HeaderTextChange();
            GetMethod();
        }
        void ComputersInfo()
        {
            double count_pc = Entities.Count;
            double not_work_cnt = 0;
            double not_busy = 0;
            List<string> pc_types = new List<string>();
            foreach (Computer obj in Entities)
            {
                pc_types.Add(obj.PcType);
                if (!obj.IsWorking) not_work_cnt++;
                if (obj.UserId == null) not_busy++;
            }
            string most_type = pc_types.GroupBy(x => x)
                    .OrderByDescending(g => g.Count())
                     .ThenBy(g => g.Key, StringComparer.Ordinal)
                     .First().Key;


            string result_work = ((not_work_cnt / count_pc) * 100).ToString();
            result_work = result_work.Length >= 5 ? result_work.Substring(0, 5) : result_work;
            string result_busy = ((not_busy / count_pc) * 100).ToString();
            result_busy = result_busy.Length >= 5 ? result_busy.Substring(0, 5) : result_busy;
            AddLabel("work_label", "Non-working computers: " + result_work + "%");
            AddLabel("busy_label", "Not busy computers: " + result_busy + "%");
            AddLabel("most_type_label", "The most common type of: " + most_type);
        }
        void OfficeInfo()
        {
            double count_device = Entities.Count;
            double not_work_cnt = 0;
            List<string> device_types = new List<string>();
            foreach (OfficeEquipment obj in Entities)
            {
                device_types.Add(obj.TypeOf);
                if (!obj.IsWorking) not_work_cnt++;
            }
            string most_type = device_types.GroupBy(x => x)
                    .OrderByDescending(g => g.Count())
                     .ThenBy(g => g.Key, StringComparer.Ordinal)
                     .First().Key;
            var perc = ((not_work_cnt / count_device) * 100);
            string result_work = perc.ToString().Length >= 5 ? perc.ToString().Substring(0, 5) : perc.ToString().Substring(0, perc.ToString().Length);
            AddLabel("work_label", "Non-working devices: " + result_work + "%");
            AddLabel("most_type_label", "The most common type of: " + most_type);
        }
        void NetworkDevicesInfo()
        {
            double count_device = Entities.Count;
            double not_work_cnt = 0;
            List<string> device_types = new List<string>();
            foreach (NetworkDevice obj in Entities)
            {
                device_types.Add(obj.TypeOf);
                if (!obj.IsWorking) not_work_cnt++;
            }
            string most_type = device_types.GroupBy(x => x)
                    .OrderByDescending(g => g.Count())
                     .ThenBy(g => g.Key, StringComparer.Ordinal)
                     .First().Key;
            var perc = ((not_work_cnt / count_device) * 100);
            string result_work = perc.ToString().Length >= 5 ? perc.ToString().Substring(0, 5) : perc.ToString().Substring(0, perc.ToString().Length);
            AddLabel("work_label", "Non-working devices: " + result_work + "%");
            AddLabel("most_type_label", "The most common type of: " + most_type);
        }
        void PCComponentsInfo()
        {
            double count_device = Entities.Count;
            double not_work_cnt = 0;
            double not_connected_cnt = 0;
            List<string> device_types = new List<string>();
            foreach (PcСomponent obj in Entities)
            {
                device_types.Add(obj.TypeOf);
                if (!obj.IsWorking) not_work_cnt++;
                if (obj.ComputerId == null) not_connected_cnt++;
            }
            string most_type = device_types.GroupBy(x => x)
                    .OrderByDescending(g => g.Count())
                     .ThenBy(g => g.Key, StringComparer.Ordinal)
                     .First().Key;
            var perc = ((not_work_cnt / count_device) * 100);
            string result_work = perc.ToString().Length >= 5 ? perc.ToString().Substring(0, 5) : perc.ToString().Substring(0, perc.ToString().Length);
            string result_connect = ((not_connected_cnt / count_device) * 100).ToString();
            result_connect = result_connect.Length >= 5 ? result_connect.Substring(0, 5) : result_connect;
            AddLabel("work_label", "Non-working component: " + result_work + "%");
            AddLabel("connect_label", "Non-connected component: " + result_connect + "%");
            AddLabel("most_type_label", "The most common type of: " + most_type);
        }
        void PeripheralDeviceInfo()
        {
            double count_device = Entities.Count;
            double not_work_cnt = 0;
            double not_connected_cnt = 0;
            List<string> device_types = new List<string>();
            foreach (PeripheralDevice obj in Entities)
            {
                device_types.Add(obj.TypeOf);
                if (!obj.IsWorking) not_work_cnt++;
                if (obj.ConnectedTo == null) not_connected_cnt++;
            }
            string most_type = device_types.GroupBy(x => x)
                    .OrderByDescending(g => g.Count())
                     .ThenBy(g => g.Key, StringComparer.Ordinal)
                     .First().Key;
            var perc = ((not_work_cnt / count_device) * 100);
            string result_work = perc.ToString().Length >= 5 ? perc.ToString().Substring(0, 5) : perc.ToString().Substring(0, perc.ToString().Length);
            string result_connect = ((not_connected_cnt / count_device) * 100).ToString();
            result_connect = result_connect.Length >= 5 ? result_connect.Substring(0, 5) : result_connect;
            AddLabel("work_label", "Non-working component: " + result_work + "%");
            AddLabel("connect_label", "Non-connected component: " + result_connect + "%");
            AddLabel("most_type_label", "The most common type of: " + most_type);
        }
        void UserInfo()
        {
            double count_user = Entities.Count;
            Dictionary<string, int> user_pos = new Dictionary<string, int>();
            List<string> depart = new List<string>();
            foreach (User obj in Entities)
            {
               var collection = user_pos.Keys.Where(x => x == obj.Department);
                if (collection.Any())
                {
                    user_pos[obj.Department]++;
                    continue;
                } 
                user_pos[obj.Department] = 1;
                depart.Add(obj.Department);
            }

            for (int i = 0; i < depart.Count; i++)
            {
                string result = (user_pos[depart[i]] / count_user * 100).ToString();
                result = result.Length >= 5 ? result.Substring(0, 5) : result;
                AddLabel($"label_depart_{i}", depart[i] + ": " + result + "%");
            }
        }
        private void AddLabel(string name, string text)
        {
            label_panel.Controls.Add(new System.Windows.Forms.Label
            {
                AutoSize = true,
                Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor = Color.White,
                Location = new Point(3, 30),
                Margin = new Padding(3, 30, 3, 0),
                Name = name,
                //Size = new Size(298, 43),
                TabIndex = 0,
                Text = text
            });
            RelocatePanelLabel();
        }
        private void RelocatePanelLabel()
        {
            label_panel.Location = new Point
                (
                    this.Width / 2 - label_panel.Width / 2,
                    this.Height / 2 - label_panel.Height / 2
                );
        }
        private void GetMethod()
        {
            switch (Table_name)
            {
                case "Користувачі":
                    method = UserInfo;
                    break;
                case "Видатковий матеріал":
                    
                    break;
                case "Периферійні пристрої":
                    method = PeripheralDeviceInfo;
                    break;
                case "Комплектуючі ПК":
                    method = PCComponentsInfo;
                    break;
                case "Офісне обладнання":
                    method = OfficeInfo;
                    break;
                case "Мережеве устаткування":
                    method = NetworkDevicesInfo;
                    break;
                case "Персональні комп'ютери":
                    method = ComputersInfo;
                    break;
                default: return;
            }
            method?.Invoke();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
