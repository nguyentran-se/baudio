
namespace BaudioWinApp
{
    partial class HistoryDetail
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
            this.btnAction = new System.Windows.Forms.Button();
            this.lbAction = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAudioPath = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtBookname = new System.Windows.Forms.TextBox();
            this.txtUseID = new System.Windows.Forms.TextBox();
            this.txtHistoryId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(197, 339);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(109, 41);
            this.btnAction.TabIndex = 28;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lbAction
            // 
            this.lbAction.AutoSize = true;
            this.lbAction.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAction.ForeColor = System.Drawing.Color.Blue;
            this.lbAction.Location = new System.Drawing.Point(187, 26);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(138, 46);
            this.lbAction.TabIndex = 26;
            this.lbAction.Text = "History";
            this.lbAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 60;
            this.label3.Text = "AudioPath";
            // 
            // txtAudioPath
            // 
            this.txtAudioPath.Enabled = false;
            this.txtAudioPath.Location = new System.Drawing.Point(173, 228);
            this.txtAudioPath.Name = "txtAudioPath";
            this.txtAudioPath.Size = new System.Drawing.Size(276, 27);
            this.txtAudioPath.TabIndex = 58;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(52, 179);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(109, 28);
            this.lbPassword.TabIndex = 54;
            this.lbPassword.Text = "BookName";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.Location = new System.Drawing.Point(52, 130);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 28);
            this.lbUsername.TabIndex = 55;
            this.lbUsername.Text = "UserID";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemberID.Location = new System.Drawing.Point(52, 84);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(99, 28);
            this.lbMemberID.TabIndex = 56;
            this.lbMemberID.Text = "History ID";
            // 
            // txtBookname
            // 
            this.txtBookname.Enabled = false;
            this.txtBookname.Location = new System.Drawing.Point(173, 183);
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(276, 27);
            this.txtBookname.TabIndex = 51;
            this.txtBookname.UseWaitCursor = true;
            // 
            // txtUseID
            // 
            this.txtUseID.Enabled = false;
            this.txtUseID.Location = new System.Drawing.Point(173, 134);
            this.txtUseID.Name = "txtUseID";
            this.txtUseID.Size = new System.Drawing.Size(276, 27);
            this.txtUseID.TabIndex = 52;
            // 
            // txtHistoryId
            // 
            this.txtHistoryId.Enabled = false;
            this.txtHistoryId.Location = new System.Drawing.Point(173, 88);
            this.txtHistoryId.Name = "txtHistoryId";
            this.txtHistoryId.Size = new System.Drawing.Size(276, 27);
            this.txtHistoryId.TabIndex = 53;
            // 
            // HistoryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAudioPath);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.txtBookname);
            this.Controls.Add(this.txtUseID);
            this.Controls.Add(this.txtHistoryId);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lbAction);
            this.Name = "HistoryDetail";
            this.Text = "HistoryDetail";
            this.Load += new System.EventHandler(this.HistoryDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAudioPath;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtBookname;
        private System.Windows.Forms.TextBox txtUseID;
        private System.Windows.Forms.TextBox txtHistoryId;
    }
}