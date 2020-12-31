namespace Project.Views
{
    partial class FoodManagement
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddFood = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(685, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 36);
            this.button6.TabIndex = 17;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(468, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 72);
            this.button5.TabIndex = 16;
            this.button5.Text = "Find And Update Food\r\n";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(468, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 82);
            this.button2.TabIndex = 13;
            this.button2.Text = "Remove Food\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.rFood);
            // 
            // AddFood
            // 
            this.AddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddFood.Location = new System.Drawing.Point(98, 111);
            this.AddFood.Name = "AddFood";
            this.AddFood.Size = new System.Drawing.Size(127, 82);
            this.AddFood.TabIndex = 12;
            this.AddFood.Text = "Add Food";
            this.AddFood.UseVisualStyleBackColor = false;
            this.AddFood.Click += new System.EventHandler(this.AfClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(170, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Food Management";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(98, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 82);
            this.button4.TabIndex = 15;
            this.button4.Text = "Show All Food\r\n";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FoodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 519);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddFood);
            this.Controls.Add(this.label1);
            this.Name = "FoodManagement";
            this.Text = "FoodManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}