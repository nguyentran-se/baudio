
namespace BaudioWinApp
{
    partial class Listen
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
            this.lbAddDate = new System.Windows.Forms.Label();
            this.txtAddedDate = new System.Windows.Forms.TextBox();
            this.lbAudioPath = new System.Windows.Forms.Label();
            this.txtAudioPath = new System.Windows.Forms.TextBox();
            this.lbBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookContent = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(32, 19);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(108, 37);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Listen";
            // 
            // lbAddDate
            // 
            this.lbAddDate.AutoSize = true;
            this.lbAddDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddDate.Location = new System.Drawing.Point(35, 169);
            this.lbAddDate.Name = "lbAddDate";
            this.lbAddDate.Size = new System.Drawing.Size(89, 21);
            this.lbAddDate.TabIndex = 22;
            this.lbAddDate.Text = "Added date";
            // 
            // txtAddedDate
            // 
            this.txtAddedDate.Location = new System.Drawing.Point(129, 167);
            this.txtAddedDate.Name = "txtAddedDate";
            this.txtAddedDate.ReadOnly = true;
            this.txtAddedDate.Size = new System.Drawing.Size(239, 23);
            this.txtAddedDate.TabIndex = 21;
            // 
            // lbAudioPath
            // 
            this.lbAudioPath.AutoSize = true;
            this.lbAudioPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAudioPath.Location = new System.Drawing.Point(35, 122);
            this.lbAudioPath.Name = "lbAudioPath";
            this.lbAudioPath.Size = new System.Drawing.Size(86, 21);
            this.lbAudioPath.TabIndex = 20;
            this.lbAudioPath.Text = "Audio path";
            // 
            // txtAudioPath
            // 
            this.txtAudioPath.Location = new System.Drawing.Point(129, 120);
            this.txtAudioPath.Name = "txtAudioPath";
            this.txtAudioPath.ReadOnly = true;
            this.txtAudioPath.Size = new System.Drawing.Size(239, 23);
            this.txtAudioPath.TabIndex = 19;
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBookName.Location = new System.Drawing.Point(35, 76);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(88, 21);
            this.lbBookName.TabIndex = 18;
            this.lbBookName.Text = "Book name";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(129, 74);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(239, 23);
            this.txtBookName.TabIndex = 17;
            // 
            // txtBookContent
            // 
            this.txtBookContent.Location = new System.Drawing.Point(35, 214);
            this.txtBookContent.Multiline = true;
            this.txtBookContent.Name = "txtBookContent";
            this.txtBookContent.ReadOnly = true;
            this.txtBookContent.Size = new System.Drawing.Size(333, 248);
            this.txtBookContent.TabIndex = 23;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(409, 214);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(90, 35);
            this.btnPlay.TabIndex = 24;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(409, 255);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(90, 35);
            this.btnPause.TabIndex = 25;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // Listen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 491);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtBookContent);
            this.Controls.Add(this.lbAddDate);
            this.Controls.Add(this.txtAddedDate);
            this.Controls.Add(this.lbAudioPath);
            this.Controls.Add(this.txtAudioPath);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lbTitle);
            this.Name = "Listen";
            this.Text = "Listen";
            this.Load += new System.EventHandler(this.Listen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbAddDate;
        private System.Windows.Forms.TextBox txtAddedDate;
        private System.Windows.Forms.Label lbAudioPath;
        private System.Windows.Forms.TextBox txtAudioPath;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookContent;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
    }
}