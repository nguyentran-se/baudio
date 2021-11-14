
namespace BaudioWinApp
{
    partial class AddBook
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrowseFile = new System.Windows.Forms.TextBox();
            this.lbPdfUrl = new System.Windows.Forms.Label();
            this.txtPdfUrl = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(41, 306);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(240, 42);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBookName.Location = new System.Drawing.Point(36, 225);
            this.lbBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(90, 20);
            this.lbBookName.TabIndex = 16;
            this.lbBookName.Text = "Book name";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(41, 252);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(464, 23);
            this.txtBookName.TabIndex = 15;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(533, 177);
            this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(88, 27);
            this.btnBrowseFile.TabIndex = 14;
            this.btnBrowseFile.Text = "Browse...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose a file in your computer";
            // 
            // txtBrowseFile
            // 
            this.txtBrowseFile.Location = new System.Drawing.Point(41, 180);
            this.txtBrowseFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBrowseFile.Name = "txtBrowseFile";
            this.txtBrowseFile.Size = new System.Drawing.Size(464, 23);
            this.txtBrowseFile.TabIndex = 12;
            // 
            // lbPdfUrl
            // 
            this.lbPdfUrl.AutoSize = true;
            this.lbPdfUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPdfUrl.Location = new System.Drawing.Point(36, 81);
            this.lbPdfUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPdfUrl.Name = "lbPdfUrl";
            this.lbPdfUrl.Size = new System.Drawing.Size(136, 20);
            this.lbPdfUrl.TabIndex = 11;
            this.lbPdfUrl.Text = "Enter an url of pdf";
            // 
            // txtPdfUrl
            // 
            this.txtPdfUrl.Location = new System.Drawing.Point(41, 107);
            this.txtPdfUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPdfUrl.Name = "txtPdfUrl";
            this.txtPdfUrl.Size = new System.Drawing.Size(464, 23);
            this.txtPdfUrl.TabIndex = 10;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(35, 29);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(162, 37);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "Add book";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 380);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbBookName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrowseFile);
            this.Controls.Add(this.lbPdfUrl);
            this.Controls.Add(this.txtPdfUrl);
            this.Controls.Add(this.lbTitle);
            this.Name = "AddBook";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrowseFile;
        private System.Windows.Forms.Label lbPdfUrl;
        private System.Windows.Forms.TextBox txtPdfUrl;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}