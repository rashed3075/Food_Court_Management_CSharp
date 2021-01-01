namespace Project.Views
{
    partial class CustomerList
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
            this.dgViewCustomerList = new System.Windows.Forms.DataGridView();
            this.labelCustomerList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewCustomerList
            // 
            this.dgViewCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewCustomerList.Location = new System.Drawing.Point(69, 97);
            this.dgViewCustomerList.Name = "dgViewCustomerList";
            this.dgViewCustomerList.RowHeadersWidth = 51;
            this.dgViewCustomerList.RowTemplate.Height = 24;
            this.dgViewCustomerList.Size = new System.Drawing.Size(654, 353);
            this.dgViewCustomerList.TabIndex = 0;
            this.dgViewCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelCustomerList
            // 
            this.labelCustomerList.AutoSize = true;
            this.labelCustomerList.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerList.Location = new System.Drawing.Point(282, 28);
            this.labelCustomerList.Name = "labelCustomerList";
            this.labelCustomerList.Size = new System.Drawing.Size(182, 35);
            this.labelCustomerList.TabIndex = 1;
            this.labelCustomerList.Text = "Customer List";
            this.labelCustomerList.Click += new System.EventHandler(this.labelCustomerList_Click);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.labelCustomerList);
            this.Controls.Add(this.dgViewCustomerList);
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgViewCustomerList;
        private System.Windows.Forms.Label labelCustomerList;
    }
}