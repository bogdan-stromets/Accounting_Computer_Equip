namespace Accounting_Computer_Equip.Forms
{
    partial class AddictFunc
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
            head_panel = new Panel();
            btn_Close = new Button();
            label1 = new Label();
            label_panel = new FlowLayoutPanel();
            head_panel.SuspendLayout();
            SuspendLayout();
            // 
            // head_panel
            // 
            head_panel.BackColor = Color.FromArgb(60, 138, 103);
            head_panel.Controls.Add(btn_Close);
            head_panel.Controls.Add(label1);
            head_panel.Dock = DockStyle.Top;
            head_panel.Location = new Point(0, 0);
            head_panel.Name = "head_panel";
            head_panel.Size = new Size(956, 64);
            head_panel.TabIndex = 0;
            // 
            // btn_Close
            // 
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Close.ForeColor = Color.White;
            btn_Close.Location = new Point(923, 3);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(30, 31);
            btn_Close.TabIndex = 10;
            btn_Close.Text = "O";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(466, 18);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label_panel
            // 
            label_panel.AutoSize = true;
            label_panel.FlowDirection = FlowDirection.TopDown;
            label_panel.Location = new Point(280, 138);
            label_panel.Name = "label_panel";
            label_panel.Size = new Size(308, 63);
            label_panel.TabIndex = 11;
            // 
            // AddictFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(146, 209, 174);
            ClientSize = new Size(956, 532);
            Controls.Add(label_panel);
            Controls.Add(head_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddictFunc";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            Load += AddictFunc_Load;
            head_panel.ResumeLayout(false);
            head_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel head_panel;
        private Label label1;
        private Button btn_Close;
        private FlowLayoutPanel label_panel;
    }
}