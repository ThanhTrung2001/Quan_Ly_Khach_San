
namespace Quan_Ly_Khach_San
{
    partial class Add_Customer_Form
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
            this.AddBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.CustomerAddress = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.CustomerIdentityTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.CustomerPhoneNumberTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.CustomerNameTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.CancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.CustomerNote = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BorderRadius = 15;
            this.AddBtn.CheckedState.Parent = this.AddBtn;
            this.AddBtn.CustomImages.Parent = this.AddBtn;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.DisabledState.Parent = this.AddBtn;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.HoverState.Parent = this.AddBtn;
            this.AddBtn.Location = new System.Drawing.Point(31, 470);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(147, 49);
            this.AddBtn.TabIndex = 20;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // siticoneHtmlLabel5
            // 
            this.siticoneHtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel5.ForeColor = System.Drawing.Color.DarkGray;
            this.siticoneHtmlLabel5.Location = new System.Drawing.Point(156, 296);
            this.siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            this.siticoneHtmlLabel5.Size = new System.Drawing.Size(75, 23);
            this.siticoneHtmlLabel5.TabIndex = 19;
            this.siticoneHtmlLabel5.Text = "Address :";
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
            this.CustomerAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.CustomerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerAddress.FocusedState.Parent = this.CustomerAddress;
            this.CustomerAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddress.ForeColor = System.Drawing.Color.White;
            this.CustomerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerAddress.HoverState.Parent = this.CustomerAddress;
            this.CustomerAddress.Location = new System.Drawing.Point(31, 325);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.PasswordChar = '\0';
            this.CustomerAddress.PlaceholderText = "Address";
            this.CustomerAddress.SelectedText = "";
            this.CustomerAddress.ShadowDecoration.Parent = this.CustomerAddress;
            this.CustomerAddress.Size = new System.Drawing.Size(323, 59);
            this.CustomerAddress.TabIndex = 18;
            this.CustomerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.CustomerIdentityTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.CustomerIdentityTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIdentityTxb.FocusedState.Parent = this.CustomerIdentityTxb;
            this.CustomerIdentityTxb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdentityTxb.ForeColor = System.Drawing.Color.White;
            this.CustomerIdentityTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerIdentityTxb.HoverState.Parent = this.CustomerIdentityTxb;
            this.CustomerIdentityTxb.Location = new System.Drawing.Point(57, 241);
            this.CustomerIdentityTxb.Name = "CustomerIdentityTxb";
            this.CustomerIdentityTxb.PasswordChar = '\0';
            this.CustomerIdentityTxb.PlaceholderText = "Identity Numbers";
            this.CustomerIdentityTxb.SelectedText = "";
            this.CustomerIdentityTxb.ShadowDecoration.Parent = this.CustomerIdentityTxb;
            this.CustomerIdentityTxb.Size = new System.Drawing.Size(270, 49);
            this.CustomerIdentityTxb.TabIndex = 17;
            this.CustomerIdentityTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerIdentityTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerIdentityTxb_KeyPress);
            // 
            // siticoneHtmlLabel4
            // 
            this.siticoneHtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.siticoneHtmlLabel4.Location = new System.Drawing.Point(156, 212);
            this.siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            this.siticoneHtmlLabel4.Size = new System.Drawing.Size(72, 23);
            this.siticoneHtmlLabel4.TabIndex = 16;
            this.siticoneHtmlLabel4.Text = "Identity :";
            // 
            // CustomerPhoneNumberTxb
            // 
            this.CustomerPhoneNumberTxb.BorderColor = System.Drawing.Color.White;
            this.CustomerPhoneNumberTxb.BorderRadius = 15;
            this.CustomerPhoneNumberTxb.BorderThickness = 2;
            this.CustomerPhoneNumberTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerPhoneNumberTxb.DefaultText = "";
            this.CustomerPhoneNumberTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerPhoneNumberTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerPhoneNumberTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerPhoneNumberTxb.DisabledState.Parent = this.CustomerPhoneNumberTxb;
            this.CustomerPhoneNumberTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerPhoneNumberTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.CustomerPhoneNumberTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerPhoneNumberTxb.FocusedState.Parent = this.CustomerPhoneNumberTxb;
            this.CustomerPhoneNumberTxb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneNumberTxb.ForeColor = System.Drawing.Color.White;
            this.CustomerPhoneNumberTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerPhoneNumberTxb.HoverState.Parent = this.CustomerPhoneNumberTxb;
            this.CustomerPhoneNumberTxb.Location = new System.Drawing.Point(57, 157);
            this.CustomerPhoneNumberTxb.Name = "CustomerPhoneNumberTxb";
            this.CustomerPhoneNumberTxb.PasswordChar = '\0';
            this.CustomerPhoneNumberTxb.PlaceholderText = "Phone Numbers";
            this.CustomerPhoneNumberTxb.SelectedText = "";
            this.CustomerPhoneNumberTxb.ShadowDecoration.Parent = this.CustomerPhoneNumberTxb;
            this.CustomerPhoneNumberTxb.Size = new System.Drawing.Size(270, 49);
            this.CustomerPhoneNumberTxb.TabIndex = 15;
            this.CustomerPhoneNumberTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerPhoneNumberTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerPhoneNumberTxb_KeyPress);
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(162, 128);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(61, 23);
            this.siticoneHtmlLabel3.TabIndex = 14;
            this.siticoneHtmlLabel3.Text = "Phone :";
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
            this.CustomerNameTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.CustomerNameTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxb.FocusedState.Parent = this.CustomerNameTxb;
            this.CustomerNameTxb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTxb.ForeColor = System.Drawing.Color.White;
            this.CustomerNameTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTxb.HoverState.Parent = this.CustomerNameTxb;
            this.CustomerNameTxb.Location = new System.Drawing.Point(31, 73);
            this.CustomerNameTxb.Name = "CustomerNameTxb";
            this.CustomerNameTxb.PasswordChar = '\0';
            this.CustomerNameTxb.PlaceholderText = "Name";
            this.CustomerNameTxb.SelectedText = "";
            this.CustomerNameTxb.ShadowDecoration.Parent = this.CustomerNameTxb;
            this.CustomerNameTxb.Size = new System.Drawing.Size(323, 49);
            this.CustomerNameTxb.TabIndex = 13;
            this.CustomerNameTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(163, 44);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(58, 23);
            this.siticoneHtmlLabel2.TabIndex = 12;
            this.siticoneHtmlLabel2.Text = "Name :";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.AutoSize = false;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.siticoneHtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(385, 38);
            this.siticoneHtmlLabel1.TabIndex = 21;
            this.siticoneHtmlLabel1.Text = "Customers List";
            this.siticoneHtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BorderRadius = 15;
            this.CancelBtn.CheckedState.Parent = this.CancelBtn;
            this.CancelBtn.CustomImages.Parent = this.CancelBtn;
            this.CancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBtn.DisabledState.Parent = this.CancelBtn;
            this.CancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.CancelBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.HoverState.Parent = this.CancelBtn;
            this.CancelBtn.Location = new System.Drawing.Point(207, 470);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.ShadowDecoration.Parent = this.CancelBtn;
            this.CancelBtn.Size = new System.Drawing.Size(147, 49);
            this.CancelBtn.TabIndex = 22;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CustomerNote
            // 
            this.CustomerNote.BorderColor = System.Drawing.Color.White;
            this.CustomerNote.BorderRadius = 15;
            this.CustomerNote.BorderThickness = 2;
            this.CustomerNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNote.DefaultText = "";
            this.CustomerNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNote.DisabledState.Parent = this.CustomerNote;
            this.CustomerNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.CustomerNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNote.FocusedState.Parent = this.CustomerNote;
            this.CustomerNote.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNote.ForeColor = System.Drawing.Color.White;
            this.CustomerNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNote.HoverState.Parent = this.CustomerNote;
            this.CustomerNote.Location = new System.Drawing.Point(31, 419);
            this.CustomerNote.Name = "CustomerNote";
            this.CustomerNote.PasswordChar = '\0';
            this.CustomerNote.PlaceholderText = "Address";
            this.CustomerNote.SelectedText = "";
            this.CustomerNote.ShadowDecoration.Parent = this.CustomerNote;
            this.CustomerNote.Size = new System.Drawing.Size(323, 45);
            this.CustomerNote.TabIndex = 23;
            this.CustomerNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel6.ForeColor = System.Drawing.Color.DarkGray;
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(163, 390);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(41, 23);
            this.siticoneHtmlLabel6.TabIndex = 24;
            this.siticoneHtmlLabel6.Text = "Note";
            // 
            // Add_Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(385, 531);
            this.Controls.Add(this.siticoneHtmlLabel6);
            this.Controls.Add(this.CustomerNote);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.siticoneHtmlLabel5);
            this.Controls.Add(this.CustomerAddress);
            this.Controls.Add(this.CustomerIdentityTxb);
            this.Controls.Add(this.siticoneHtmlLabel4);
            this.Controls.Add(this.CustomerPhoneNumberTxb);
            this.Controls.Add(this.siticoneHtmlLabel3);
            this.Controls.Add(this.CustomerNameTxb);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Customer_Form";
            this.Text = "Add_Customer_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton AddBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CustomerAddress;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CustomerIdentityTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CustomerPhoneNumberTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CustomerNameTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton CancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox CustomerNote;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
    }
}