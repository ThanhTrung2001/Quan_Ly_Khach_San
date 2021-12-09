
namespace Quan_Ly_Khach_San
{
    partial class Risk_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Risk_Form));
            this.DeleteBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.CreateBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.RiskTypeTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.RiskCodeTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.RiskGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.riskid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.risktype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskCostTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchRisk = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SearchBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.RiskGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BorderRadius = 15;
            this.DeleteBtn.CheckedState.Parent = this.DeleteBtn;
            this.DeleteBtn.CustomImages.Parent = this.DeleteBtn;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.DisabledState.Parent = this.DeleteBtn;
            this.DeleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteBtn.FillColor2 = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.HoverState.Parent = this.DeleteBtn;
            this.DeleteBtn.Location = new System.Drawing.Point(972, 294);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(196, 60);
            this.DeleteBtn.TabIndex = 30;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.BorderRadius = 15;
            this.CreateBtn.CheckedState.Parent = this.CreateBtn;
            this.CreateBtn.CustomImages.Parent = this.CreateBtn;
            this.CreateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CreateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CreateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CreateBtn.DisabledState.Parent = this.CreateBtn;
            this.CreateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CreateBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CreateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.HoverState.Parent = this.CreateBtn;
            this.CreateBtn.Location = new System.Drawing.Point(741, 294);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.ShadowDecoration.Parent = this.CreateBtn;
            this.CreateBtn.Size = new System.Drawing.Size(196, 60);
            this.CreateBtn.TabIndex = 29;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // RiskTypeTxb
            // 
            this.RiskTypeTxb.BorderColor = System.Drawing.Color.White;
            this.RiskTypeTxb.BorderRadius = 15;
            this.RiskTypeTxb.BorderThickness = 2;
            this.RiskTypeTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RiskTypeTxb.DefaultText = "Type";
            this.RiskTypeTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RiskTypeTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RiskTypeTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RiskTypeTxb.DisabledState.Parent = this.RiskTypeTxb;
            this.RiskTypeTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RiskTypeTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.RiskTypeTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RiskTypeTxb.FocusedState.Parent = this.RiskTypeTxb;
            this.RiskTypeTxb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.RiskTypeTxb.ForeColor = System.Drawing.Color.White;
            this.RiskTypeTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RiskTypeTxb.HoverState.Parent = this.RiskTypeTxb;
            this.RiskTypeTxb.Location = new System.Drawing.Point(165, 306);
            this.RiskTypeTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RiskTypeTxb.Name = "RiskTypeTxb";
            this.RiskTypeTxb.PasswordChar = '\0';
            this.RiskTypeTxb.PlaceholderText = "";
            this.RiskTypeTxb.SelectedText = "";
            this.RiskTypeTxb.SelectionStart = 4;
            this.RiskTypeTxb.ShadowDecoration.Parent = this.RiskTypeTxb;
            this.RiskTypeTxb.Size = new System.Drawing.Size(417, 48);
            this.RiskTypeTxb.TabIndex = 24;
            this.RiskTypeTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RiskCodeTxb
            // 
            this.RiskCodeTxb.BorderColor = System.Drawing.Color.White;
            this.RiskCodeTxb.BorderRadius = 15;
            this.RiskCodeTxb.BorderThickness = 2;
            this.RiskCodeTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RiskCodeTxb.DefaultText = "Id";
            this.RiskCodeTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RiskCodeTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RiskCodeTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RiskCodeTxb.DisabledState.Parent = this.RiskCodeTxb;
            this.RiskCodeTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RiskCodeTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.RiskCodeTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RiskCodeTxb.FocusedState.Parent = this.RiskCodeTxb;
            this.RiskCodeTxb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiskCodeTxb.ForeColor = System.Drawing.Color.White;
            this.RiskCodeTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RiskCodeTxb.HoverState.Parent = this.RiskCodeTxb;
            this.RiskCodeTxb.Location = new System.Drawing.Point(165, 210);
            this.RiskCodeTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RiskCodeTxb.Name = "RiskCodeTxb";
            this.RiskCodeTxb.PasswordChar = '\0';
            this.RiskCodeTxb.PlaceholderText = "";
            this.RiskCodeTxb.SelectedText = "";
            this.RiskCodeTxb.SelectionStart = 2;
            this.RiskCodeTxb.ShadowDecoration.Parent = this.RiskCodeTxb;
            this.RiskCodeTxb.Size = new System.Drawing.Size(427, 48);
            this.RiskCodeTxb.TabIndex = 22;
            this.RiskCodeTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RiskGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.RiskGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.RiskGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RiskGrid.BackgroundColor = System.Drawing.Color.White;
            this.RiskGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RiskGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RiskGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RiskGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.RiskGrid.ColumnHeadersHeight = 40;
            this.RiskGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.riskid,
            this.risktype,
            this.refund});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RiskGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.RiskGrid.EnableHeadersVisualStyles = false;
            this.RiskGrid.GridColor = System.Drawing.Color.White;
            this.RiskGrid.Location = new System.Drawing.Point(35, 431);
            this.RiskGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RiskGrid.Name = "RiskGrid";
            this.RiskGrid.ReadOnly = true;
            this.RiskGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RiskGrid.RowHeadersVisible = false;
            this.RiskGrid.RowHeadersWidth = 51;
            this.RiskGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RiskGrid.Size = new System.Drawing.Size(1265, 354);
            this.RiskGrid.TabIndex = 20;
            this.RiskGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RiskGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RiskGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RiskGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RiskGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RiskGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RiskGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.RiskGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RiskGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RiskGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RiskGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RiskGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RiskGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.RiskGrid.ThemeStyle.ReadOnly = true;
            this.RiskGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RiskGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RiskGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RiskGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RiskGrid.ThemeStyle.RowsStyle.Height = 22;
            this.RiskGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RiskGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RiskGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RiskGrid_CellContentClick);
            // 
            // riskid
            // 
            this.riskid.DataPropertyName = "MaRR";
            this.riskid.HeaderText = "Risk ID";
            this.riskid.MinimumWidth = 6;
            this.riskid.Name = "riskid";
            this.riskid.ReadOnly = true;
            // 
            // risktype
            // 
            this.risktype.DataPropertyName = "LoaiRR";
            this.risktype.HeaderText = "Risk Type";
            this.risktype.MinimumWidth = 6;
            this.risktype.Name = "risktype";
            this.risktype.ReadOnly = true;
            // 
            // refund
            // 
            this.refund.DataPropertyName = "PhanHoanTien";
            this.refund.HeaderText = "Refund";
            this.refund.MinimumWidth = 6;
            this.refund.Name = "refund";
            this.refund.ReadOnly = true;
            // 
            // RiskCostTxb
            // 
            this.RiskCostTxb.BackColor = System.Drawing.Color.Transparent;
            this.RiskCostTxb.BorderColor = System.Drawing.Color.White;
            this.RiskCostTxb.BorderRadius = 15;
            this.RiskCostTxb.BorderThickness = 2;
            this.RiskCostTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RiskCostTxb.DefaultText = "Total";
            this.RiskCostTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RiskCostTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RiskCostTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RiskCostTxb.DisabledState.Parent = this.RiskCostTxb;
            this.RiskCostTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RiskCostTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.RiskCostTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RiskCostTxb.FocusedState.Parent = this.RiskCostTxb;
            this.RiskCostTxb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiskCostTxb.ForeColor = System.Drawing.Color.White;
            this.RiskCostTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RiskCostTxb.HoverState.Parent = this.RiskCostTxb;
            this.RiskCostTxb.Location = new System.Drawing.Point(741, 215);
            this.RiskCostTxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RiskCostTxb.Name = "RiskCostTxb";
            this.RiskCostTxb.PasswordChar = '\0';
            this.RiskCostTxb.PlaceholderText = "";
            this.RiskCostTxb.SelectedText = "";
            this.RiskCostTxb.SelectionStart = 5;
            this.RiskCostTxb.ShadowDecoration.Parent = this.RiskCostTxb;
            this.RiskCostTxb.Size = new System.Drawing.Size(149, 50);
            this.RiskCostTxb.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.RiskCostTxb.TabIndex = 70;
            this.RiskCostTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(477, 31);
            this.siticoneHtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(420, 48);
            this.siticoneHtmlLabel1.TabIndex = 73;
            this.siticoneHtmlLabel1.Text = "RISKS MANAGEMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(160, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 27);
            this.label1.TabIndex = 74;
            this.label1.Text = "Risk ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(160, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 75;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(736, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 76;
            this.label3.Text = "Refund";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(899, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "USD";
            // 
            // searchRisk
            // 
            this.searchRisk.BorderColor = System.Drawing.Color.White;
            this.searchRisk.BorderRadius = 10;
            this.searchRisk.BorderThickness = 2;
            this.searchRisk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchRisk.DefaultText = "";
            this.searchRisk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchRisk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchRisk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchRisk.DisabledState.Parent = this.searchRisk;
            this.searchRisk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchRisk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.searchRisk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchRisk.FocusedState.Parent = this.searchRisk;
            this.searchRisk.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRisk.ForeColor = System.Drawing.Color.White;
            this.searchRisk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchRisk.HoverState.Parent = this.searchRisk;
            this.searchRisk.Location = new System.Drawing.Point(403, 381);
            this.searchRisk.Margin = new System.Windows.Forms.Padding(4);
            this.searchRisk.Name = "searchRisk";
            this.searchRisk.PasswordChar = '\0';
            this.searchRisk.PlaceholderText = "";
            this.searchRisk.SelectedText = "";
            this.searchRisk.ShadowDecoration.Parent = this.searchRisk;
            this.searchRisk.Size = new System.Drawing.Size(375, 42);
            this.searchRisk.TabIndex = 78;
            this.searchRisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchRisk.TextChanged += new System.EventHandler(this.searchRisk_TextChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.CheckedState.Parent = this.SearchBtn;
            this.SearchBtn.CustomImages.Parent = this.SearchBtn;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.DisabledState.Parent = this.SearchBtn;
            this.SearchBtn.FillColor = System.Drawing.Color.Transparent;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.HoverState.Parent = this.SearchBtn;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.SearchBtn.Location = new System.Drawing.Point(786, 381);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.ShadowDecoration.Parent = this.SearchBtn;
            this.SearchBtn.Size = new System.Drawing.Size(47, 48);
            this.SearchBtn.TabIndex = 79;
            // 
            // Risk_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1333, 800);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.searchRisk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.RiskCostTxb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.RiskTypeTxb);
            this.Controls.Add(this.RiskCodeTxb);
            this.Controls.Add(this.RiskGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Risk_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Risk_Form";
            this.Load += new System.EventHandler(this.Risk_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RiskGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton DeleteBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton CreateBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox RiskTypeTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox RiskCodeTxb;
        private Guna.UI2.WinForms.Guna2DataGridView RiskGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox RiskCostTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskid;
        private System.Windows.Forms.DataGridViewTextBoxColumn risktype;
        private System.Windows.Forms.DataGridViewTextBoxColumn refund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox searchRisk;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SearchBtn;
    }
}