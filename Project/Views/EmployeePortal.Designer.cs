namespace Project.Views
{
    partial class EmployeePortal
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
            this.cManagement = new System.Windows.Forms.Button();
            this.addDiscount = new System.Windows.Forms.Button();
            this.editDiscount = new System.Windows.Forms.Button();
            this.deliverOrder = new System.Windows.Forms.Button();
            this.WelcomeBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cManagement
            // 
            this.cManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cManagement.Location = new System.Drawing.Point(142, 96);
            this.cManagement.Name = "cManagement";
            this.cManagement.Size = new System.Drawing.Size(114, 72);
            this.cManagement.TabIndex = 4;
            this.cManagement.Text = "Customer Management";
            this.cManagement.UseVisualStyleBackColor = false;
            this.cManagement.Click += new System.EventHandler(this.cManagement_Click);
            // 
            // addDiscount
            // 
            this.addDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addDiscount.Location = new System.Drawing.Point(534, 336);
            this.addDiscount.Name = "addDiscount";
            this.addDiscount.Size = new System.Drawing.Size(114, 72);
            this.addDiscount.TabIndex = 5;
            this.addDiscount.Text = "Add Discount";
            this.addDiscount.UseVisualStyleBackColor = false;
            this.addDiscount.Click += new System.EventHandler(this.addDiscount_Click);
            // 
            // editDiscount
            // 
            this.editDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editDiscount.Location = new System.Drawing.Point(142, 336);
            this.editDiscount.Name = "editDiscount";
            this.editDiscount.Size = new System.Drawing.Size(114, 72);
            this.editDiscount.TabIndex = 6;
            this.editDiscount.Text = "Log out";
            this.editDiscount.UseVisualStyleBackColor = false;
            this.editDiscount.Click += new System.EventHandler(this.editDiscount_Click);
            // 
            // deliverOrder
            // 
            this.deliverOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deliverOrder.Location = new System.Drawing.Point(534, 96);
            this.deliverOrder.Name = "deliverOrder";
            this.deliverOrder.Size = new System.Drawing.Size(114, 72);
            this.deliverOrder.TabIndex = 8;
            this.deliverOrder.Text = "Order History";
            this.deliverOrder.UseVisualStyleBackColor = false;
            this.deliverOrder.Click += new System.EventHandler(this.deliverOrder_Click);
            // 
            // WelcomeBox
            // 
            this.WelcomeBox.AutoSize = true;
            this.WelcomeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBox.Location = new System.Drawing.Point(442, 9);
            this.WelcomeBox.Name = "WelcomeBox";
            this.WelcomeBox.Size = new System.Drawing.Size(344, 29);
            this.WelcomeBox.TabIndex = 9;
            this.WelcomeBox.Text = "Welcome Rashedul Rabby";
            // 
            // EmployeePortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.tech_background_image_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 517);
            this.Controls.Add(this.WelcomeBox);
            this.Controls.Add(this.deliverOrder);
            this.Controls.Add(this.editDiscount);
            this.Controls.Add(this.addDiscount);
            this.Controls.Add(this.cManagement);
            this.Name = "EmployeePortal";
            this.Text = "EmployeePortal";
            this.Load += new System.EventHandler(this.EmployeePortal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cManagement;
        private System.Windows.Forms.Button addDiscount;
        private System.Windows.Forms.Button editDiscount;
        private System.Windows.Forms.Button deliverOrder;
        private System.Windows.Forms.Label WelcomeBox;
    }
}