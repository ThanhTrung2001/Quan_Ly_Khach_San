namespace Quan_Ly_Khach_San.GUI
{
    partial class Add_DVT_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UnitNameTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.UnitIDTxb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.AddBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
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
            this.BackBtn.Location = new System.Drawing.Point(28, 22);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(35, 36);
            this.BackBtn.TabIndex = 136;
            this.BackBtn.Text = "<";
            this.BackBtn.TextOffset = new System.Drawing.Point(1, -2);
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.siticoneHtmlLabel1.TabIndex = 135;
            this.siticoneHtmlLabel1.Text = "UNIT";
            this.siticoneHtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 140;
            this.label2.Text = "NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 139;
            this.label1.Text = "ID :";
            // 
            // UnitNameTxb
            // 
            this.UnitNameTxb.BorderColor = System.Drawing.Color.White;
            this.UnitNameTxb.BorderRadius = 15;
            this.UnitNameTxb.BorderThickness = 2;
            this.UnitNameTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnitNameTxb.DefaultText = "";
            this.UnitNameTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UnitNameTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UnitNameTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnitNameTxb.DisabledState.Parent = this.UnitNameTxb;
            this.UnitNameTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnitNameTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.UnitNameTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnitNameTxb.FocusedState.Parent = this.UnitNameTxb;
            this.UnitNameTxb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitNameTxb.ForeColor = System.Drawing.Color.White;
            this.UnitNameTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnitNameTxb.HoverState.Parent = this.UnitNameTxb;
            this.UnitNameTxb.Location = new System.Drawing.Point(102, 150);
            this.UnitNameTxb.Name = "UnitNameTxb";
            this.UnitNameTxb.PasswordChar = '\0';
            this.UnitNameTxb.PlaceholderText = "Name";
            this.UnitNameTxb.SelectedText = "";
            this.UnitNameTxb.ShadowDecoration.Parent = this.UnitNameTxb;
            this.UnitNameTxb.Size = new System.Drawing.Size(261, 49);
            this.UnitNameTxb.TabIndex = 138;
            this.UnitNameTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitNameTxb.TextChanged += new System.EventHandler(this.UnitNameTxb_TextChanged);
            // 
            // UnitIDTxb
            // 
            this.UnitIDTxb.BorderColor = System.Drawing.Color.White;
            this.UnitIDTxb.BorderRadius = 15;
            this.UnitIDTxb.BorderThickness = 2;
            this.UnitIDTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnitIDTxb.DefaultText = "";
            this.UnitIDTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UnitIDTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UnitIDTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnitIDTxb.DisabledState.Parent = this.UnitIDTxb;
            this.UnitIDTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnitIDTxb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.UnitIDTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnitIDTxb.FocusedState.Parent = this.UnitIDTxb;
            this.UnitIDTxb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitIDTxb.ForeColor = System.Drawing.Color.White;
            this.UnitIDTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnitIDTxb.HoverState.Parent = this.UnitIDTxb;
            this.UnitIDTxb.Location = new System.Drawing.Point(102, 95);
            this.UnitIDTxb.Name = "UnitIDTxb";
            this.UnitIDTxb.PasswordChar = '\0';
            this.UnitIDTxb.PlaceholderText = "Id";
            this.UnitIDTxb.SelectedText = "";
            this.UnitIDTxb.ShadowDecoration.Parent = this.UnitIDTxb;
            this.UnitIDTxb.Size = new System.Drawing.Size(261, 49);
            this.UnitIDTxb.TabIndex = 137;
            this.UnitIDTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.AddBtn.Location = new System.Drawing.Point(216, 217);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(147, 49);
            this.AddBtn.TabIndex = 141;
            this.AddBtn.Text = "ADD";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Add_DVT_Form
            // 
            this.AcceptButton = this.AddBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.CancelButton = this.BackBtn;
            this.ClientSize = new System.Drawing.Size(385, 288);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnitNameTxb);
            this.Controls.Add(this.UnitIDTxb);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_DVT_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_DVT_Form";
            this.Load += new System.EventHandler(this.Add_DVT_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton BackBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox UnitNameTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox UnitIDTxb;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton AddBtn;
    }
}