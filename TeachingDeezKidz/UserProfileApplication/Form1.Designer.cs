﻿namespace UserProfileApplication
{
    partial class Form1
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
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(13, 41);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(115, 20);
            this.Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.Gender.Location = new System.Drawing.Point(65, 68);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(63, 21);
            this.Gender.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race";
            // 
            // Race
            // 
            this.Race.FormattingEnabled = true;
            this.Race.Items.AddRange(new object[] {
            "White",
            "Black",
            "Asian",
            "Hispanic",
            "Other"});
            this.Race.Location = new System.Drawing.Point(65, 96);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(63, 21);
            this.Race.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(65, 124);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(63, 20);
            this.Age.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Race;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.Button button1;
    }
}

