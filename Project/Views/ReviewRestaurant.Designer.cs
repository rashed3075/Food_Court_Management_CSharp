namespace Project.Views
{
    partial class ReviewRestaurant
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
            this.labelRestId = new System.Windows.Forms.Label();
            this.tbRestId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReview = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRestId
            // 
            this.labelRestId.AutoSize = true;
            this.labelRestId.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestId.Location = new System.Drawing.Point(96, 96);
            this.labelRestId.Name = "labelRestId";
            this.labelRestId.Size = new System.Drawing.Size(215, 32);
            this.labelRestId.TabIndex = 0;
            this.labelRestId.Text = "Restaurant ID :";
            // 
            // tbRestId
            // 
            this.tbRestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRestId.Location = new System.Drawing.Point(102, 151);
            this.tbRestId.Multiline = true;
            this.tbRestId.Name = "tbRestId";
            this.tbRestId.Size = new System.Drawing.Size(222, 32);
            this.tbRestId.TabIndex = 1;
            this.tbRestId.TextChanged += new System.EventHandler(this.tbRestId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your REVIEW :";
            // 
            // tbReview
            // 
            this.tbReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReview.Location = new System.Drawing.Point(438, 151);
            this.tbReview.Multiline = true;
            this.tbReview.Name = "tbReview";
            this.tbReview.Size = new System.Drawing.Size(260, 170);
            this.tbReview.TabIndex = 3;
            this.tbReview.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnSubmit.Location = new System.Drawing.Point(565, 347);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 48);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ReviewRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources._1441032351_Young_background_education083115_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbReview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRestId);
            this.Controls.Add(this.labelRestId);
            this.Name = "ReviewRestaurant";
            this.Text = "ReviewRestaurant";
            this.Load += new System.EventHandler(this.ReviewRestaurant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRestId;
        private System.Windows.Forms.TextBox tbRestId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReview;
        private System.Windows.Forms.Button btnSubmit;
    }
}