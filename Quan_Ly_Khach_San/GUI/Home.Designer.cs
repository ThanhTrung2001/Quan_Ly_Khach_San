
namespace Quan_Ly_Khach_San
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.TopPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.MinimizeBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ExitBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.LeftPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.FoodBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ServiceBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.LogOutBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.StatisticBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.CustomerBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.RiskBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.RoomBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.LogoPb = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.ParentPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.TopPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.TopPanel.Controls.Add(this.MinimizeBtn);
            this.TopPanel.Controls.Add(this.ExitBtn);
            this.TopPanel.Location = new System.Drawing.Point(200, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(1000, 50);
            this.TopPanel.TabIndex = 0;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.CheckedState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.CustomImages.Parent = this.MinimizeBtn;
            this.MinimizeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinimizeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinimizeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinimizeBtn.DisabledState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.MinimizeBtn.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.MinimizeBtn.HoverState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Location = new System.Drawing.Point(910, 2);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.ShadowDecoration.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Size = new System.Drawing.Size(45, 45);
            this.MinimizeBtn.TabIndex = 3;
            this.MinimizeBtn.Text = "—";
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.DisabledState.Parent = this.ExitBtn;
            this.ExitBtn.FillColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.ExitBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Location = new System.Drawing.Point(955, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(45, 45);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.LeftPanel.Controls.Add(this.FoodBtn);
            this.LeftPanel.Controls.Add(this.ServiceBtn);
            this.LeftPanel.Controls.Add(this.LogOutBtn);
            this.LeftPanel.Controls.Add(this.StatisticBtn);
            this.LeftPanel.Controls.Add(this.CustomerBtn);
            this.LeftPanel.Controls.Add(this.RiskBtn);
            this.LeftPanel.Controls.Add(this.RoomBtn);
            this.LeftPanel.Controls.Add(this.LogoPb);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.ShadowDecoration.Parent = this.LeftPanel;
            this.LeftPanel.Size = new System.Drawing.Size(200, 700);
            this.LeftPanel.TabIndex = 1;
            // 
            // FoodBtn
            // 
            this.FoodBtn.BorderColor = System.Drawing.Color.Transparent;
            this.FoodBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.FoodBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.FoodBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.FoodBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.FoodBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.FoodBtn.CheckedState.Parent = this.FoodBtn;
            this.FoodBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.FoodBtn.CustomImages.Parent = this.FoodBtn;
            this.FoodBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FoodBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FoodBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FoodBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FoodBtn.DisabledState.Parent = this.FoodBtn;
            this.FoodBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.FoodBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodBtn.ForeColor = System.Drawing.Color.White;
            this.FoodBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.FoodBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.FoodBtn.HoverState.Parent = this.FoodBtn;
            this.FoodBtn.Image = ((System.Drawing.Image)(resources.GetObject("FoodBtn.Image")));
            this.FoodBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FoodBtn.ImageOffset = new System.Drawing.Point(15, 0);
            this.FoodBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.FoodBtn.Location = new System.Drawing.Point(2, 335);
            this.FoodBtn.Name = "FoodBtn";
            this.FoodBtn.ShadowDecoration.Parent = this.FoodBtn;
            this.FoodBtn.Size = new System.Drawing.Size(197, 60);
            this.FoodBtn.TabIndex = 2;
            this.FoodBtn.Text = "Food";
            this.FoodBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FoodBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.FoodBtn.Click += new System.EventHandler(this.FoodBtn_Click);
            // 
            // ServiceBtn
            // 
            this.ServiceBtn.BorderColor = System.Drawing.Color.Transparent;
            this.ServiceBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.ServiceBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.ServiceBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.ServiceBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.ServiceBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.ServiceBtn.CheckedState.Parent = this.ServiceBtn;
            this.ServiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServiceBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.ServiceBtn.CustomImages.Parent = this.ServiceBtn;
            this.ServiceBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ServiceBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ServiceBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ServiceBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ServiceBtn.DisabledState.Parent = this.ServiceBtn;
            this.ServiceBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.ServiceBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceBtn.ForeColor = System.Drawing.Color.White;
            this.ServiceBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.ServiceBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.ServiceBtn.HoverState.Parent = this.ServiceBtn;
            this.ServiceBtn.Image = ((System.Drawing.Image)(resources.GetObject("ServiceBtn.Image")));
            this.ServiceBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ServiceBtn.ImageOffset = new System.Drawing.Point(15, 0);
            this.ServiceBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.ServiceBtn.Location = new System.Drawing.Point(2, 275);
            this.ServiceBtn.Name = "ServiceBtn";
            this.ServiceBtn.ShadowDecoration.Parent = this.ServiceBtn;
            this.ServiceBtn.Size = new System.Drawing.Size(197, 60);
            this.ServiceBtn.TabIndex = 7;
            this.ServiceBtn.Text = "Service";
            this.ServiceBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ServiceBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.ServiceBtn.Click += new System.EventHandler(this.ServiceBtn_Click_1);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BorderColor = System.Drawing.Color.Transparent;
            this.LogOutBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.LogOutBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.LogOutBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.LogOutBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.LogOutBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.LogOutBtn.CheckedState.Parent = this.LogOutBtn;
            this.LogOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.LogOutBtn.CustomImages.Parent = this.LogOutBtn;
            this.LogOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogOutBtn.DisabledState.Parent = this.LogOutBtn;
            this.LogOutBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.LogOutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.LogOutBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.HoverState.Parent = this.LogOutBtn;
            this.LogOutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogOutBtn.Image")));
            this.LogOutBtn.ImageSize = new System.Drawing.Size(80, 80);
            this.LogOutBtn.Location = new System.Drawing.Point(2, 592);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.ShadowDecoration.Parent = this.LogOutBtn;
            this.LogOutBtn.Size = new System.Drawing.Size(197, 105);
            this.LogOutBtn.TabIndex = 6;
            this.LogOutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogOutBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // StatisticBtn
            // 
            this.StatisticBtn.BorderColor = System.Drawing.Color.Transparent;
            this.StatisticBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.StatisticBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.StatisticBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.StatisticBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.StatisticBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.StatisticBtn.CheckedState.Parent = this.StatisticBtn;
            this.StatisticBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatisticBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.StatisticBtn.CustomImages.Parent = this.StatisticBtn;
            this.StatisticBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StatisticBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StatisticBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StatisticBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StatisticBtn.DisabledState.Parent = this.StatisticBtn;
            this.StatisticBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.StatisticBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticBtn.ForeColor = System.Drawing.Color.White;
            this.StatisticBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.StatisticBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.StatisticBtn.HoverState.Parent = this.StatisticBtn;
            this.StatisticBtn.Image = ((System.Drawing.Image)(resources.GetObject("StatisticBtn.Image")));
            this.StatisticBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StatisticBtn.ImageOffset = new System.Drawing.Point(15, 0);
            this.StatisticBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.StatisticBtn.Location = new System.Drawing.Point(2, 515);
            this.StatisticBtn.Name = "StatisticBtn";
            this.StatisticBtn.ShadowDecoration.Parent = this.StatisticBtn;
            this.StatisticBtn.Size = new System.Drawing.Size(197, 60);
            this.StatisticBtn.TabIndex = 5;
            this.StatisticBtn.Text = "Statistic";
            this.StatisticBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StatisticBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.StatisticBtn.Click += new System.EventHandler(this.StatisticBtn_Click);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.BorderColor = System.Drawing.Color.Transparent;
            this.CustomerBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.CustomerBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.CustomerBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.CustomerBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.CustomerBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.CustomerBtn.CheckedState.Parent = this.CustomerBtn;
            this.CustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomerBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.CustomerBtn.CustomImages.Parent = this.CustomerBtn;
            this.CustomerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomerBtn.DisabledState.Parent = this.CustomerBtn;
            this.CustomerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.CustomerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.ForeColor = System.Drawing.Color.White;
            this.CustomerBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.CustomerBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.CustomerBtn.HoverState.Parent = this.CustomerBtn;
            this.CustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustomerBtn.Image")));
            this.CustomerBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerBtn.ImageOffset = new System.Drawing.Point(15, 0);
            this.CustomerBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.CustomerBtn.Location = new System.Drawing.Point(2, 455);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.ShadowDecoration.Parent = this.CustomerBtn;
            this.CustomerBtn.Size = new System.Drawing.Size(197, 60);
            this.CustomerBtn.TabIndex = 4;
            this.CustomerBtn.Text = "Customer";
            this.CustomerBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CustomerBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // RiskBtn
            // 
            this.RiskBtn.BorderColor = System.Drawing.Color.Transparent;
            this.RiskBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.RiskBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.RiskBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.RiskBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.RiskBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.RiskBtn.CheckedState.Parent = this.RiskBtn;
            this.RiskBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RiskBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.RiskBtn.CustomImages.Parent = this.RiskBtn;
            this.RiskBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RiskBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RiskBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RiskBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RiskBtn.DisabledState.Parent = this.RiskBtn;
            this.RiskBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.RiskBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiskBtn.ForeColor = System.Drawing.Color.White;
            this.RiskBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.RiskBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.RiskBtn.HoverState.Parent = this.RiskBtn;
            this.RiskBtn.Image = ((System.Drawing.Image)(resources.GetObject("RiskBtn.Image")));
            this.RiskBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RiskBtn.ImageOffset = new System.Drawing.Point(15, 0);
            this.RiskBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.RiskBtn.Location = new System.Drawing.Point(2, 395);
            this.RiskBtn.Name = "RiskBtn";
            this.RiskBtn.ShadowDecoration.Parent = this.RiskBtn;
            this.RiskBtn.Size = new System.Drawing.Size(197, 60);
            this.RiskBtn.TabIndex = 3;
            this.RiskBtn.Text = "Risk";
            this.RiskBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RiskBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.RiskBtn.Click += new System.EventHandler(this.RiskBtn_Click);
            // 
            // RoomBtn
            // 
            this.RoomBtn.BorderColor = System.Drawing.Color.Transparent;
            this.RoomBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.RoomBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.RoomBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.RoomBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.RoomBtn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.RoomBtn.CheckedState.Parent = this.RoomBtn;
            this.RoomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoomBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.RoomBtn.CustomImages.Parent = this.RoomBtn;
            this.RoomBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RoomBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RoomBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RoomBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RoomBtn.DisabledState.Parent = this.RoomBtn;
            this.RoomBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.RoomBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomBtn.ForeColor = System.Drawing.Color.White;
            this.RoomBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.RoomBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.RoomBtn.HoverState.Parent = this.RoomBtn;
            this.RoomBtn.Image = ((System.Drawing.Image)(resources.GetObject("RoomBtn.Image")));
            this.RoomBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RoomBtn.ImageOffset = new System.Drawing.Point(15, 0);
            this.RoomBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.RoomBtn.Location = new System.Drawing.Point(2, 215);
            this.RoomBtn.Name = "RoomBtn";
            this.RoomBtn.ShadowDecoration.Parent = this.RoomBtn;
            this.RoomBtn.Size = new System.Drawing.Size(197, 60);
            this.RoomBtn.TabIndex = 1;
            this.RoomBtn.Text = "Room";
            this.RoomBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RoomBtn.TextOffset = new System.Drawing.Point(30, 0);
            this.RoomBtn.Click += new System.EventHandler(this.ServiceBtn_Click);
            // 
            // LogoPb
            // 
            this.LogoPb.BackColor = System.Drawing.Color.Transparent;
            this.LogoPb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPb.BackgroundImage")));
            this.LogoPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPb.FillColor = System.Drawing.Color.Transparent;
            this.LogoPb.ImageRotate = 0F;
            this.LogoPb.Location = new System.Drawing.Point(0, 2);
            this.LogoPb.Name = "LogoPb";
            this.LogoPb.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.LogoPb.ShadowDecoration.Parent = this.LogoPb;
            this.LogoPb.Size = new System.Drawing.Size(200, 200);
            this.LogoPb.TabIndex = 0;
            this.LogoPb.TabStop = false;
            // 
            // ParentPanel
            // 
            this.ParentPanel.Location = new System.Drawing.Point(200, 50);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.ShadowDecoration.Parent = this.ParentPanel;
            this.ParentPanel.Size = new System.Drawing.Size(1000, 650);
            this.ParentPanel.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.TopPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel TopPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel LeftPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox LogoPb;
        private Siticone.Desktop.UI.WinForms.SiticoneButton MinimizeBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ExitBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton CustomerBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RiskBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton FoodBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton RoomBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton StatisticBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton LogOutBtn;
        private Siticone.Desktop.UI.WinForms.SiticonePanel ParentPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ServiceBtn;
    }
}