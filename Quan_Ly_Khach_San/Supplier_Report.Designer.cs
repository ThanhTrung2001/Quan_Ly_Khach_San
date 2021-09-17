
namespace Quan_Ly_Khach_San
{
    partial class Supplier_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.PrintBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ResearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DayPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SupplierPicker = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PayTxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(165, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Supplier\'s Provide Research";
            // 
            // PrintBtn
            // 
            this.PrintBtn.BorderRadius = 15;
            this.PrintBtn.CheckedState.Parent = this.PrintBtn;
            this.PrintBtn.CustomImages.Parent = this.PrintBtn;
            this.PrintBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PrintBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PrintBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PrintBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PrintBtn.DisabledState.Parent = this.PrintBtn;
            this.PrintBtn.FillColor = System.Drawing.Color.MediumPurple;
            this.PrintBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.HoverState.Parent = this.PrintBtn;
            this.PrintBtn.Location = new System.Drawing.Point(373, 182);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.ShadowDecoration.Parent = this.PrintBtn;
            this.PrintBtn.Size = new System.Drawing.Size(180, 35);
            this.PrintBtn.TabIndex = 36;
            this.PrintBtn.Text = "Print Bill";
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ResearchBtn
            // 
            this.ResearchBtn.BorderRadius = 15;
            this.ResearchBtn.CheckedState.Parent = this.ResearchBtn;
            this.ResearchBtn.CustomImages.Parent = this.ResearchBtn;
            this.ResearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ResearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ResearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ResearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ResearchBtn.DisabledState.Parent = this.ResearchBtn;
            this.ResearchBtn.FillColor = System.Drawing.Color.RoyalBlue;
            this.ResearchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResearchBtn.ForeColor = System.Drawing.Color.White;
            this.ResearchBtn.HoverState.Parent = this.ResearchBtn;
            this.ResearchBtn.Location = new System.Drawing.Point(163, 182);
            this.ResearchBtn.Name = "ResearchBtn";
            this.ResearchBtn.ShadowDecoration.Parent = this.ResearchBtn;
            this.ResearchBtn.Size = new System.Drawing.Size(180, 35);
            this.ResearchBtn.TabIndex = 35;
            this.ResearchBtn.Text = "Research";
            this.ResearchBtn.Click += new System.EventHandler(this.ResearchBtn_Click);
            // 
            // DayPicker
            // 
            this.DayPicker.BorderRadius = 15;
            this.DayPicker.BorderThickness = 1;
            this.DayPicker.CheckedState.Parent = this.DayPicker;
            this.DayPicker.FillColor = System.Drawing.Color.White;
            this.DayPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DayPicker.HoverState.Parent = this.DayPicker;
            this.DayPicker.Location = new System.Drawing.Point(275, 64);
            this.DayPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DayPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DayPicker.Name = "DayPicker";
            this.DayPicker.ShadowDecoration.Parent = this.DayPicker;
            this.DayPicker.Size = new System.Drawing.Size(264, 51);
            this.DayPicker.TabIndex = 34;
            this.DayPicker.Value = new System.DateTime(2021, 9, 17, 21, 30, 9, 950);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Choose Day :";
            // 
            // SupplierPicker
            // 
            this.SupplierPicker.BackColor = System.Drawing.Color.Transparent;
            this.SupplierPicker.BorderColor = System.Drawing.Color.Black;
            this.SupplierPicker.BorderRadius = 15;
            this.SupplierPicker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SupplierPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierPicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SupplierPicker.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SupplierPicker.FocusedState.Parent = this.SupplierPicker;
            this.SupplierPicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SupplierPicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SupplierPicker.HoverState.Parent = this.SupplierPicker;
            this.SupplierPicker.ItemHeight = 30;
            this.SupplierPicker.ItemsAppearance.Parent = this.SupplierPicker;
            this.SupplierPicker.Location = new System.Drawing.Point(272, 121);
            this.SupplierPicker.Name = "SupplierPicker";
            this.SupplierPicker.ShadowDecoration.Parent = this.SupplierPicker;
            this.SupplierPicker.Size = new System.Drawing.Size(264, 36);
            this.SupplierPicker.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Choose Supplier:";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(23, 234);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(648, 249);
            this.guna2DataGridView1.TabIndex = 55;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PayTxb
            // 
            this.PayTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PayTxb.DefaultText = "0";
            this.PayTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PayTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PayTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PayTxb.DisabledState.Parent = this.PayTxb;
            this.PayTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PayTxb.FillColor = System.Drawing.Color.Silver;
            this.PayTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PayTxb.FocusedState.Parent = this.PayTxb;
            this.PayTxb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayTxb.ForeColor = System.Drawing.Color.Black;
            this.PayTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PayTxb.HoverState.Parent = this.PayTxb;
            this.PayTxb.Location = new System.Drawing.Point(287, 508);
            this.PayTxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PayTxb.Name = "PayTxb";
            this.PayTxb.PasswordChar = '\0';
            this.PayTxb.PlaceholderText = "";
            this.PayTxb.ReadOnly = true;
            this.PayTxb.SelectedText = "";
            this.PayTxb.SelectionStart = 1;
            this.PayTxb.ShadowDecoration.Parent = this.PayTxb;
            this.PayTxb.Size = new System.Drawing.Size(189, 31);
            this.PayTxb.TabIndex = 57;
            this.PayTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Pay :";
            // 
            // Supplier_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(700, 552);
            this.Controls.Add(this.PayTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.SupplierPicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.ResearchBtn);
            this.Controls.Add(this.DayPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Supplier_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier_Report";
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button PrintBtn;
        private Guna.UI2.WinForms.Guna2Button ResearchBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker DayPicker;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox SupplierPicker;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox PayTxb;
        private System.Windows.Forms.Label label2;
    }
}