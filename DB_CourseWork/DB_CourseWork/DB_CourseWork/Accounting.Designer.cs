namespace DB_CourseWork
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
            flowLayoutPanelMenu = new FlowLayoutPanel();
            panelLogo = new Panel();
            label_Menu = new Label();
            btn_Menu = new Button();
            panel_Tables = new Panel();
            btn_Users = new Button();
            btn_PeripheralDevices = new Button();
            btn_Components = new Button();
            btn_Supplies = new Button();
            btn_OfficeEquip = new Button();
            btn_NetworkDevices = new Button();
            btn_Tables = new Button();
            btn_Computers = new Button();
            btn_Search = new Button();
            btn_Save = new Button();
            btn_Change = new Button();
            btn_Add = new Button();
            btn_Remove = new Button();
            Tables_btn_timer = new System.Windows.Forms.Timer(components);
            DB_Grid = new DataGridView();
            Menu_Timer = new System.Windows.Forms.Timer(components);
            flowLayoutPanelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel_Tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DB_Grid).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            flowLayoutPanelMenu.BackColor = Color.FromArgb(50, 52, 77);
            flowLayoutPanelMenu.Controls.Add(panelLogo);
            flowLayoutPanelMenu.Controls.Add(panel_Tables);
            flowLayoutPanelMenu.Controls.Add(btn_Search);
            flowLayoutPanelMenu.Controls.Add(btn_Save);
            flowLayoutPanelMenu.Controls.Add(btn_Change);
            flowLayoutPanelMenu.Controls.Add(btn_Add);
            flowLayoutPanelMenu.Controls.Add(btn_Remove);
            flowLayoutPanelMenu.Dock = DockStyle.Left;
            flowLayoutPanelMenu.Location = new Point(0, 0);
            flowLayoutPanelMenu.MaximumSize = new Size(220, 702);
            flowLayoutPanelMenu.MinimumSize = new Size(84, 702);
            flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            flowLayoutPanelMenu.Size = new Size(84, 702);
            flowLayoutPanelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DarkSlateGray;
            panelLogo.Controls.Add(label_Menu);
            panelLogo.Controls.Add(btn_Menu);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(217, 73);
            panelLogo.TabIndex = 0;
            // 
            // label_Menu
            // 
            label_Menu.AutoSize = true;
            label_Menu.ForeColor = Color.Gainsboro;
            label_Menu.Location = new Point(70, 28);
            label_Menu.Name = "label_Menu";
            label_Menu.Size = new Size(47, 15);
            label_Menu.TabIndex = 8;
            label_Menu.Text = "   Menu";
            // 
            // btn_Menu
            // 
            btn_Menu.BackgroundImage = Properties.Resources.menu;
            btn_Menu.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Menu.FlatAppearance.BorderSize = 0;
            btn_Menu.FlatStyle = FlatStyle.Flat;
            btn_Menu.ForeColor = Color.Gainsboro;
            btn_Menu.Location = new Point(18, 18);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(46, 34);
            btn_Menu.TabIndex = 7;
            btn_Menu.UseVisualStyleBackColor = true;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // panel_Tables
            // 
            panel_Tables.Controls.Add(btn_Users);
            panel_Tables.Controls.Add(btn_PeripheralDevices);
            panel_Tables.Controls.Add(btn_Components);
            panel_Tables.Controls.Add(btn_Supplies);
            panel_Tables.Controls.Add(btn_OfficeEquip);
            panel_Tables.Controls.Add(btn_NetworkDevices);
            panel_Tables.Controls.Add(btn_Tables);
            panel_Tables.Controls.Add(btn_Computers);
            panel_Tables.Location = new Point(3, 82);
            panel_Tables.MaximumSize = new Size(222, 400);
            panel_Tables.MinimumSize = new Size(222, 79);
            panel_Tables.Name = "panel_Tables";
            panel_Tables.Size = new Size(222, 79);
            panel_Tables.TabIndex = 6;
            // 
            // btn_Users
            // 
            btn_Users.FlatAppearance.BorderSize = 0;
            btn_Users.FlatStyle = FlatStyle.Flat;
            btn_Users.ForeColor = Color.Gainsboro;
            btn_Users.Image = Properties.Resources.users;
            btn_Users.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Users.Location = new Point(0, 356);
            btn_Users.Name = "btn_Users";
            btn_Users.Padding = new Padding(10, 0, 0, 0);
            btn_Users.Size = new Size(217, 38);
            btn_Users.TabIndex = 8;
            btn_Users.Text = "Users";
            btn_Users.TextAlign = ContentAlignment.MiddleLeft;
            btn_Users.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Users.UseVisualStyleBackColor = true;
            btn_Users.Click += btn_Users_Click;
            // 
            // btn_PeripheralDevices
            // 
            btn_PeripheralDevices.FlatAppearance.BorderSize = 0;
            btn_PeripheralDevices.FlatStyle = FlatStyle.Flat;
            btn_PeripheralDevices.ForeColor = Color.Gainsboro;
            btn_PeripheralDevices.Image = Properties.Resources.perif;
            btn_PeripheralDevices.ImageAlign = ContentAlignment.MiddleLeft;
            btn_PeripheralDevices.Location = new Point(0, 312);
            btn_PeripheralDevices.Name = "btn_PeripheralDevices";
            btn_PeripheralDevices.Padding = new Padding(10, 0, 0, 0);
            btn_PeripheralDevices.Size = new Size(217, 38);
            btn_PeripheralDevices.TabIndex = 7;
            btn_PeripheralDevices.Text = "Peripheral Devices";
            btn_PeripheralDevices.TextAlign = ContentAlignment.MiddleLeft;
            btn_PeripheralDevices.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_PeripheralDevices.UseVisualStyleBackColor = true;
            btn_PeripheralDevices.Click += btn_PeripheralDevices_Click;
            // 
            // btn_Components
            // 
            btn_Components.FlatAppearance.BorderSize = 0;
            btn_Components.FlatStyle = FlatStyle.Flat;
            btn_Components.ForeColor = Color.Gainsboro;
            btn_Components.Image = Properties.Resources.components;
            btn_Components.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Components.Location = new Point(0, 267);
            btn_Components.Name = "btn_Components";
            btn_Components.Padding = new Padding(10, 0, 0, 0);
            btn_Components.Size = new Size(217, 38);
            btn_Components.TabIndex = 6;
            btn_Components.Text = "PC Components";
            btn_Components.TextAlign = ContentAlignment.MiddleLeft;
            btn_Components.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Components.UseVisualStyleBackColor = true;
            btn_Components.Click += btn_Components_Click;
            // 
            // btn_Supplies
            // 
            btn_Supplies.FlatAppearance.BorderSize = 0;
            btn_Supplies.FlatStyle = FlatStyle.Flat;
            btn_Supplies.ForeColor = Color.Gainsboro;
            btn_Supplies.Image = Properties.Resources.supply;
            btn_Supplies.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Supplies.Location = new Point(0, 223);
            btn_Supplies.Name = "btn_Supplies";
            btn_Supplies.Padding = new Padding(10, 0, 0, 0);
            btn_Supplies.Size = new Size(217, 38);
            btn_Supplies.TabIndex = 5;
            btn_Supplies.Text = "Supplies";
            btn_Supplies.TextAlign = ContentAlignment.MiddleLeft;
            btn_Supplies.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Supplies.UseVisualStyleBackColor = true;
            btn_Supplies.Click += btn_Supplies_Click;
            // 
            // btn_OfficeEquip
            // 
            btn_OfficeEquip.FlatAppearance.BorderSize = 0;
            btn_OfficeEquip.FlatStyle = FlatStyle.Flat;
            btn_OfficeEquip.ForeColor = Color.Gainsboro;
            btn_OfficeEquip.Image = Properties.Resources.office;
            btn_OfficeEquip.ImageAlign = ContentAlignment.MiddleLeft;
            btn_OfficeEquip.Location = new Point(0, 135);
            btn_OfficeEquip.Name = "btn_OfficeEquip";
            btn_OfficeEquip.Padding = new Padding(10, 0, 0, 0);
            btn_OfficeEquip.Size = new Size(217, 38);
            btn_OfficeEquip.TabIndex = 4;
            btn_OfficeEquip.Text = "Office Equipment";
            btn_OfficeEquip.TextAlign = ContentAlignment.MiddleLeft;
            btn_OfficeEquip.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_OfficeEquip.UseVisualStyleBackColor = true;
            btn_OfficeEquip.Click += btn_OfficeEquip_Click;
            // 
            // btn_NetworkDevices
            // 
            btn_NetworkDevices.FlatAppearance.BorderSize = 0;
            btn_NetworkDevices.FlatStyle = FlatStyle.Flat;
            btn_NetworkDevices.ForeColor = Color.Gainsboro;
            btn_NetworkDevices.Image = Properties.Resources.wifi;
            btn_NetworkDevices.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NetworkDevices.Location = new Point(0, 179);
            btn_NetworkDevices.Name = "btn_NetworkDevices";
            btn_NetworkDevices.Padding = new Padding(10, 0, 0, 0);
            btn_NetworkDevices.Size = new Size(217, 38);
            btn_NetworkDevices.TabIndex = 3;
            btn_NetworkDevices.Text = "Network Devices";
            btn_NetworkDevices.TextAlign = ContentAlignment.MiddleLeft;
            btn_NetworkDevices.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_NetworkDevices.UseVisualStyleBackColor = true;
            btn_NetworkDevices.Click += btn_NetworkDevices_Click;
            // 
            // btn_Tables
            // 
            btn_Tables.FlatAppearance.BorderSize = 0;
            btn_Tables.FlatStyle = FlatStyle.Flat;
            btn_Tables.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Tables.ForeColor = Color.Gainsboro;
            btn_Tables.Image = Properties.Resources.tables;
            btn_Tables.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Tables.Location = new Point(0, 0);
            btn_Tables.Name = "btn_Tables";
            btn_Tables.Size = new Size(217, 85);
            btn_Tables.TabIndex = 1;
            btn_Tables.Text = "   Tables";
            btn_Tables.TextAlign = ContentAlignment.MiddleLeft;
            btn_Tables.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Tables.UseVisualStyleBackColor = true;
            btn_Tables.Click += btn_Tables_Click;
            // 
            // btn_Computers
            // 
            btn_Computers.FlatAppearance.BorderSize = 0;
            btn_Computers.FlatStyle = FlatStyle.Flat;
            btn_Computers.ForeColor = Color.Gainsboro;
            btn_Computers.Image = Properties.Resources.pc;
            btn_Computers.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Computers.Location = new Point(0, 91);
            btn_Computers.Name = "btn_Computers";
            btn_Computers.Padding = new Padding(10, 0, 0, 0);
            btn_Computers.Size = new Size(217, 38);
            btn_Computers.TabIndex = 2;
            btn_Computers.Text = "Computers";
            btn_Computers.TextAlign = ContentAlignment.MiddleLeft;
            btn_Computers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Computers.UseVisualStyleBackColor = true;
            btn_Computers.Click += btn_Computers_Click;
            // 
            // btn_Search
            // 
            btn_Search.FlatAppearance.BorderSize = 0;
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.ForeColor = Color.Gainsboro;
            btn_Search.Image = Properties.Resources.search;
            btn_Search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Search.Location = new Point(3, 167);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(217, 68);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "   Search";
            btn_Search.TextAlign = ContentAlignment.MiddleLeft;
            btn_Search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Save
            // 
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.ForeColor = Color.Gainsboro;
            btn_Save.Image = Properties.Resources.save;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(3, 241);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(217, 68);
            btn_Save.TabIndex = 7;
            btn_Save.Text = "   Save";
            btn_Save.TextAlign = ContentAlignment.MiddleLeft;
            btn_Save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Change
            // 
            btn_Change.FlatAppearance.BorderSize = 0;
            btn_Change.FlatStyle = FlatStyle.Flat;
            btn_Change.ForeColor = Color.Gainsboro;
            btn_Change.Image = Properties.Resources.tables;
            btn_Change.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Change.Location = new Point(3, 315);
            btn_Change.Name = "btn_Change";
            btn_Change.Size = new Size(217, 68);
            btn_Change.TabIndex = 8;
            btn_Change.Text = "   Change";
            btn_Change.TextAlign = ContentAlignment.MiddleLeft;
            btn_Change.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Change.UseVisualStyleBackColor = true;
            btn_Change.Click += btn_Change_Click;
            // 
            // btn_Add
            // 
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.ForeColor = Color.Gainsboro;
            btn_Add.Image = Properties.Resources.search;
            btn_Add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add.Location = new Point(3, 389);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(217, 68);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "   +";
            btn_Add.TextAlign = ContentAlignment.MiddleLeft;
            btn_Add.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.FlatAppearance.BorderSize = 0;
            btn_Remove.FlatStyle = FlatStyle.Flat;
            btn_Remove.ForeColor = Color.Gainsboro;
            btn_Remove.Image = Properties.Resources.search;
            btn_Remove.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Remove.Location = new Point(3, 463);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(217, 68);
            btn_Remove.TabIndex = 10;
            btn_Remove.Text = "   -";
            btn_Remove.TextAlign = ContentAlignment.MiddleLeft;
            btn_Remove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // Tables_btn_timer
            // 
            Tables_btn_timer.Interval = 2;
            Tables_btn_timer.Tick += Tables_btn_timer_Tick;
            // 
            // DB_Grid
            // 
            DB_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DB_Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DB_Grid.BackgroundColor = Color.White;
            DB_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DB_Grid.GridColor = Color.White;
            DB_Grid.Location = new Point(106, 12);
            DB_Grid.MaximumSize = new Size(1217, 669);
            DB_Grid.MinimumSize = new Size(1090, 669);
            DB_Grid.Name = "DB_Grid";
            DB_Grid.RowTemplate.Height = 25;
            DB_Grid.Size = new Size(1217, 669);
            DB_Grid.TabIndex = 6;
            DB_Grid.CellValueChanged += DB_Grid_CellValueChanged;
            DB_Grid.EditingControlShowing += DB_Grid_EditingControlShowing;
            // 
            // Menu_Timer
            // 
            Menu_Timer.Interval = 2;
            Menu_Timer.Tick += Menu_Timer_Tick;
            // 
            // Accounting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1338, 702);
            Controls.Add(DB_Grid);
            Controls.Add(flowLayoutPanelMenu);
            Name = "Accounting";
            Text = "Accounting";
            FormClosing += Accounting_FormClosing;
            flowLayoutPanelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel_Tables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DB_Grid).EndInit();
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
        internal DataGridView DB_Grid;
        private Button btn_Save;
        private Button btn_Change;
        private Button btn_Add;
        private Button btn_Remove;
        private Button btn_Menu;
        private Label label_Menu;
        private System.Windows.Forms.Timer Menu_Timer;
    }
}