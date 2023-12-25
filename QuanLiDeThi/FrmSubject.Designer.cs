namespace QuanLiDeThi
{
    partial class FrmSubject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLoadSubjects = new System.Windows.Forms.Button();
            this.BtnDeleteSubject = new System.Windows.Forms.Button();
            this.BtnUpdateSubject = new System.Windows.Forms.Button();
            this.BtnAddSubject = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvSubjects = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtSubjectName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtSubjectCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtSubjectId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubjects)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLoadSubjects);
            this.panel1.Controls.Add(this.BtnDeleteSubject);
            this.panel1.Controls.Add(this.BtnUpdateSubject);
            this.panel1.Controls.Add(this.BtnAddSubject);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 38);
            this.panel1.TabIndex = 0;
            // 
            // BtnLoadSubjects
            // 
            this.BtnLoadSubjects.AutoSize = true;
            this.BtnLoadSubjects.Image = global::QuanLiDeThi.Properties.Resources.load_24;
            this.BtnLoadSubjects.Location = new System.Drawing.Point(246, 2);
            this.BtnLoadSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLoadSubjects.Name = "BtnLoadSubjects";
            this.BtnLoadSubjects.Size = new System.Drawing.Size(75, 34);
            this.BtnLoadSubjects.TabIndex = 3;
            this.BtnLoadSubjects.UseVisualStyleBackColor = true;
            this.BtnLoadSubjects.Click += new System.EventHandler(this.BtnLoadSubjects_Click);
            // 
            // BtnDeleteSubject
            // 
            this.BtnDeleteSubject.AutoSize = true;
            this.BtnDeleteSubject.Image = global::QuanLiDeThi.Properties.Resources.delete_24;
            this.BtnDeleteSubject.Location = new System.Drawing.Point(165, 2);
            this.BtnDeleteSubject.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteSubject.Name = "BtnDeleteSubject";
            this.BtnDeleteSubject.Size = new System.Drawing.Size(75, 34);
            this.BtnDeleteSubject.TabIndex = 2;
            this.BtnDeleteSubject.UseVisualStyleBackColor = true;
            this.BtnDeleteSubject.Click += new System.EventHandler(this.BtnDeleteSubject_Click);
            // 
            // BtnUpdateSubject
            // 
            this.BtnUpdateSubject.AutoSize = true;
            this.BtnUpdateSubject.Image = global::QuanLiDeThi.Properties.Resources.edit_24;
            this.BtnUpdateSubject.Location = new System.Drawing.Point(84, 2);
            this.BtnUpdateSubject.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateSubject.Name = "BtnUpdateSubject";
            this.BtnUpdateSubject.Size = new System.Drawing.Size(75, 34);
            this.BtnUpdateSubject.TabIndex = 1;
            this.BtnUpdateSubject.UseVisualStyleBackColor = true;
            this.BtnUpdateSubject.Click += new System.EventHandler(this.BtnUpdateSubject_Click);
            // 
            // BtnAddSubject
            // 
            this.BtnAddSubject.AutoSize = true;
            this.BtnAddSubject.Image = global::QuanLiDeThi.Properties.Resources.add_24;
            this.BtnAddSubject.Location = new System.Drawing.Point(2, 2);
            this.BtnAddSubject.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddSubject.Name = "BtnAddSubject";
            this.BtnAddSubject.Size = new System.Drawing.Size(75, 34);
            this.BtnAddSubject.TabIndex = 0;
            this.BtnAddSubject.UseVisualStyleBackColor = true;
            this.BtnAddSubject.Click += new System.EventHandler(this.BtnAddSubject_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvSubjects);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 332);
            this.panel2.TabIndex = 1;
            // 
            // DgvSubjects
            // 
            this.DgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSubjects.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSubjects.Location = new System.Drawing.Point(0, 0);
            this.DgvSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.DgvSubjects.Name = "DgvSubjects";
            this.DgvSubjects.RowHeadersWidth = 51;
            this.DgvSubjects.RowTemplate.Height = 24;
            this.DgvSubjects.Size = new System.Drawing.Size(325, 332);
            this.DgvSubjects.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtSubjectName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(8, 78);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 42);
            this.panel4.TabIndex = 1;
            // 
            // TxtSubjectName
            // 
            this.TxtSubjectName.Location = new System.Drawing.Point(55, 8);
            this.TxtSubjectName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSubjectName.Name = "TxtSubjectName";
            this.TxtSubjectName.Size = new System.Drawing.Size(224, 26);
            this.TxtSubjectName.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TxtSubjectCode);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(8, 126);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(282, 42);
            this.panel5.TabIndex = 2;
            // 
            // TxtSubjectCode
            // 
            this.TxtSubjectCode.Location = new System.Drawing.Point(55, 9);
            this.TxtSubjectCode.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSubjectCode.Name = "TxtSubjectCode";
            this.TxtSubjectCode.Size = new System.Drawing.Size(224, 26);
            this.TxtSubjectCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "KH:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(342, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(295, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtSubjectId);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(8, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 42);
            this.panel3.TabIndex = 3;
            // 
            // TxtSubjectId
            // 
            this.TxtSubjectId.Location = new System.Drawing.Point(55, 9);
            this.TxtSubjectId.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSubjectId.Name = "TxtSubjectId";
            this.TxtSubjectId.ReadOnly = true;
            this.TxtSubjectId.Size = new System.Drawing.Size(224, 26);
            this.TxtSubjectId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã:";
            // 
            // FrmSubject
            // 
            this.AcceptButton = this.BtnAddSubject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(650, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí môn học";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSubjects)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLoadSubjects;
        private System.Windows.Forms.Button BtnDeleteSubject;
        private System.Windows.Forms.Button BtnUpdateSubject;
        private System.Windows.Forms.Button BtnAddSubject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvSubjects;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtSubjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TxtSubjectCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtSubjectId;
        private System.Windows.Forms.Label label3;
    }
}