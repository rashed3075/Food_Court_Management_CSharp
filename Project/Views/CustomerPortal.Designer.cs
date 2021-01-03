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
            this.SuspendLayout();
            // 
            // btnFoodMenu
            // 
            this.btnFoodMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFoodMenu.Location = new System.Drawing.Point(543, 74);
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
            this.btnRestaurants.Location = new System.Drawing.Point(139, 74);
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
            this.btnPlaceOrder.Location = new System.Drawing.Point(344, 192);
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
            this.btnOrderHistory.Location = new System.Drawing.Point(139, 333);
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
            this.btnReview.Location = new System.Drawing.Point(543, 333);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(114, 72);
            this.btnReview.TabIndex = 9;
            this.btnReview.Text = "Make Review";
            this.btnReview.UseVisualStyleBackColor = false;
            // 
            // CustomerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnRestaurants);
            this.Controls.Add(this.btnFoodMenu);
            this.Name = "CustomerPortal";
            this.Text = "CustomerPortal";
            this.Load += new System.EventHandler(this.CustomerPortal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFoodMenu;
        private System.Windows.Forms.Button btnRestaurants;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnReview;
    }
}