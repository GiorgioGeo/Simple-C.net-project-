﻿namespace Forms
{
    partial class MainMenuForm
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
            this.RegisterFormButton = new System.Windows.Forms.Button();
            this.LoginFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterFormButton
            // 
            this.RegisterFormButton.Location = new System.Drawing.Point(52, 106);
            this.RegisterFormButton.Name = "RegisterFormButton";
            this.RegisterFormButton.Size = new System.Drawing.Size(129, 41);
            this.RegisterFormButton.TabIndex = 0;
            this.RegisterFormButton.Text = "Inregistrare";
            this.RegisterFormButton.UseVisualStyleBackColor = true;
            this.RegisterFormButton.Click += new System.EventHandler(this.RegisterFormButton_Click);
            // 
            // LoginFormButton
            // 
            this.LoginFormButton.Location = new System.Drawing.Point(218, 106);
            this.LoginFormButton.Name = "LoginFormButton";
            this.LoginFormButton.Size = new System.Drawing.Size(123, 41);
            this.LoginFormButton.TabIndex = 1;
            this.LoginFormButton.Text = "Autentificare";
            this.LoginFormButton.UseVisualStyleBackColor = true;
            this.LoginFormButton.Click += new System.EventHandler(this.LoginFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meniu Principal";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginFormButton);
            this.Controls.Add(this.RegisterFormButton);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterFormButton;
        private System.Windows.Forms.Button LoginFormButton;
        private System.Windows.Forms.Label label1;
    }
}

