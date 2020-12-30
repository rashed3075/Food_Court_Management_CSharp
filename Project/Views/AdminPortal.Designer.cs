namespace Project.Views
{
    partial class AdminPortal
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
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.WelcomeBox = new System.Windows.Forms.Label();
            this.RM = new System.Windows.Forms.Button();
            this.eManagement = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.foodMenu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(865, 542);
            this.webBrowser1.TabIndex = 0;
            // 
            // WelcomeBox
            // 
            this.WelcomeBox.AutoSize = true;
            this.WelcomeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBox.Location = new System.Drawing.Point(496, 9);
            this.WelcomeBox.Name = "WelcomeBox";
            this.WelcomeBox.Size = new System.Drawing.Size(344, 29);
            this.WelcomeBox.TabIndex = 1;
            this.WelcomeBox.Text = "Welcome Rashedul Rabby";
            // 
            // RM
            // 
            this.RM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RM.Location = new System.Drawing.Point(32, 95);
            this.RM.Name = "RM";
            this.RM.Size = new System.Drawing.Size(114, 72);
            this.RM.TabIndex = 2;
            this.RM.Text = "Restaurant Management";
            this.RM.UseVisualStyleBackColor = false;
            this.RM.Click += new System.EventHandler(this.RM_Click);
            // 
            // eManagement
            // 
            this.eManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eManagement.Location = new System.Drawing.Point(283, 95);
            this.eManagement.Name = "eManagement";
            this.eManagement.Size = new System.Drawing.Size(114, 72);
            this.eManagement.TabIndex = 3;
            this.eManagement.Text = "Employee Management";
            this.eManagement.UseVisualStyleBackColor = false;
            this.eManagement.Click += new System.EventHandler(this.emClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // foodMenu
            // 
            this.foodMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.foodMenu.Location = new System.Drawing.Point(572, 95);
            this.foodMenu.Name = "foodMenu";
            this.foodMenu.Size = new System.Drawing.Size(114, 72);
            this.foodMenu.TabIndex = 4;
            this.foodMenu.Text = "Food Menu";
            this.foodMenu.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(32, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 72);
            this.button3.TabIndex = 5;
            this.button3.Text = "Search Other Admin";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(572, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 72);
            this.button4.TabIndex = 6;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(283, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 72);
            this.button5.TabIndex = 7;
            this.button5.Text = "Delete Your  Account";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 542);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.foodMenu);
            this.Controls.Add(this.eManagement);
            this.Controls.Add(this.RM);
            this.Controls.Add(this.WelcomeBox);
            this.Controls.Add(this.webBrowser1);
            this.Name = "AdminPortal";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label WelcomeBox;
        private System.Windows.Forms.Button RM;
        private System.Windows.Forms.Button eManagement;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button foodMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}