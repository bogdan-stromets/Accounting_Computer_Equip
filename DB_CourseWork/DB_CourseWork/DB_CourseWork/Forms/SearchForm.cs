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

        }
    }
}
