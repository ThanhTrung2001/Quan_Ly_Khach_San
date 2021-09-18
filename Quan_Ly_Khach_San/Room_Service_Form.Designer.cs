
namespace Quan_Ly_Khach_San
{
    partial class Room_Service_Form
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
            this.ServiceTabManage = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.RoomTab = new System.Windows.Forms.TabPage();
            this.ServiceTab = new System.Windows.Forms.TabPage();
            this.RequestTab = new System.Windows.Forms.TabPage();
            this.ServiceTabManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiceTabManage
            // 
            this.ServiceTabManage.Controls.Add(this.RoomTab);
            this.ServiceTabManage.Controls.Add(this.ServiceTab);
            this.ServiceTabManage.Controls.Add(this.RequestTab);
            this.ServiceTabManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceTabManage.ItemSize = new System.Drawing.Size(180, 40);
            this.ServiceTabManage.Location = new System.Drawing.Point(0, 0);
            this.ServiceTabManage.Name = "ServiceTabManage";
            this.ServiceTabManage.SelectedIndex = 0;
            this.ServiceTabManage.Size = new System.Drawing.Size(1000, 650);
            this.ServiceTabManage.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.ServiceTabManage.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(55)))));
            this.ServiceTabManage.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ServiceTabManage.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.ServiceTabManage.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.ServiceTabManage.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.ServiceTabManage.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.ServiceTabManage.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ServiceTabManage.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.ServiceTabManage.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ServiceTabManage.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.ServiceTabManage.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.ServiceTabManage.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.ServiceTabManage.TabButtonSelectedState.ForeColor = System.Drawing.Color.Cyan;
            this.ServiceTabManage.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.ServiceTabManage.TabButtonSize = new System.Drawing.Size(180, 40);
            this.ServiceTabManage.TabIndex = 0;
            this.ServiceTabManage.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.ServiceTabManage.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // RoomTab
            // 
            this.RoomTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.RoomTab.Location = new System.Drawing.Point(4, 44);
            this.RoomTab.Name = "RoomTab";
            this.RoomTab.Padding = new System.Windows.Forms.Padding(3);
            this.RoomTab.Size = new System.Drawing.Size(992, 602);
            this.RoomTab.TabIndex = 0;
            this.RoomTab.Text = "ROOM";
            // 
            // ServiceTab
            // 
            this.ServiceTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.ServiceTab.Location = new System.Drawing.Point(4, 44);
            this.ServiceTab.Name = "ServiceTab";
            this.ServiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceTab.Size = new System.Drawing.Size(992, 602);
            this.ServiceTab.TabIndex = 1;
            this.ServiceTab.Text = "SERVICE";
            // 
            // RequestTab
            // 
            this.RequestTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.RequestTab.Location = new System.Drawing.Point(4, 44);
            this.RequestTab.Name = "RequestTab";
            this.RequestTab.Padding = new System.Windows.Forms.Padding(3);
            this.RequestTab.Size = new System.Drawing.Size(992, 602);
            this.RequestTab.TabIndex = 2;
            this.RequestTab.Text = "REQUEST";
            // 
            // Room_Service_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.ServiceTabManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room_Service_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room_Service_Form";
            this.ServiceTabManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl ServiceTabManage;
        private System.Windows.Forms.TabPage RoomTab;
        private System.Windows.Forms.TabPage ServiceTab;
        private System.Windows.Forms.TabPage RequestTab;
    }
}