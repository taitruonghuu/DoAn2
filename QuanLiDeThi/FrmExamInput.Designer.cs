namespace QuanLiDeThi
{
    partial class FrmExamInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbSubjects = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtShowFilePath = new System.Windows.Forms.TextBox();
            this.BtnBrowseFile = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            // 
            // CbSubjects
            // 
            this.CbSubjects.FormattingEnabled = true;
            this.CbSubjects.Location = new System.Drawing.Point(132, 22);
            this.CbSubjects.Name = "CbSubjects";
            this.CbSubjects.Size = new System.Drawing.Size(308, 28);
            this.CbSubjects.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "File";
            // 
            // TxtShowFilePath
            // 
            this.TxtShowFilePath.Location = new System.Drawing.Point(132, 61);
            this.TxtShowFilePath.Name = "TxtShowFilePath";
            this.TxtShowFilePath.Size = new System.Drawing.Size(261, 26);
            this.TxtShowFilePath.TabIndex = 3;
            // 
            // BtnBrowseFile
            // 
            this.BtnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowseFile.Location = new System.Drawing.Point(399, 61);
            this.BtnBrowseFile.Name = "BtnBrowseFile";
            this.BtnBrowseFile.Size = new System.Drawing.Size(41, 26);
            this.BtnBrowseFile.TabIndex = 4;
            this.BtnBrowseFile.Text = "...";
            this.BtnBrowseFile.UseVisualStyleBackColor = true;
            this.BtnBrowseFile.Click += new System.EventHandler(this.BtnBrowseFile_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.Location = new System.Drawing.Point(12, 93);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(208, 30);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.AutoSize = true;
            this.BtnExit.Location = new System.Drawing.Point(226, 93);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(214, 30);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmExamInput
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 132);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnBrowseFile);
            this.Controls.Add(this.TxtShowFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbSubjects);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmExamInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đề thi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExamInput_FormClosing);
            this.Load += new System.EventHandler(this.FrmExamInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtShowFilePath;
        private System.Windows.Forms.Button BtnBrowseFile;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnExit;
    }
}