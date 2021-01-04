namespace Project.Views
{
    partial class CustomerPortal
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
            this.btnFoodMenu = new System.Windows.Forms.Button();
            this.btnRestaurants = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.WelcomeBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFoodMenu
            // 
            this.btnFoodMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFoodMenu.Location = new System.Drawing.Point(504, 71);
            this.btnFoodMenu.Name = "btnFoodMenu";
            this.btnFoodMenu.Size = new System.Drawing.Size(114, 72);
            this.btnFoodMenu.TabIndex = 5;
            this.btnFoodMenu.Text = "Food Menu";
            this.btnFoodMenu.UseVisualStyleBackColor = false;
            this.btnFoodMenu.Click += new System.EventHandler(this.btnFoodMenu_Click);
            // 
            // btnRestaurants
            // 
            this.btnRestaurants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRestaurants.Location = new System.Drawing.Point(100, 71);
            this.btnRestaurants.Name = "btnRestaurants";
            this.btnRestaurants.Size = new System.Drawing.Size(114, 72);
            this.btnRestaurants.TabIndex = 6;
            this.btnRestaurants.Text = "Restaurants";
            this.btnRestaurants.UseVisualStyleBackColor = false;
            this.btnRestaurants.Click += new System.EventHandler(this.btnRestaurants_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPlaceOrder.Location = new System.Drawing.Point(305, 189);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(114, 72);
            this.btnPlaceOrder.TabIndex = 7;
            this.btnPlaceOrder.Text = "Order Now";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOrderHistory.Location = new System.Drawing.Point(100, 330);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(114, 72);
            this.btnOrderHistory.TabIndex = 8;
            this.btnOrderHistory.Text = "Order History";
            this.btnOrderHistory.UseVisualStyleBackColor = false;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnReview
            // 
            this.btnReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReview.Location = new System.Drawing.Point(504, 330);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(114, 72);
            this.btnReview.TabIndex = 9;
            this.btnReview.Text = "Make Review";
            this.btnReview.UseVisualStyleBackColor = false;
            // 
            // WelcomeBox
            // 
            this.WelcomeBox.AutoSize = true;
            this.WelcomeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBox.Location = new System.Drawing.Point(424, 9);
            this.WelcomeBox.Name = "WelcomeBox";
            this.WelcomeBox.Size = new System.Drawing.Size(344, 29);
            this.WelcomeBox.TabIndex = 10;
            this.WelcomeBox.Text = "Welcome Rashedul Rabby";
            // 
            // CustomerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.WelcomeBox);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnRestaurants);
            this.Controls.Add(this.btnFoodMenu);
            this.Name = "CustomerPortal";
            this.Text = "CustomerPortal";
            this.Load += new System.EventHandler(this.CustomerPortal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFoodMenu;
        private System.Windows.Forms.Button btnRestaurants;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Label WelcomeBox;
    }
}