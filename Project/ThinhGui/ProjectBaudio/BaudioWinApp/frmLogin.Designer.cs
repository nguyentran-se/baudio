
namespace BaudioWinApp
{
    partial class frmLogin
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
            this.loginButton = new System.Windows.Forms.Button();
            this.BAudio = new System.Windows.Forms.Label();
            this.frmLoginPassword = new System.Windows.Forms.TextBox();
            this.frmLoginEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(329, 347);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(139, 37);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // BAudio
            // 
            this.BAudio.AutoSize = true;
            this.BAudio.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BAudio.Location = new System.Drawing.Point(247, 65);
            this.BAudio.Name = "BAudio";
            this.BAudio.Size = new System.Drawing.Size(306, 67);
            this.BAudio.TabIndex = 10;
            this.BAudio.Text = "Book Audio";
            // 
            // frmLoginPassword
            // 
            this.frmLoginPassword.Location = new System.Drawing.Point(380, 274);
            this.frmLoginPassword.Name = "frmLoginPassword";
            this.frmLoginPassword.PasswordChar = '*';
            this.frmLoginPassword.Size = new System.Drawing.Size(173, 27);
            this.frmLoginPassword.TabIndex = 9;
            // 
            // frmLoginEmail
            // 
            this.frmLoginEmail.Location = new System.Drawing.Point(380, 210);
            this.frmLoginEmail.Name = "frmLoginEmail";
            this.frmLoginEmail.Size = new System.Drawing.Size(173, 27);
            this.frmLoginEmail.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(232, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.BAudio);
            this.Controls.Add(this.frmLoginPassword);
            this.Controls.Add(this.frmLoginEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label BAudio;
        private System.Windows.Forms.TextBox frmLoginPassword;
        private System.Windows.Forms.TextBox frmLoginEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}