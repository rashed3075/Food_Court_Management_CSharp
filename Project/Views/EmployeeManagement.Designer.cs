﻿namespace Project.Views
{
    partial class EmployeeManagement
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(66, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(449, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Employee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.RemoveEmployee);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(66, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 82);
            this.button3.TabIndex = 2;
            this.button3.Text = "Find Employee";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.fEmployee);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(258, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 82);
            this.button4.TabIndex = 3;
            this.button4.Text = "Show All Employee";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(449, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 72);
            this.button5.TabIndex = 4;
            this.button5.Text = "Update Employee";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.uEmployee);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 517);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}