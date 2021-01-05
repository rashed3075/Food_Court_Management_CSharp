namespace Project.Views
{
    partial class CustomerManagement
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
            this.updateCustomer = new System.Windows.Forms.Button();
            this.showCustomer = new System.Windows.Forms.Button();
            this.findCustomer = new System.Windows.Forms.Button();
            this.removeCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateCustomer
            // 
            this.updateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateCustomer.Location = new System.Drawing.Point(529, 72);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(127, 82);
            this.updateCustomer.TabIndex = 9;
            this.updateCustomer.Text = "Update Customer";
            this.updateCustomer.UseVisualStyleBackColor = false;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // showCustomer
            // 
            this.showCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.showCustomer.Location = new System.Drawing.Point(326, 210);
            this.showCustomer.Name = "showCustomer";
            this.showCustomer.Size = new System.Drawing.Size(127, 82);
            this.showCustomer.TabIndex = 8;
            this.showCustomer.Text = "Show All Customer";
            this.showCustomer.UseVisualStyleBackColor = false;
            this.showCustomer.Click += new System.EventHandler(this.showCustomer_Click);
            // 
            // findCustomer
            // 
            this.findCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.findCustomer.Location = new System.Drawing.Point(126, 353);
            this.findCustomer.Name = "findCustomer";
            this.findCustomer.Size = new System.Drawing.Size(127, 82);
            this.findCustomer.TabIndex = 7;
            this.findCustomer.Text = "Find Customer";
            this.findCustomer.UseVisualStyleBackColor = false;
            this.findCustomer.Click += new System.EventHandler(this.button3_Click);
            // 
            // removeCustomer
            // 
            this.removeCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.removeCustomer.Location = new System.Drawing.Point(529, 353);
            this.removeCustomer.Name = "removeCustomer";
            this.removeCustomer.Size = new System.Drawing.Size(127, 82);
            this.removeCustomer.TabIndex = 6;
            this.removeCustomer.Text = "Remove Customer";
            this.removeCustomer.UseVisualStyleBackColor = false;
            this.removeCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addCustomer.Location = new System.Drawing.Point(126, 72);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(127, 82);
            this.addCustomer.TabIndex = 5;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.showCustomer);
            this.Controls.Add(this.findCustomer);
            this.Controls.Add(this.removeCustomer);
            this.Controls.Add(this.addCustomer);
            this.Name = "CustomerManagement";
            this.Text = "Customer Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button showCustomer;
        private System.Windows.Forms.Button findCustomer;
        private System.Windows.Forms.Button removeCustomer;
        private System.Windows.Forms.Button addCustomer;
    }
}