
namespace Quan_Ly_Khach_San
{
    partial class Customer_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Form));
            this.CustomerGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.CustomerPhonetxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.CustomerIdentityTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.CustomerNoteTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.EditBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.DeleteBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.SearchTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SearchBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.CustomerAddress = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.CustomerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerGrid.BackgroundColor = System.Drawing.Color.White;
            this.CustomerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CustomerGrid.ColumnHeadersHeight = 40;
            this.CustomerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKH,
            this.tenKhachHang,
            this.SDT,
            this.CMND,
            this.diaChi,
            this.ghiChu});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.CustomerGrid.EnableHeadersVisualStyles = false;
            this.CustomerGrid.GridColor = System.Drawing.Color.White;
            this.CustomerGrid.Location = new System.Drawing.Point(8, 352);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.ReadOnly = true;
            this.CustomerGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomerGrid.RowHeadersVisible = false;
            this.CustomerGrid.RowHeadersWidth = 51;
            this.CustomerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGrid.Size = new System.Drawing.Size(985, 288);
            this.CustomerGrid.TabIndex = 1;
            this.CustomerGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.CustomerGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.CustomerGrid.ThemeStyle.ReadOnly = true;
            this.CustomerGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGrid.ThemeStyle.RowsStyle.Height = 22;
            this.CustomerGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGrid_CellContentClick);
            // 
            // maKH
            // 
            this.maKH.DataPropertyName = "maKH";
            this.maKH.HeaderText = "Customer ID";
            this.maKH.MinimumWidth = 6;
            this.maKH.Name = "maKH";
            this.maKH.ReadOnly = true;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataPropertyName = "tenKhachHang";
            this.tenKhachHang.HeaderText = "Name";
            this.tenKhachHang.MinimumWidth = 6;
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Phone";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "Identify numbers";
            this.CMND.MinimumWidth = 6;
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Address";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Note";
            this.ghiChu.MinimumWidth = 6;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            // 
            // CustomerNameTxb
            // 
            this.CustomerNameTxb.BorderColor = System.Drawing.Color.White;
            this.CustomerNameTxb.BorderRadius = 15;
            this.CustomerNameTxb.BorderThickness = 2;
            this.CustomerNameTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTxb.DefaultText = "";
            this.CustomerNameTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNameTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNameTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxb.DisabledState.Parent = this.CustomerNameTxb;
            this.CustomerNameTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.CustomerNameTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxb.FocusedState.Parent = this.CustomerNameTxb;
            this.CustomerNameTxb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTxb.ForeColor = System.Drawing.Color.White;
            this.CustomerNameTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxb.HoverState.Parent = this.CustomerNameTxb;
            this.CustomerNameTxb.Location = new System.Drawing.Point(123, 143);
            this.CustomerNameTxb.Name = "CustomerNameTxb";
            this.CustomerNameTxb.PasswordChar = '\0';
            this.CustomerNameTxb.PlaceholderText = "Name";
            this.CustomerNameTxb.SelectedText = "";
            this.CustomerNameTxb.ShadowDecoration.Parent = this.CustomerNameTxb;
            this.CustomerNameTxb.Size = new System.Drawing.Size(320, 39);
            this.CustomerNameTxb.TabIndex = 3;
            this.CustomerNameTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomerPhonetxb
            // 
            this.CustomerPhonetxb.BorderColor = System.Drawing.Color.White;
            this.CustomerPhonetxb.BorderRadius = 15;
            this.CustomerPhonetxb.BorderThickness = 2;
            this.CustomerPhonetxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerPhonetxb.DefaultText = "";
            this.CustomerPhonetxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerPhonetxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerPhonetxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerPhonetxb.DisabledState.Parent = this.CustomerPhonetxb;
            this.CustomerPhonetxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerPhonetxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.CustomerPhonetxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerPhonetxb.FocusedState.Parent = this.CustomerPhonetxb;
            this.CustomerPhonetxb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhonetxb.ForeColor = System.Drawing.Color.White;
            this.CustomerPhonetxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerPhonetxb.HoverState.Parent = this.CustomerPhonetxb;
            this.CustomerPhonetxb.Location = new System.Drawing.Point(123, 217);
            this.CustomerPhonetxb.Name = "CustomerPhonetxb";
            this.CustomerPhonetxb.PasswordChar = '\0';
            this.CustomerPhonetxb.PlaceholderText = "Phone Numbers";
            this.CustomerPhonetxb.SelectedText = "";
            this.CustomerPhonetxb.ShadowDecoration.Parent = this.CustomerPhonetxb;
            this.CustomerPhonetxb.Size = new System.Drawing.Size(263, 39);
            this.CustomerPhonetxb.TabIndex = 5;
            this.CustomerPhonetxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerPhonetxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerPhonetxb_KeyPress);
            // 
            // CustomerIdentityTxb
            // 
            this.CustomerIdentityTxb.BorderColor = System.Drawing.Color.White;
            this.CustomerIdentityTxb.BorderRadius = 15;
            this.CustomerIdentityTxb.BorderThickness = 2;
            this.CustomerIdentityTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerIdentityTxb.DefaultText = "";
            this.CustomerIdentityTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerIdentityTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerIdentityTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerIdentityTxb.DisabledState.Parent = this.CustomerIdentityTxb;
            this.CustomerIdentityTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerIdentityTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.CustomerIdentityTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIdentityTxb.FocusedState.Parent = this.CustomerIdentityTxb;
            this.CustomerIdentityTxb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdentityTxb.ForeColor = System.Drawing.Color.White;
            this.CustomerIdentityTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIdentityTxb.HoverState.Parent = this.CustomerIdentityTxb;
            this.CustomerIdentityTxb.Location = new System.Drawing.Point(123, 291);
            this.CustomerIdentityTxb.Name = "CustomerIdentityTxb";
            this.CustomerIdentityTxb.PasswordChar = '\0';
            this.CustomerIdentityTxb.PlaceholderText = "Identity Numbers";
            this.CustomerIdentityTxb.SelectedText = "";
            this.CustomerIdentityTxb.ShadowDecoration.Parent = this.CustomerIdentityTxb;
            this.CustomerIdentityTxb.Size = new System.Drawing.Size(263, 39);
            this.CustomerIdentityTxb.TabIndex = 7;
            this.CustomerIdentityTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerIdentityTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerIdentityTxb_KeyPress);
            // 
            // CustomerNoteTxb
            // 
            this.CustomerNoteTxb.BorderColor = System.Drawing.Color.White;
            this.CustomerNoteTxb.BorderRadius = 15;
            this.CustomerNoteTxb.BorderThickness = 2;
            this.CustomerNoteTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNoteTxb.DefaultText = "";
            this.CustomerNoteTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNoteTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNoteTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNoteTxb.DisabledState.Parent = this.CustomerNoteTxb;
            this.CustomerNoteTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNoteTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.CustomerNoteTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNoteTxb.FocusedState.Parent = this.CustomerNoteTxb;
            this.CustomerNoteTxb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNoteTxb.ForeColor = System.Drawing.Color.White;
            this.CustomerNoteTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNoteTxb.HoverState.Parent = this.CustomerNoteTxb;
            this.CustomerNoteTxb.Location = new System.Drawing.Point(555, 217);
            this.CustomerNoteTxb.Name = "CustomerNoteTxb";
            this.CustomerNoteTxb.PasswordChar = '\0';
            this.CustomerNoteTxb.PlaceholderText = "Note";
            this.CustomerNoteTxb.SelectedText = "";
            this.CustomerNoteTxb.ShadowDecoration.Parent = this.CustomerNoteTxb;
            this.CustomerNoteTxb.Size = new System.Drawing.Size(323, 43);
            this.CustomerNoteTxb.TabIndex = 8;
            this.CustomerNoteTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditBtn
            // 
            this.EditBtn.BorderRadius = 15;
            this.EditBtn.CheckedState.Parent = this.EditBtn;
            this.EditBtn.CustomImages.Parent = this.EditBtn;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.DisabledState.Parent = this.EditBtn;
            this.EditBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.HoverState.Parent = this.EditBtn;
            this.EditBtn.Location = new System.Drawing.Point(555, 281);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ShadowDecoration.Parent = this.EditBtn;
            this.EditBtn.Size = new System.Drawing.Size(147, 49);
            this.EditBtn.TabIndex = 10;
            this.EditBtn.Text = "Add or Update";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
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
            this.DeleteBtn.Location = new System.Drawing.Point(731, 281);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(147, 49);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SearchTxb
            // 
            this.SearchTxb.BorderColor = System.Drawing.Color.White;
            this.SearchTxb.BorderRadius = 15;
            this.SearchTxb.BorderThickness = 2;
            this.SearchTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTxb.DefaultText = "";
            this.SearchTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxb.DisabledState.Parent = this.SearchTxb;
            this.SearchTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.SearchTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxb.FocusedState.Parent = this.SearchTxb;
            this.SearchTxb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTxb.HoverState.Parent = this.SearchTxb;
            this.SearchTxb.Location = new System.Drawing.Point(347, 52);
            this.SearchTxb.Name = "SearchTxb";
            this.SearchTxb.PasswordChar = '\0';
            this.SearchTxb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.SearchTxb.PlaceholderText = "Search Customer\'s Name";
            this.SearchTxb.SelectedText = "";
            this.SearchTxb.ShadowDecoration.Parent = this.SearchTxb;
            this.SearchTxb.Size = new System.Drawing.Size(298, 39);
            this.SearchTxb.TabIndex = 17;
            this.SearchTxb.TextChanged += new System.EventHandler(this.SearchTxb_TextChanged);
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
            this.SearchBtn.Location = new System.Drawing.Point(651, 52);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.ShadowDecoration.Parent = this.SearchBtn;
            this.SearchBtn.Size = new System.Drawing.Size(35, 39);
            this.SearchBtn.TabIndex = 18;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.BorderColor = System.Drawing.Color.White;
            this.CustomerAddress.BorderRadius = 15;
            this.CustomerAddress.BorderThickness = 2;
            this.CustomerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerAddress.DefaultText = "";
            this.CustomerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerAddress.DisabledState.Parent = this.CustomerAddress;
            this.CustomerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.CustomerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerAddress.FocusedState.Parent = this.CustomerAddress;
            this.CustomerAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddress.ForeColor = System.Drawing.Color.White;
            this.CustomerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerAddress.HoverState.Parent = this.CustomerAddress;
            this.CustomerAddress.Location = new System.Drawing.Point(555, 139);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.PasswordChar = '\0';
            this.CustomerAddress.PlaceholderText = "Address";
            this.CustomerAddress.SelectedText = "";
            this.CustomerAddress.ShadowDecoration.Parent = this.CustomerAddress;
            this.CustomerAddress.Size = new System.Drawing.Size(323, 43);
            this.CustomerAddress.TabIndex = 20;
            this.CustomerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(119, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(119, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(119, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Identity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(551, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(551, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Note";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(373, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 43);
            this.label6.TabIndex = 26;
            this.label6.Text = "Customers List";
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerAddress);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.CustomerNoteTxb);
            this.Controls.Add(this.CustomerIdentityTxb);
            this.Controls.Add(this.CustomerPhonetxb);
            this.Controls.Add(this.CustomerNameTxb);
            this.Controls.Add(this.CustomerGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Form";
            this.Load += new System.EventHandler(this.Customer_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView CustomerGrid;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CustomerNameTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CustomerPhonetxb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CustomerIdentityTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CustomerNoteTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton EditBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton DeleteBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox SearchTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SearchBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}