namespace Quan_Ly_Khach_San.GUI
{
    partial class Add_Ingredient_Form
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
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.IngredientIDtxt = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.IngredientUnittxt = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.IngredientAmounttxt = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.IngredientPricetxt = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.IngredientStyletxt = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.IngredientNametxt = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.CancelBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.AddBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.SuspendLayout();
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
            this.siticoneHtmlLabel1.TabIndex = 36;
            this.siticoneHtmlLabel1.Text = "Ingredient";
            this.siticoneHtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(174, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 21);
            this.label12.TabIndex = 97;
            this.label12.Text = "ID :";
            // 
            // IngredientIDtxt
            // 
            this.IngredientIDtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IngredientIDtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.IngredientIDtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientIDtxt.BorderColor = System.Drawing.Color.White;
            this.IngredientIDtxt.BorderRadius = 10;
            this.IngredientIDtxt.BorderThickness = 2;
            this.IngredientIDtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IngredientIDtxt.DefaultText = "";
            this.IngredientIDtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IngredientIDtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IngredientIDtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IngredientIDtxt.DisabledState.Parent = this.IngredientIDtxt;
            this.IngredientIDtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IngredientIDtxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientIDtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientIDtxt.FocusedState.Parent = this.IngredientIDtxt;
            this.IngredientIDtxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientIDtxt.ForeColor = System.Drawing.Color.White;
            this.IngredientIDtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientIDtxt.HoverState.Parent = this.IngredientIDtxt;
            this.IngredientIDtxt.Location = new System.Drawing.Point(92, 78);
            this.IngredientIDtxt.Name = "IngredientIDtxt";
            this.IngredientIDtxt.PasswordChar = '\0';
            this.IngredientIDtxt.PlaceholderText = "Should\'t enter when you add new";
            this.IngredientIDtxt.SelectedText = "";
            this.IngredientIDtxt.ShadowDecoration.Parent = this.IngredientIDtxt;
            this.IngredientIDtxt.Size = new System.Drawing.Size(200, 49);
            this.IngredientIDtxt.TabIndex = 98;
            this.IngredientIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.DarkGray;
            this.label16.Location = new System.Drawing.Point(162, 391);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 21);
            this.label16.TabIndex = 113;
            this.label16.Text = "Price :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(152, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 21);
            this.label15.TabIndex = 112;
            this.label15.Text = "Amount :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(164, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 21);
            this.label14.TabIndex = 111;
            this.label14.Text = "Type :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(160, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 21);
            this.label13.TabIndex = 110;
            this.label13.Text = "Name :";
            // 
            // IngredientUnittxt
            // 
            this.IngredientUnittxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientUnittxt.BorderRadius = 10;
            this.IngredientUnittxt.BorderThickness = 2;
            this.IngredientUnittxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IngredientUnittxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IngredientUnittxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientUnittxt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientUnittxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientUnittxt.FocusedState.Parent = this.IngredientUnittxt;
            this.IngredientUnittxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientUnittxt.ForeColor = System.Drawing.Color.White;
            this.IngredientUnittxt.HoverState.Parent = this.IngredientUnittxt;
            this.IngredientUnittxt.ItemHeight = 30;
            this.IngredientUnittxt.ItemsAppearance.Parent = this.IngredientUnittxt;
            this.IngredientUnittxt.Location = new System.Drawing.Point(211, 253);
            this.IngredientUnittxt.Name = "IngredientUnittxt";
            this.IngredientUnittxt.ShadowDecoration.Parent = this.IngredientUnittxt;
            this.IngredientUnittxt.Size = new System.Drawing.Size(77, 36);
            this.IngredientUnittxt.TabIndex = 104;
            // 
            // IngredientAmounttxt
            // 
            this.IngredientAmounttxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientAmounttxt.BorderColor = System.Drawing.Color.White;
            this.IngredientAmounttxt.BorderRadius = 10;
            this.IngredientAmounttxt.BorderThickness = 2;
            this.IngredientAmounttxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IngredientAmounttxt.DefaultText = "";
            this.IngredientAmounttxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IngredientAmounttxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IngredientAmounttxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IngredientAmounttxt.DisabledState.Parent = this.IngredientAmounttxt;
            this.IngredientAmounttxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IngredientAmounttxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientAmounttxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientAmounttxt.FocusedState.Parent = this.IngredientAmounttxt;
            this.IngredientAmounttxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientAmounttxt.ForeColor = System.Drawing.Color.White;
            this.IngredientAmounttxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientAmounttxt.HoverState.Parent = this.IngredientAmounttxt;
            this.IngredientAmounttxt.Location = new System.Drawing.Point(138, 327);
            this.IngredientAmounttxt.Name = "IngredientAmounttxt";
            this.IngredientAmounttxt.PasswordChar = '\0';
            this.IngredientAmounttxt.PlaceholderText = "Amount";
            this.IngredientAmounttxt.SelectedText = "";
            this.IngredientAmounttxt.ShadowDecoration.Parent = this.IngredientAmounttxt;
            this.IngredientAmounttxt.Size = new System.Drawing.Size(109, 49);
            this.IngredientAmounttxt.TabIndex = 105;
            this.IngredientAmounttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IngredientPricetxt
            // 
            this.IngredientPricetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientPricetxt.BorderColor = System.Drawing.Color.White;
            this.IngredientPricetxt.BorderRadius = 10;
            this.IngredientPricetxt.BorderThickness = 2;
            this.IngredientPricetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IngredientPricetxt.DefaultText = "";
            this.IngredientPricetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IngredientPricetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IngredientPricetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IngredientPricetxt.DisabledState.Parent = this.IngredientPricetxt;
            this.IngredientPricetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IngredientPricetxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientPricetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientPricetxt.FocusedState.Parent = this.IngredientPricetxt;
            this.IngredientPricetxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientPricetxt.ForeColor = System.Drawing.Color.White;
            this.IngredientPricetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientPricetxt.HoverState.Parent = this.IngredientPricetxt;
            this.IngredientPricetxt.Location = new System.Drawing.Point(138, 415);
            this.IngredientPricetxt.Name = "IngredientPricetxt";
            this.IngredientPricetxt.PasswordChar = '\0';
            this.IngredientPricetxt.PlaceholderText = "Price";
            this.IngredientPricetxt.SelectedText = "";
            this.IngredientPricetxt.ShadowDecoration.Parent = this.IngredientPricetxt;
            this.IngredientPricetxt.Size = new System.Drawing.Size(109, 49);
            this.IngredientPricetxt.TabIndex = 106;
            this.IngredientPricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IngredientStyletxt
            // 
            this.IngredientStyletxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientStyletxt.BorderRadius = 10;
            this.IngredientStyletxt.BorderThickness = 2;
            this.IngredientStyletxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IngredientStyletxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IngredientStyletxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientStyletxt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientStyletxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientStyletxt.FocusedState.Parent = this.IngredientStyletxt;
            this.IngredientStyletxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientStyletxt.ForeColor = System.Drawing.Color.White;
            this.IngredientStyletxt.HoverState.Parent = this.IngredientStyletxt;
            this.IngredientStyletxt.ItemHeight = 30;
            this.IngredientStyletxt.ItemsAppearance.Parent = this.IngredientStyletxt;
            this.IngredientStyletxt.Location = new System.Drawing.Point(96, 253);
            this.IngredientStyletxt.Name = "IngredientStyletxt";
            this.IngredientStyletxt.ShadowDecoration.Parent = this.IngredientStyletxt;
            this.IngredientStyletxt.Size = new System.Drawing.Size(109, 36);
            this.IngredientStyletxt.TabIndex = 103;
            // 
            // IngredientNametxt
            // 
            this.IngredientNametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientNametxt.BorderColor = System.Drawing.Color.White;
            this.IngredientNametxt.BorderRadius = 10;
            this.IngredientNametxt.BorderThickness = 2;
            this.IngredientNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IngredientNametxt.DefaultText = "";
            this.IngredientNametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IngredientNametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IngredientNametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IngredientNametxt.DisabledState.Parent = this.IngredientNametxt;
            this.IngredientNametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IngredientNametxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.IngredientNametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientNametxt.FocusedState.Parent = this.IngredientNametxt;
            this.IngredientNametxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientNametxt.ForeColor = System.Drawing.Color.White;
            this.IngredientNametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngredientNametxt.HoverState.Parent = this.IngredientNametxt;
            this.IngredientNametxt.Location = new System.Drawing.Point(32, 167);
            this.IngredientNametxt.Name = "IngredientNametxt";
            this.IngredientNametxt.PasswordChar = '\0';
            this.IngredientNametxt.PlaceholderText = "Name";
            this.IngredientNametxt.SelectedText = "";
            this.IngredientNametxt.ShadowDecoration.Parent = this.IngredientNametxt;
            this.IngredientNametxt.Size = new System.Drawing.Size(323, 49);
            this.IngredientNametxt.TabIndex = 102;
            this.IngredientNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.CancelBtn.Location = new System.Drawing.Point(208, 470);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.ShadowDecoration.Parent = this.CancelBtn;
            this.CancelBtn.Size = new System.Drawing.Size(147, 49);
            this.CancelBtn.TabIndex = 115;
            this.CancelBtn.Text = "Cancel";
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
            this.AddBtn.Location = new System.Drawing.Point(32, 470);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(147, 49);
            this.AddBtn.TabIndex = 114;
            this.AddBtn.Text = "Add";
            // 
            // Add_Ingredient_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(385, 531);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.IngredientUnittxt);
            this.Controls.Add(this.IngredientAmounttxt);
            this.Controls.Add(this.IngredientPricetxt);
            this.Controls.Add(this.IngredientStyletxt);
            this.Controls.Add(this.IngredientNametxt);
            this.Controls.Add(this.IngredientIDtxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Ingredient_Form";
            this.Text = "Add_Ingredient_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private System.Windows.Forms.Label label12;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox IngredientIDtxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox IngredientUnittxt;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox IngredientAmounttxt;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox IngredientPricetxt;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox IngredientStyletxt;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox IngredientNametxt;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton CancelBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton AddBtn;
    }
}