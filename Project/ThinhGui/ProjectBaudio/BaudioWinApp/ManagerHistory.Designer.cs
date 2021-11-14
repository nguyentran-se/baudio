
namespace BaudioWinApp
{
    partial class ManagerHistory
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
            this.btnAsc = new System.Windows.Forms.Button();
            this.btnDesc = new System.Windows.Forms.Button();
            this.dgvHistoryList = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtBookname = new System.Windows.Forms.TextBox();
            this.txtUseID = new System.Windows.Forms.TextBox();
            this.txtHistoryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddedDate = new System.Windows.Forms.TextBox();
            this.txtAudioPath = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsc
            // 
            this.btnAsc.Location = new System.Drawing.Point(253, 193);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(94, 29);
            this.btnAsc.TabIndex = 46;
            this.btnAsc.Text = "Asc";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(153, 193);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(94, 29);
            this.btnDesc.TabIndex = 45;
            this.btnDesc.Text = "Desc";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // dgvHistoryList
            // 
            this.dgvHistoryList.AllowUserToAddRows = false;
            this.dgvHistoryList.AllowUserToDeleteRows = false;
            this.dgvHistoryList.AllowUserToResizeColumns = false;
            this.dgvHistoryList.AllowUserToResizeRows = false;
            this.dgvHistoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoryList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryList.Location = new System.Drawing.Point(53, 228);
            this.dgvHistoryList.MultiSelect = false;
            this.dgvHistoryList.Name = "dgvHistoryList";
            this.dgvHistoryList.ReadOnly = true;
            this.dgvHistoryList.RowHeadersWidth = 51;
            this.dgvHistoryList.RowTemplate.Height = 29;
            this.dgvHistoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoryList.Size = new System.Drawing.Size(877, 338);
            this.dgvHistoryList.TabIndex = 41;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(873, 72);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 37;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(873, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(53, 193);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 39;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(19, 109);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(109, 28);
            this.lbPassword.TabIndex = 34;
            this.lbPassword.Text = "BookName";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.Location = new System.Drawing.Point(19, 60);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 28);
            this.lbUsername.TabIndex = 35;
            this.lbUsername.Text = "UserID";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemberID.Location = new System.Drawing.Point(19, 14);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(99, 28);
            this.lbMemberID.TabIndex = 36;
            this.lbMemberID.Text = "History ID";
            // 
            // txtBookname
            // 
            this.txtBookname.Enabled = false;
            this.txtBookname.Location = new System.Drawing.Point(157, 113);
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(276, 27);
            this.txtBookname.TabIndex = 31;
            this.txtBookname.UseWaitCursor = true;
            // 
            // txtUseID
            // 
            this.txtUseID.Enabled = false;
            this.txtUseID.Location = new System.Drawing.Point(157, 64);
            this.txtUseID.Name = "txtUseID";
            this.txtUseID.Size = new System.Drawing.Size(276, 27);
            this.txtUseID.TabIndex = 32;
            // 
            // txtHistoryId
            // 
            this.txtHistoryId.Enabled = false;
            this.txtHistoryId.Location = new System.Drawing.Point(157, 18);
            this.txtHistoryId.Name = "txtHistoryId";
            this.txtHistoryId.Size = new System.Drawing.Size(276, 27);
            this.txtHistoryId.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(439, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 49;
            this.label2.Text = "AddedDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(439, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 50;
            this.label3.Text = "AudioPath";
            // 
            // txtAddedDate
            // 
            this.txtAddedDate.Enabled = false;
            this.txtAddedDate.Location = new System.Drawing.Point(563, 69);
            this.txtAddedDate.Name = "txtAddedDate";
            this.txtAddedDate.Size = new System.Drawing.Size(276, 27);
            this.txtAddedDate.TabIndex = 47;
            // 
            // txtAudioPath
            // 
            this.txtAudioPath.Enabled = false;
            this.txtAudioPath.Location = new System.Drawing.Point(563, 23);
            this.txtAudioPath.Name = "txtAudioPath";
            this.txtAudioPath.Size = new System.Drawing.Size(276, 27);
            this.txtAudioPath.TabIndex = 48;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(535, 572);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(362, 572);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 51;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ManagerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 606);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddedDate);
            this.Controls.Add(this.txtAudioPath);
            this.Controls.Add(this.btnAsc);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.dgvHistoryList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.txtBookname);
            this.Controls.Add(this.txtUseID);
            this.Controls.Add(this.txtHistoryId);
            this.Name = "ManagerHistory";
            this.Text = "ManagerHistory";
            this.Load += new System.EventHandler(this.ManagerHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.DataGridView dgvHistoryList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtBookname;
        private System.Windows.Forms.TextBox txtUseID;
        private System.Windows.Forms.TextBox txtHistoryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddedDate;
        private System.Windows.Forms.TextBox txtAudioPath;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
    }
}