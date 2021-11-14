
namespace BaudioWinApp
{
    partial class InfoBook
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbAudioPath = new System.Windows.Forms.Label();
            this.txtAudioPath = new System.Windows.Forms.TextBox();
            this.lbAddDate = new System.Windows.Forms.Label();
            this.txtAddedDate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(110, 12);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(288, 39);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Book information";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(158, 95);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(273, 27);
            this.txtBookName.TabIndex = 11;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBookName.Location = new System.Drawing.Point(29, 91);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(110, 28);
            this.lbBookName.TabIndex = 12;
            this.lbBookName.Text = "Book name";
            // 
            // lbAudioPath
            // 
            this.lbAudioPath.AutoSize = true;
            this.lbAudioPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAudioPath.Location = new System.Drawing.Point(29, 152);
            this.lbAudioPath.Name = "lbAudioPath";
            this.lbAudioPath.Size = new System.Drawing.Size(110, 28);
            this.lbAudioPath.TabIndex = 14;
            this.lbAudioPath.Text = "Audio path";
            // 
            // txtAudioPath
            // 
            this.txtAudioPath.Location = new System.Drawing.Point(158, 152);
            this.txtAudioPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAudioPath.Name = "txtAudioPath";
            this.txtAudioPath.ReadOnly = true;
            this.txtAudioPath.Size = new System.Drawing.Size(273, 27);
            this.txtAudioPath.TabIndex = 13;
            // 
            // lbAddDate
            // 
            this.lbAddDate.AutoSize = true;
            this.lbAddDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddDate.Location = new System.Drawing.Point(29, 215);
            this.lbAddDate.Name = "lbAddDate";
            this.lbAddDate.Size = new System.Drawing.Size(115, 28);
            this.lbAddDate.TabIndex = 16;
            this.lbAddDate.Text = "Added date";
            // 
            // txtAddedDate
            // 
            this.txtAddedDate.Location = new System.Drawing.Point(158, 215);
            this.txtAddedDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddedDate.Name = "txtAddedDate";
            this.txtAddedDate.ReadOnly = true;
            this.txtAddedDate.Size = new System.Drawing.Size(273, 27);
            this.txtAddedDate.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(136, 279);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 55);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(295, 279);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 55);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // InfoBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 371);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbAddDate);
            this.Controls.Add(this.txtAddedDate);
            this.Controls.Add(this.lbAudioPath);
            this.Controls.Add(this.txtAudioPath);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InfoBook";
            this.Text = "Info Book";
            this.Load += new System.EventHandler(this.InfoBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbAudioPath;
        private System.Windows.Forms.TextBox txtAudioPath;
        private System.Windows.Forms.Label lbAddDate;
        private System.Windows.Forms.TextBox txtAddedDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}