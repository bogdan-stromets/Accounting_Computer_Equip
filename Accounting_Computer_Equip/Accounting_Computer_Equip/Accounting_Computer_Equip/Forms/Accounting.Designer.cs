using Accounting_Computer_Equip.Misc;

namespace Accounting_Computer_Equip
{
    partial class Accounting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounting));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            flowLayoutPanelMenu = new FlowLayoutPanel();
            panelLogo = new Panel();
            label_Menu = new Label();
            btn_Menu = new Button();
            btn_Home = new Button();
            panel_Tables = new Panel();
            btn_Users = new Button();
            btn_PeripheralDevices = new Button();
            btn_Components = new Button();
            btn_Supplies = new Button();
            btn_Tables = new Button();
            btn_OfficeEquip = new Button();
            btn_NetworkDevices = new Button();
            btn_Computers = new Button();
            search_panel = new Panel();
            search_btn_small = new Button();
            search_textbox = new TextBox();
            btn_Search = new Button();
            toggleSwitch_Change = new ToggleSwitch();
            btn_Save = new Button();
            btn_Add = new Button();
            btn_Remove = new Button();
            Tables_btn_timer = new System.Windows.Forms.Timer(components);
            Menu_Timer = new System.Windows.Forms.Timer(components);
            Grid_timer = new System.Windows.Forms.Timer(components);
            Search_timer = new System.Windows.Forms.Timer(components);
            logo_picture = new PictureBox();
            Hide_logo_timer = new System.Windows.Forms.Timer(components);
            btn_Close = new Button();
            Head_panel = new Panel();
            curr_table_label = new Label();
            btn_Minimize = new Button();
            addict_btn_panel = new FlowLayoutPanel();
            Grid_panel = new Panel();
            DB_Grid = new DoubleBufferedDataGridView();
            bottom_panel = new Panel();
            trigger_show_panel = new Panel();
            addict_panel_timer = new System.Windows.Forms.Timer(components);
            close_addict_panel_timer = new System.Windows.Forms.Timer(components);
            flowLayoutPanelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel_Tables.SuspendLayout();
            search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_picture).BeginInit();
            Head_panel.SuspendLayout();
            addict_btn_panel.SuspendLayout();
            Grid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DB_Grid).BeginInit();
            bottom_panel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            flowLayoutPanelMenu.BackColor = Color.FromArgb(41, 98, 72);
            flowLayoutPanelMenu.Controls.Add(panelLogo);
            flowLayoutPanelMenu.Controls.Add(btn_Home);
            flowLayoutPanelMenu.Controls.Add(panel_Tables);
            flowLayoutPanelMenu.Controls.Add(search_panel);
            flowLayoutPanelMenu.Controls.Add(toggleSwitch_Change);
            flowLayoutPanelMenu.Dock = DockStyle.Left;
            flowLayoutPanelMenu.Location = new Point(0, 0);
            flowLayoutPanelMenu.MaximumSize = new Size(199, 790);
            flowLayoutPanelMenu.MinimumSize = new Size(84, 749);
            flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            flowLayoutPanelMenu.Size = new Size(199, 790);
            flowLayoutPanelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(60, 138, 103);
            panelLogo.Controls.Add(label_Menu);
            panelLogo.Controls.Add(btn_Menu);
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 78);
            panelLogo.TabIndex = 0;
            // 
            // label_Menu
            // 
            label_Menu.AutoSize = true;
            label_Menu.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Menu.ForeColor = Color.White;
            label_Menu.Location = new Point(70, 30);
            label_Menu.Name = "label_Menu";
            label_Menu.Size = new Size(67, 18);
            label_Menu.TabIndex = 8;
            label_Menu.Text = "    Menu";
            // 
            // btn_Menu
            // 
            btn_Menu.BackgroundImage = Properties.Resources.menu;
            btn_Menu.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Menu.FlatAppearance.BorderSize = 0;
            btn_Menu.FlatStyle = FlatStyle.Flat;
            btn_Menu.ForeColor = Color.Gainsboro;
            btn_Menu.Location = new Point(18, 19);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(46, 36);
            btn_Menu.TabIndex = 7;
            btn_Menu.UseVisualStyleBackColor = true;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // btn_Home
            // 
            btn_Home.FlatAppearance.BorderSize = 0;
            btn_Home.FlatStyle = FlatStyle.Flat;
            btn_Home.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Home.ForeColor = Color.White;
            btn_Home.Image = Properties.Resources.home1;
            btn_Home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Home.Location = new Point(0, 81);
            btn_Home.Margin = new Padding(0, 3, 3, 3);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(217, 72);
            btn_Home.TabIndex = 11;
            btn_Home.Text = "    Home";
            btn_Home.TextAlign = ContentAlignment.MiddleLeft;
            btn_Home.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Home.UseVisualStyleBackColor = true;
            btn_Home.Click += btn_Home_Click;
            // 
            // panel_Tables
            // 
            panel_Tables.Controls.Add(btn_Users);
            panel_Tables.Controls.Add(btn_PeripheralDevices);
            panel_Tables.Controls.Add(btn_Components);
            panel_Tables.Controls.Add(btn_Supplies);
            panel_Tables.Controls.Add(btn_Tables);
            panel_Tables.Controls.Add(btn_OfficeEquip);
            panel_Tables.Controls.Add(btn_NetworkDevices);
            panel_Tables.Controls.Add(btn_Computers);
            panel_Tables.Location = new Point(0, 156);
            panel_Tables.Margin = new Padding(0);
            panel_Tables.MaximumSize = new Size(222, 427);
            panel_Tables.MinimumSize = new Size(222, 84);
            panel_Tables.Name = "panel_Tables";
            panel_Tables.Size = new Size(222, 84);
            panel_Tables.TabIndex = 6;
            // 
            // btn_Users
            // 
            btn_Users.FlatAppearance.BorderSize = 0;
            btn_Users.FlatStyle = FlatStyle.Flat;
            btn_Users.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Users.ForeColor = Color.White;
            btn_Users.Image = Properties.Resources.users;
            btn_Users.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Users.Location = new Point(0, 380);
            btn_Users.Name = "btn_Users";
            btn_Users.Padding = new Padding(10, 0, 0, 0);
            btn_Users.Size = new Size(217, 40);
            btn_Users.TabIndex = 8;
            btn_Users.Text = "  Users";
            btn_Users.TextAlign = ContentAlignment.MiddleLeft;
            btn_Users.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Users.UseVisualStyleBackColor = true;
            btn_Users.Click += btn_Users_Click;
            // 
            // btn_PeripheralDevices
            // 
            btn_PeripheralDevices.FlatAppearance.BorderSize = 0;
            btn_PeripheralDevices.FlatStyle = FlatStyle.Flat;
            btn_PeripheralDevices.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_PeripheralDevices.ForeColor = Color.White;
            btn_PeripheralDevices.Image = Properties.Resources.perif;
            btn_PeripheralDevices.ImageAlign = ContentAlignment.MiddleLeft;
            btn_PeripheralDevices.Location = new Point(0, 333);
            btn_PeripheralDevices.Name = "btn_PeripheralDevices";
            btn_PeripheralDevices.Padding = new Padding(10, 0, 0, 0);
            btn_PeripheralDevices.Size = new Size(217, 40);
            btn_PeripheralDevices.TabIndex = 7;
            btn_PeripheralDevices.Text = "  Peripheral Devices";
            btn_PeripheralDevices.TextAlign = ContentAlignment.MiddleLeft;
            btn_PeripheralDevices.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_PeripheralDevices.UseVisualStyleBackColor = true;
            btn_PeripheralDevices.Click += btn_PeripheralDevices_Click;
            // 
            // btn_Components
            // 
            btn_Components.FlatAppearance.BorderSize = 0;
            btn_Components.FlatStyle = FlatStyle.Flat;
            btn_Components.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Components.ForeColor = Color.White;
            btn_Components.Image = Properties.Resources.components;
            btn_Components.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Components.Location = new Point(0, 285);
            btn_Components.Name = "btn_Components";
            btn_Components.Padding = new Padding(10, 0, 0, 0);
            btn_Components.Size = new Size(217, 40);
            btn_Components.TabIndex = 6;
            btn_Components.Text = "  PC Components";
            btn_Components.TextAlign = ContentAlignment.MiddleLeft;
            btn_Components.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Components.UseVisualStyleBackColor = true;
            btn_Components.Click += btn_Components_Click;
            // 
            // btn_Supplies
            // 
            btn_Supplies.FlatAppearance.BorderSize = 0;
            btn_Supplies.FlatStyle = FlatStyle.Flat;
            btn_Supplies.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Supplies.ForeColor = Color.White;
            btn_Supplies.Image = Properties.Resources.supply;
            btn_Supplies.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Supplies.Location = new Point(0, 238);
            btn_Supplies.Name = "btn_Supplies";
            btn_Supplies.Padding = new Padding(10, 0, 0, 0);
            btn_Supplies.Size = new Size(217, 40);
            btn_Supplies.TabIndex = 5;
            btn_Supplies.Text = "  Supplies";
            btn_Supplies.TextAlign = ContentAlignment.MiddleLeft;
            btn_Supplies.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Supplies.UseVisualStyleBackColor = true;
            btn_Supplies.Click += btn_Supplies_Click;
            // 
            // btn_Tables
            // 
            btn_Tables.FlatAppearance.BorderSize = 0;
            btn_Tables.FlatStyle = FlatStyle.Flat;
            btn_Tables.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Tables.ForeColor = Color.White;
            btn_Tables.Image = Properties.Resources.tables;
            btn_Tables.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Tables.Location = new Point(0, 0);
            btn_Tables.Margin = new Padding(0);
            btn_Tables.Name = "btn_Tables";
            btn_Tables.Size = new Size(217, 91);
            btn_Tables.TabIndex = 1;
            btn_Tables.Text = "    Tables";
            btn_Tables.TextAlign = ContentAlignment.MiddleLeft;
            btn_Tables.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Tables.UseVisualStyleBackColor = true;
            btn_Tables.Click += btn_Tables_Click;
            // 
            // btn_OfficeEquip
            // 
            btn_OfficeEquip.FlatAppearance.BorderSize = 0;
            btn_OfficeEquip.FlatStyle = FlatStyle.Flat;
            btn_OfficeEquip.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_OfficeEquip.ForeColor = Color.White;
            btn_OfficeEquip.Image = Properties.Resources.office;
            btn_OfficeEquip.ImageAlign = ContentAlignment.MiddleLeft;
            btn_OfficeEquip.Location = new Point(0, 144);
            btn_OfficeEquip.Name = "btn_OfficeEquip";
            btn_OfficeEquip.Padding = new Padding(10, 0, 0, 0);
            btn_OfficeEquip.Size = new Size(217, 40);
            btn_OfficeEquip.TabIndex = 4;
            btn_OfficeEquip.Text = "  Office Equipment";
            btn_OfficeEquip.TextAlign = ContentAlignment.MiddleLeft;
            btn_OfficeEquip.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_OfficeEquip.UseVisualStyleBackColor = true;
            btn_OfficeEquip.Click += btn_OfficeEquip_Click;
            // 
            // btn_NetworkDevices
            // 
            btn_NetworkDevices.FlatAppearance.BorderSize = 0;
            btn_NetworkDevices.FlatStyle = FlatStyle.Flat;
            btn_NetworkDevices.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_NetworkDevices.ForeColor = Color.White;
            btn_NetworkDevices.Image = Properties.Resources.wifi;
            btn_NetworkDevices.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NetworkDevices.Location = new Point(0, 191);
            btn_NetworkDevices.Name = "btn_NetworkDevices";
            btn_NetworkDevices.Padding = new Padding(10, 0, 0, 0);
            btn_NetworkDevices.Size = new Size(217, 40);
            btn_NetworkDevices.TabIndex = 3;
            btn_NetworkDevices.Text = "  Network Devices";
            btn_NetworkDevices.TextAlign = ContentAlignment.MiddleLeft;
            btn_NetworkDevices.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_NetworkDevices.UseVisualStyleBackColor = true;
            btn_NetworkDevices.Click += btn_NetworkDevices_Click;
            // 
            // btn_Computers
            // 
            btn_Computers.FlatAppearance.BorderSize = 0;
            btn_Computers.FlatStyle = FlatStyle.Flat;
            btn_Computers.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Computers.ForeColor = Color.White;
            btn_Computers.Image = Properties.Resources.pc;
            btn_Computers.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Computers.Location = new Point(0, 97);
            btn_Computers.Name = "btn_Computers";
            btn_Computers.Padding = new Padding(10, 0, 0, 0);
            btn_Computers.Size = new Size(217, 40);
            btn_Computers.TabIndex = 2;
            btn_Computers.Text = "  Computers";
            btn_Computers.TextAlign = ContentAlignment.MiddleLeft;
            btn_Computers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Computers.UseVisualStyleBackColor = true;
            btn_Computers.Click += btn_Computers_Click;
            // 
            // search_panel
            // 
            search_panel.Controls.Add(search_btn_small);
            search_panel.Controls.Add(search_textbox);
            search_panel.Controls.Add(btn_Search);
            search_panel.Location = new Point(0, 240);
            search_panel.Margin = new Padding(0);
            search_panel.MaximumSize = new Size(223, 111);
            search_panel.MinimumSize = new Size(223, 80);
            search_panel.Name = "search_panel";
            search_panel.Size = new Size(223, 80);
            search_panel.TabIndex = 8;
            // 
            // search_btn_small
            // 
            search_btn_small.FlatAppearance.BorderSize = 0;
            search_btn_small.FlatStyle = FlatStyle.Flat;
            search_btn_small.ForeColor = Color.Gainsboro;
            search_btn_small.Image = Properties.Resources.small_search;
            search_btn_small.ImageAlign = ContentAlignment.TopCenter;
            search_btn_small.Location = new Point(167, 83);
            search_btn_small.Margin = new Padding(0, 3, 3, 3);
            search_btn_small.Name = "search_btn_small";
            search_btn_small.Size = new Size(23, 24);
            search_btn_small.TabIndex = 3;
            search_btn_small.Text = "    Search";
            search_btn_small.TextAlign = ContentAlignment.MiddleLeft;
            search_btn_small.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_btn_small.UseVisualStyleBackColor = true;
            search_btn_small.Click += search_btn_small_Click;
            // 
            // search_textbox
            // 
            search_textbox.BackColor = Color.FromArgb(50, 52, 77);
            search_textbox.BorderStyle = BorderStyle.FixedSingle;
            search_textbox.ForeColor = Color.Gainsboro;
            search_textbox.Location = new Point(4, 83);
            search_textbox.Name = "search_textbox";
            search_textbox.Size = new Size(160, 23);
            search_textbox.TabIndex = 4;
            search_textbox.Text = "Search";
            // 
            // btn_Search
            // 
            btn_Search.FlatAppearance.BorderSize = 0;
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Search.ForeColor = Color.White;
            btn_Search.Image = Properties.Resources.search;
            btn_Search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Search.Location = new Point(0, 8);
            btn_Search.Margin = new Padding(0);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(216, 72);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "    Search";
            btn_Search.TextAlign = ContentAlignment.MiddleLeft;
            btn_Search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // toggleSwitch_Change
            // 
            toggleSwitch_Change.BackColor = Color.White;
            toggleSwitch_Change.BackColorOFF = Color.FromArgb(181, 224, 196);
            toggleSwitch_Change.BackColorON = Color.FromArgb(81, 182, 135);
            toggleSwitch_Change.Checked = false;
            toggleSwitch_Change.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toggleSwitch_Change.ForeColor = Color.White;
            toggleSwitch_Change.Location = new Point(2, 331);
            toggleSwitch_Change.Margin = new Padding(2, 11, 3, 3);
            toggleSwitch_Change.Name = "toggleSwitch_Change";
            toggleSwitch_Change.Size = new Size(190, 53);
            toggleSwitch_Change.TabIndex = 9;
            toggleSwitch_Change.Text = "Change OFF";
            toggleSwitch_Change.TextOnChecked = "";
            toggleSwitch_Change.ToogleSwitchHeight = 50;
            toggleSwitch_Change.ToogleSwitchWidth = 80;
            toggleSwitch_Change.MouseDown += toggleSwitch_Change_MouseDown;
            // 
            // btn_Save
            // 
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Image = Properties.Resources.save;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(156, 0);
            btn_Save.Margin = new Padding(0);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(74, 72);
            btn_Save.TabIndex = 7;
            btn_Save.TextAlign = ContentAlignment.MiddleLeft;
            btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            btn_Save.MouseEnter += bottom_panel_MouseEnter;
            btn_Save.MouseLeave += bottom_panel_MouseLeave;
            // 
            // btn_Add
            // 
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.ForeColor = Color.White;
            btn_Add.Image = Properties.Resources.plus;
            btn_Add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add.Location = new Point(0, 0);
            btn_Add.Margin = new Padding(0);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(78, 72);
            btn_Add.TabIndex = 9;
            btn_Add.TextAlign = ContentAlignment.MiddleLeft;
            btn_Add.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            btn_Add.MouseEnter += bottom_panel_MouseEnter;
            btn_Add.MouseLeave += bottom_panel_MouseLeave;
            // 
            // btn_Remove
            // 
            btn_Remove.FlatAppearance.BorderSize = 0;
            btn_Remove.FlatStyle = FlatStyle.Flat;
            btn_Remove.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Remove.ForeColor = Color.White;
            btn_Remove.Image = Properties.Resources.minus;
            btn_Remove.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Remove.Location = new Point(78, 0);
            btn_Remove.Margin = new Padding(0);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(78, 72);
            btn_Remove.TabIndex = 10;
            btn_Remove.TextAlign = ContentAlignment.MiddleLeft;
            btn_Remove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            btn_Remove.MouseEnter += bottom_panel_MouseEnter;
            btn_Remove.MouseLeave += bottom_panel_MouseLeave;
            // 
            // Tables_btn_timer
            // 
            Tables_btn_timer.Interval = 1;
            Tables_btn_timer.Tick += Tables_btn_timer_Tick;
            // 
            // Menu_Timer
            // 
            Menu_Timer.Interval = 1;
            Menu_Timer.Tick += Menu_Timer_Tick;
            // 
            // Grid_timer
            // 
            Grid_timer.Interval = 1;
            Grid_timer.Tick += Grid_timer_Tick;
            // 
            // Search_timer
            // 
            Search_timer.Interval = 1;
            Search_timer.Tick += Search_timer_Tick;
            // 
            // logo_picture
            // 
            logo_picture.BackColor = Color.FromArgb(213, 240, 217);
            logo_picture.BackgroundImage = (Image)resources.GetObject("logo_picture.BackgroundImage");
            logo_picture.BackgroundImageLayout = ImageLayout.Zoom;
            logo_picture.Location = new Point(223, 118);
            logo_picture.MaximumSize = new Size(971, 580);
            logo_picture.Name = "logo_picture";
            logo_picture.Size = new Size(971, 580);
            logo_picture.TabIndex = 8;
            logo_picture.TabStop = false;
            // 
            // Hide_logo_timer
            // 
            Hide_logo_timer.Interval = 1;
            Hide_logo_timer.Tick += Hide_logo_timer_Tick;
            // 
            // btn_Close
            // 
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Close.ForeColor = Color.White;
            btn_Close.Location = new Point(1237, 3);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(30, 31);
            btn_Close.TabIndex = 9;
            btn_Close.Text = "O";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // Head_panel
            // 
            Head_panel.BackColor = Color.FromArgb(146, 209, 174);
            Head_panel.Controls.Add(curr_table_label);
            Head_panel.Controls.Add(btn_Minimize);
            Head_panel.Controls.Add(btn_Close);
            Head_panel.Location = new Point(84, 0);
            Head_panel.Name = "Head_panel";
            Head_panel.Size = new Size(1270, 78);
            Head_panel.TabIndex = 10;
            Head_panel.MouseDown += Head_panel_MouseDown;
            // 
            // curr_table_label
            // 
            curr_table_label.Anchor = AnchorStyles.None;
            curr_table_label.AutoSize = true;
            curr_table_label.FlatStyle = FlatStyle.Flat;
            curr_table_label.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            curr_table_label.ForeColor = Color.White;
            curr_table_label.Location = new Point(587, 19);
            curr_table_label.Name = "curr_table_label";
            curr_table_label.Size = new Size(117, 40);
            curr_table_label.TabIndex = 11;
            curr_table_label.Text = "Home";
            curr_table_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_Minimize
            // 
            btn_Minimize.FlatAppearance.BorderSize = 0;
            btn_Minimize.FlatStyle = FlatStyle.Flat;
            btn_Minimize.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Minimize.ForeColor = Color.White;
            btn_Minimize.Location = new Point(1201, 3);
            btn_Minimize.Name = "btn_Minimize";
            btn_Minimize.Size = new Size(30, 31);
            btn_Minimize.TabIndex = 10;
            btn_Minimize.Text = "O";
            btn_Minimize.UseVisualStyleBackColor = true;
            btn_Minimize.Click += btn_Minimize_Click;
            // 
            // addict_btn_panel
            // 
            addict_btn_panel.AutoSize = true;
            addict_btn_panel.Controls.Add(btn_Add);
            addict_btn_panel.Controls.Add(btn_Remove);
            addict_btn_panel.Controls.Add(btn_Save);
            addict_btn_panel.Location = new Point(1037, 0);
            addict_btn_panel.Margin = new Padding(0);
            addict_btn_panel.Name = "addict_btn_panel";
            addict_btn_panel.Size = new Size(282, 91);
            addict_btn_panel.TabIndex = 0;
            addict_btn_panel.MouseEnter += bottom_panel_MouseEnter;
            addict_btn_panel.MouseLeave += bottom_panel_MouseLeave;
            // 
            // Grid_panel
            // 
            Grid_panel.Anchor = AnchorStyles.Right;
            Grid_panel.Controls.Add(DB_Grid);
            Grid_panel.Location = new Point(1360, 100);
            Grid_panel.MaximumSize = new Size(1236, 655);
            Grid_panel.MinimumSize = new Size(1121, 655);
            Grid_panel.Name = "Grid_panel";
            Grid_panel.Size = new Size(1236, 655);
            Grid_panel.TabIndex = 7;
            // 
            // DB_Grid
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(232, 247, 234);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(81, 182, 135);
            DB_Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            DB_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DB_Grid.BackgroundColor = Color.FromArgb(232, 247, 234);
            DB_Grid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            DB_Grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(232, 247, 234);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(81, 182, 135);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DB_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DB_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(232, 247, 234);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(81, 182, 135);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            DB_Grid.DefaultCellStyle = dataGridViewCellStyle8;
            DB_Grid.Dock = DockStyle.Fill;
            DB_Grid.EnableHeadersVisualStyles = false;
            DB_Grid.GridColor = Color.Black;
            DB_Grid.Location = new Point(0, 0);
            DB_Grid.Name = "DB_Grid";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(232, 247, 234);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(81, 182, 135);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DB_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(181, 224, 196);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(81, 182, 135);
            DB_Grid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            DB_Grid.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(181, 224, 196);
            DB_Grid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(81, 182, 135);
            DB_Grid.RowTemplate.Height = 25;
            DB_Grid.Size = new Size(1236, 655);
            DB_Grid.TabIndex = 6;
            DB_Grid.CellValueChanged += DB_Grid_CellValueChanged;
            DB_Grid.EditingControlShowing += DB_Grid_EditingControlShowing;
            // 
            // bottom_panel
            // 
            bottom_panel.BackColor = Color.FromArgb(146, 209, 174);
            bottom_panel.Controls.Add(addict_btn_panel);
            bottom_panel.Location = new Point(84, 790);
            bottom_panel.Margin = new Padding(0);
            bottom_panel.MaximumSize = new Size(1270, 72);
            bottom_panel.MinimumSize = new Size(1270, 0);
            bottom_panel.Name = "bottom_panel";
            bottom_panel.Size = new Size(1270, 72);
            bottom_panel.TabIndex = 11;
            bottom_panel.MouseEnter += bottom_panel_MouseEnter;
            bottom_panel.MouseLeave += bottom_panel_MouseLeave;
            // 
            // trigger_show_panel
            // 
            trigger_show_panel.BackColor = Color.Transparent;
            trigger_show_panel.BackgroundImage = Properties.Resources.arrow;
            trigger_show_panel.BackgroundImageLayout = ImageLayout.Zoom;
            trigger_show_panel.Location = new Point(84, 766);
            trigger_show_panel.Name = "trigger_show_panel";
            trigger_show_panel.Size = new Size(1270, 24);
            trigger_show_panel.TabIndex = 12;
            trigger_show_panel.MouseHover += trigger_show_panel_MouseHover;
            // 
            // addict_panel_timer
            // 
            addict_panel_timer.Interval = 1;
            addict_panel_timer.Tick += addict_panel_timer_Tick;
            // 
            // close_addict_panel_timer
            // 
            close_addict_panel_timer.Tick += close_addict_panel_timer_Tick;
            // 
            // Accounting
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 240, 217);
            ClientSize = new Size(1354, 790);
            Controls.Add(flowLayoutPanelMenu);
            Controls.Add(logo_picture);
            Controls.Add(Head_panel);
            Controls.Add(bottom_panel);
            Controls.Add(Grid_panel);
            Controls.Add(trigger_show_panel);
            Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1354, 790);
            MinimumSize = new Size(895, 556);
            Name = "Accounting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accounting";
            FormClosing += Accounting_FormClosing;
            Load += Accounting_Load;
            flowLayoutPanelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel_Tables.ResumeLayout(false);
            search_panel.ResumeLayout(false);
            search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_picture).EndInit();
            Head_panel.ResumeLayout(false);
            Head_panel.PerformLayout();
            addict_btn_panel.ResumeLayout(false);
            Grid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DB_Grid).EndInit();
            bottom_panel.ResumeLayout(false);
            bottom_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelMenu;
        private Panel panelLogo;
        private Button btn_Tables;
        private Button btn_Search;
        private Panel panel_Tables;
        private Button btn_Users;
        private Button btn_PeripheralDevices;
        private Button btn_Components;
        private Button btn_Supplies;
        private Button btn_OfficeEquip;
        private Button btn_NetworkDevices;
        private Button btn_Computers;
        private System.Windows.Forms.Timer Tables_btn_timer;
        private Button btn_Save;
        private Button btn_Add;
        private Button btn_Remove;
        private Button btn_Menu;
        private Label label_Menu;
        private System.Windows.Forms.Timer Menu_Timer;
        private System.Windows.Forms.Timer Grid_timer;
        private Panel search_panel;
        private TextBox search_textbox;
        private Button search_btn_small;
        private System.Windows.Forms.Timer Search_timer;
        private PictureBox logo_picture;
        private System.Windows.Forms.Timer Hide_logo_timer;
        private Button btn_Home;
        private ToggleSwitch toggleSwitch_Change;
        private Button btn_Close;
        private Panel Head_panel;
        private Button btn_Minimize;
        private Label curr_table_label;
        private Panel Grid_panel;
        internal DoubleBufferedDataGridView DB_Grid;
        private Panel bottom_panel;
        private FlowLayoutPanel addict_btn_panel;
        private System.Windows.Forms.Timer addict_panel_timer;
        private Panel trigger_show_panel;
        private System.Windows.Forms.Timer close_addict_panel_timer;
    }
}