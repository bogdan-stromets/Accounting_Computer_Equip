namespace Accounting_Computer_Equip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DB_Grid = new DataGridView();
            table_List = new ComboBox();
            Add_Row_Btn = new Button();
            Remove_Row_Btn = new Button();
            Change_btn = new Button();
            Search_Btn = new Button();
            save_btn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DB_Grid).BeginInit();
            SuspendLayout();
            // 
            // DB_Grid
            // 
            DB_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DB_Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DB_Grid.BackgroundColor = Color.White;
            DB_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DB_Grid.GridColor = Color.White;
            DB_Grid.Location = new Point(12, 12);
            DB_Grid.Name = "DB_Grid";
            DB_Grid.RowTemplate.Height = 25;
            DB_Grid.Size = new Size(875, 391);
            DB_Grid.TabIndex = 0;
            DB_Grid.CellValueChanged += DB_Grid_CellValueChanged;
            DB_Grid.EditingControlShowing += DB_Grid_EditingControlShowing;
            // 
            // table_List
            // 
            table_List.DropDownStyle = ComboBoxStyle.DropDownList;
            table_List.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            table_List.FormattingEnabled = true;
            table_List.Location = new Point(12, 443);
            table_List.Name = "table_List";
            table_List.Size = new Size(349, 31);
            table_List.TabIndex = 1;
            table_List.SelectedIndexChanged += table_List_SelectedIndexChanged;
            table_List.MouseWheel += table_List_MouseWheel;
            // 
            // Add_Row_Btn
            // 
            Add_Row_Btn.BackColor = Color.Transparent;
            Add_Row_Btn.BackgroundImage = Properties.Resources.pngwing_com;
            Add_Row_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Add_Row_Btn.FlatStyle = FlatStyle.Flat;
            Add_Row_Btn.ForeColor = Color.Transparent;
            Add_Row_Btn.Location = new Point(789, 434);
            Add_Row_Btn.Name = "Add_Row_Btn";
            Add_Row_Btn.Size = new Size(53, 50);
            Add_Row_Btn.TabIndex = 2;
            Add_Row_Btn.UseVisualStyleBackColor = false;
            Add_Row_Btn.Click += Add_Row_Btn_Click;
            // 
            // Remove_Row_Btn
            // 
            Remove_Row_Btn.BackColor = Color.Transparent;
            Remove_Row_Btn.BackgroundImage = Properties.Resources.add;
            Remove_Row_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Remove_Row_Btn.FlatStyle = FlatStyle.Flat;
            Remove_Row_Btn.ForeColor = Color.Transparent;
            Remove_Row_Btn.Location = new Point(714, 436);
            Remove_Row_Btn.Name = "Remove_Row_Btn";
            Remove_Row_Btn.Size = new Size(53, 50);
            Remove_Row_Btn.TabIndex = 3;
            Remove_Row_Btn.UseVisualStyleBackColor = false;
            Remove_Row_Btn.Click += Remove_Row_Btn_Click;
            // 
            // Change_btn
            // 
            Change_btn.BackColor = Color.Transparent;
            Change_btn.BackgroundImage = Properties.Resources.off;
            Change_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Change_btn.FlatStyle = FlatStyle.Flat;
            Change_btn.ForeColor = Color.Transparent;
            Change_btn.Location = new Point(435, 439);
            Change_btn.Name = "Change_btn";
            Change_btn.Size = new Size(92, 43);
            Change_btn.TabIndex = 4;
            Change_btn.UseVisualStyleBackColor = false;
            Change_btn.Click += Change_btn_Click;
            // 
            // Search_Btn
            // 
            Search_Btn.BackColor = Color.Transparent;
            Search_Btn.BackgroundImage = Properties.Resources.search;
            Search_Btn.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Btn.FlatStyle = FlatStyle.Flat;
            Search_Btn.ForeColor = Color.Transparent;
            Search_Btn.Location = new Point(631, 436);
            Search_Btn.Name = "Search_Btn";
            Search_Btn.Size = new Size(53, 49);
            Search_Btn.TabIndex = 5;
            Search_Btn.UseVisualStyleBackColor = false;
            Search_Btn.Click += Search_Btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.Transparent;
            save_btn.BackgroundImage = Properties.Resources.save;
            save_btn.BackgroundImageLayout = ImageLayout.Stretch;
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.ForeColor = Color.Transparent;
            save_btn.Location = new Point(549, 435);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(53, 49);
            save_btn.TabIndex = 6;
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += SaveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 410);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 7;
            label1.Text = "Обрана таблиця";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(899, 507);
            Controls.Add(label1);
            Controls.Add(save_btn);
            Controls.Add(Search_Btn);
            Controls.Add(Change_btn);
            Controls.Add(Remove_Row_Btn);
            Controls.Add(Add_Row_Btn);
            Controls.Add(table_List);
            Controls.Add(DB_Grid);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Редагування: Вимкнено";
            TransparencyKey = Color.Maroon;
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)DB_Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView DB_Grid;
        internal ComboBox table_List;
        internal Button Add_Row_Btn;
        internal Button Remove_Row_Btn;
        internal Button Change_btn;
        internal Button Search_Btn;
        internal Button save_btn;
        internal Label label1;
    }
}