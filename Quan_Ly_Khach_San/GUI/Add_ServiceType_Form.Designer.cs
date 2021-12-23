namespace Quan_Ly_Khach_San.GUI
{
    partial class Add_ServiceType_Form
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
            this.BackBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.AddBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeNameTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TypeIDTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BorderColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderThickness = 2;
            this.BackBtn.CheckedState.Parent = this.BackBtn;
            this.BackBtn.CustomImages.Parent = this.BackBtn;
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.DisabledState.Parent = this.BackBtn;
            this.BackBtn.FillColor = System.Drawing.Color.Gold;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.BackBtn.HoverState.Parent = this.BackBtn;
            this.BackBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.BackBtn.Location = new System.Drawing.Point(37, 30);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(35, 36);
            this.BackBtn.TabIndex = 140;
            this.BackBtn.Text = "<";
            this.BackBtn.TextOffset = new System.Drawing.Point(1, -2);
            this.BackBtn.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.AutoSize = false;
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.siticoneHtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(385, 76);
            this.siticoneHtmlLabel1.TabIndex = 139;
            this.siticoneHtmlLabel1.Text = "SERVICE TYPE";
            this.siticoneHtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.AddBtn.FillColor = System.Drawing.Color.Gold;
            this.AddBtn.FillColor2 = System.Drawing.Color.Gold;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.AddBtn.HoverState.Parent = this.AddBtn;
            this.AddBtn.Location = new System.Drawing.Point(226, 220);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(147, 49);
            this.AddBtn.TabIndex = 151;
            this.AddBtn.Text = "ADD";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 150;
            this.label2.Text = "NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 149;
            this.label1.Text = "ID :";
            // 
            // TypeNameTxb
            // 
            this.TypeNameTxb.BorderColor = System.Drawing.Color.White;
            this.TypeNameTxb.BorderRadius = 15;
            this.TypeNameTxb.BorderThickness = 2;
            this.TypeNameTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypeNameTxb.DefaultText = "";
            this.TypeNameTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TypeNameTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TypeNameTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TypeNameTxb.DisabledState.Parent = this.TypeNameTxb;
            this.TypeNameTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TypeNameTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.TypeNameTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeNameTxb.FocusedState.Parent = this.TypeNameTxb;
            this.TypeNameTxb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeNameTxb.ForeColor = System.Drawing.Color.White;
            this.TypeNameTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeNameTxb.HoverState.Parent = this.TypeNameTxb;
            this.TypeNameTxb.Location = new System.Drawing.Point(112, 153);
            this.TypeNameTxb.Name = "TypeNameTxb";
            this.TypeNameTxb.PasswordChar = '\0';
            this.TypeNameTxb.PlaceholderText = "Name";
            this.TypeNameTxb.SelectedText = "";
            this.TypeNameTxb.ShadowDecoration.Parent = this.TypeNameTxb;
            this.TypeNameTxb.Size = new System.Drawing.Size(261, 49);
            this.TypeNameTxb.TabIndex = 148;
            this.TypeNameTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TypeIDTxb
            // 
            this.TypeIDTxb.BorderColor = System.Drawing.Color.White;
            this.TypeIDTxb.BorderRadius = 15;
            this.TypeIDTxb.BorderThickness = 2;
            this.TypeIDTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypeIDTxb.DefaultText = "";
            this.TypeIDTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TypeIDTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TypeIDTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TypeIDTxb.DisabledState.Parent = this.TypeIDTxb;
            this.TypeIDTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TypeIDTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.TypeIDTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeIDTxb.FocusedState.Parent = this.TypeIDTxb;
            this.TypeIDTxb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeIDTxb.ForeColor = System.Drawing.Color.White;
            this.TypeIDTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeIDTxb.HoverState.Parent = this.TypeIDTxb;
            this.TypeIDTxb.Location = new System.Drawing.Point(112, 98);
            this.TypeIDTxb.Name = "TypeIDTxb";
            this.TypeIDTxb.PasswordChar = '\0';
            this.TypeIDTxb.PlaceholderText = "Id";
            this.TypeIDTxb.SelectedText = "";
            this.TypeIDTxb.ShadowDecoration.Parent = this.TypeIDTxb;
            this.TypeIDTxb.Size = new System.Drawing.Size(261, 49);
            this.TypeIDTxb.TabIndex = 147;
            this.TypeIDTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Add_ServiceType_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(385, 291);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeNameTxb);
            this.Controls.Add(this.TypeIDTxb);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_ServiceType_Form";
            this.Text = "Add_ServiceType_Form";
            this.Load += new System.EventHandler(this.Add_FoodType_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton BackBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton AddBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TypeNameTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TypeIDTxb;
    }
}