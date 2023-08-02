
namespace Encryptor
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrows = new System.Windows.Forms.Button();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gbCrypt = new System.Windows.Forms.GroupBox();
            this.gbCrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(32, 47);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(271, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrows
            // 
            this.btnBrows.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBrows.Location = new System.Drawing.Point(331, 45);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(75, 23);
            this.btnBrows.TabIndex = 2;
            this.btnBrows.Text = "Brows";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Location = new System.Drawing.Point(16, 31);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(61, 17);
            this.rbEncrypt.TabIndex = 3;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            this.rbEncrypt.CheckedChanged += new System.EventHandler(this.rbEncrypt_CheckedChanged);
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(147, 31);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(62, 17);
            this.rbDecrypt.TabIndex = 4;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Decrypt";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 211);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(32, 254);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(271, 43);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // gbCrypt
            // 
            this.gbCrypt.Controls.Add(this.rbEncrypt);
            this.gbCrypt.Controls.Add(this.rbDecrypt);
            this.gbCrypt.Location = new System.Drawing.Point(32, 96);
            this.gbCrypt.Name = "gbCrypt";
            this.gbCrypt.Size = new System.Drawing.Size(271, 78);
            this.gbCrypt.TabIndex = 8;
            this.gbCrypt.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 345);
            this.Controls.Add(this.gbCrypt);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrows);
            this.Controls.Add(this.txtPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCrypt.ResumeLayout(false);
            this.gbCrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.GroupBox gbCrypt;
    }
}

