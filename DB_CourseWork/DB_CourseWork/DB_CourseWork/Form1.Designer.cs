namespace DB_CourseWork
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
            this.DB_Grid = new System.Windows.Forms.DataGridView();
            this.table_List = new System.Windows.Forms.ComboBox();
            this.Add_Row_Btn = new System.Windows.Forms.Button();
            this.Remove_Row_Btn = new System.Windows.Forms.Button();
            this.Change_btn = new System.Windows.Forms.Button();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DB_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // DB_Grid
            // 
            this.DB_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DB_Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DB_Grid.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DB_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DB_Grid.Location = new System.Drawing.Point(12, 12);
            this.DB_Grid.Name = "DB_Grid";
            this.DB_Grid.RowTemplate.Height = 25;
            this.DB_Grid.Size = new System.Drawing.Size(875, 391);
            this.DB_Grid.TabIndex = 0;
            this.DB_Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DB_Grid_CellValueChanged);
            this.DB_Grid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DB_Grid_EditingControlShowing);
            // 
            // table_List
            // 
            this.table_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.table_List.FormattingEnabled = true;
            this.table_List.Location = new System.Drawing.Point(48, 448);
            this.table_List.Name = "table_List";
            this.table_List.Size = new System.Drawing.Size(174, 23);
            this.table_List.TabIndex = 1;
            this.table_List.SelectedIndexChanged += new System.EventHandler(this.table_List_SelectedIndexChanged);
            this.table_List.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.table_List_MouseWheel);
            // 
            // Add_Row_Btn
            // 
            this.Add_Row_Btn.Location = new System.Drawing.Point(653, 431);
            this.Add_Row_Btn.Name = "Add_Row_Btn";
            this.Add_Row_Btn.Size = new System.Drawing.Size(103, 23);
            this.Add_Row_Btn.TabIndex = 2;
            this.Add_Row_Btn.Text = "+";
            this.Add_Row_Btn.UseVisualStyleBackColor = true;
            this.Add_Row_Btn.Click += new System.EventHandler(this.Add_Row_Btn_Click);
            // 
            // Remove_Row_Btn
            // 
            this.Remove_Row_Btn.Location = new System.Drawing.Point(653, 460);
            this.Remove_Row_Btn.Name = "Remove_Row_Btn";
            this.Remove_Row_Btn.Size = new System.Drawing.Size(103, 23);
            this.Remove_Row_Btn.TabIndex = 3;
            this.Remove_Row_Btn.Text = "-";
            this.Remove_Row_Btn.UseVisualStyleBackColor = true;
            this.Remove_Row_Btn.Click += new System.EventHandler(this.Remove_Row_Btn_Click);
            // 
            // Change_btn
            // 
            this.Change_btn.Location = new System.Drawing.Point(793, 460);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(94, 23);
            this.Change_btn.TabIndex = 4;
            this.Change_btn.Text = "Change: false";
            this.Change_btn.UseVisualStyleBackColor = true;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // Search_Btn
            // 
            this.Search_Btn.Location = new System.Drawing.Point(533, 448);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(87, 23);
            this.Search_Btn.TabIndex = 5;
            this.Search_Btn.Text = "<<< Search";
            this.Search_Btn.UseVisualStyleBackColor = true;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(793, 431);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(94, 23);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(899, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.Search_Btn);
            this.Controls.Add(this.Change_btn);
            this.Controls.Add(this.Remove_Row_Btn);
            this.Controls.Add(this.Add_Row_Btn);
            this.Controls.Add(this.table_List);
            this.Controls.Add(this.DB_Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DB_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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