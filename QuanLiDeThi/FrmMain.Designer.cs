namespace QuanLiDeThi
{
    partial class FrmMain
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAddExamPaper = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIManageClass = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIManageSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TxtSchoolName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.NmExamPaperCodeQnt = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NmDuration = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbSubjects = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbClassRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NmToltalQuestion = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnExportExam = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmExamPaperCodeQnt)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmDuration)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmToltalQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.quảnLíToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(418, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIAddExamPaper});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // TSMIAddExamPaper
            // 
            this.TSMIAddExamPaper.Name = "TSMIAddExamPaper";
            this.TSMIAddExamPaper.Size = new System.Drawing.Size(171, 26);
            this.TSMIAddExamPaper.Text = "Thêm đề thi";
            this.TSMIAddExamPaper.Click += new System.EventHandler(this.TSMIAddExamPaper_Click);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIManageClass,
            this.TSMIManageSubject});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            // 
            // TSMIManageClass
            // 
            this.TSMIManageClass.Name = "TSMIManageClass";
            this.TSMIManageClass.Size = new System.Drawing.Size(150, 26);
            this.TSMIManageClass.Text = "Lớp học";
            this.TSMIManageClass.Click += new System.EventHandler(this.TSMIManageClass_Click);
            // 
            // TSMIManageSubject
            // 
            this.TSMIManageSubject.Name = "TSMIManageSubject";
            this.TSMIManageSubject.Size = new System.Drawing.Size(150, 26);
            this.TSMIManageSubject.Text = "Môn học";
            this.TSMIManageSubject.Click += new System.EventHandler(this.TSMIManageSubject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình đề thi";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TxtSchoolName);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(6, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(382, 46);
            this.panel7.TabIndex = 2;
            // 
            // TxtSchoolName
            // 
            this.TxtSchoolName.Location = new System.Drawing.Point(125, 11);
            this.TxtSchoolName.Name = "TxtSchoolName";
            this.TxtSchoolName.Size = new System.Drawing.Size(244, 26);
            this.TxtSchoolName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên trường:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.NmExamPaperCodeQnt);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(4, 344);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(382, 46);
            this.panel6.TabIndex = 3;
            // 
            // NmExamPaperCodeQnt
            // 
            this.NmExamPaperCodeQnt.Location = new System.Drawing.Point(127, 9);
            this.NmExamPaperCodeQnt.Name = "NmExamPaperCodeQnt";
            this.NmExamPaperCodeQnt.Size = new System.Drawing.Size(242, 26);
            this.NmExamPaperCodeQnt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng mã đề:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.NmDuration);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(5, 292);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(382, 46);
            this.panel5.TabIndex = 3;
            // 
            // NmDuration
            // 
            this.NmDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NmDuration.Location = new System.Drawing.Point(127, 9);
            this.NmDuration.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.NmDuration.Name = "NmDuration";
            this.NmDuration.Size = new System.Drawing.Size(242, 26);
            this.NmDuration.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DtpExamDate);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(5, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(382, 46);
            this.panel4.TabIndex = 2;
            // 
            // DtpExamDate
            // 
            this.DtpExamDate.CustomFormat = "dd/MM/yyyy";
            this.DtpExamDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpExamDate.Location = new System.Drawing.Point(127, 11);
            this.DtpExamDate.Name = "DtpExamDate";
            this.DtpExamDate.Size = new System.Drawing.Size(242, 26);
            this.DtpExamDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày thi:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CbSubjects);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 46);
            this.panel2.TabIndex = 2;
            // 
            // CbSubjects
            // 
            this.CbSubjects.FormattingEnabled = true;
            this.CbSubjects.Location = new System.Drawing.Point(127, 8);
            this.CbSubjects.Name = "CbSubjects";
            this.CbSubjects.Size = new System.Drawing.Size(242, 28);
            this.CbSubjects.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Môn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbClassRoom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 46);
            this.panel1.TabIndex = 0;
            // 
            // CbClassRoom
            // 
            this.CbClassRoom.FormattingEnabled = true;
            this.CbClassRoom.Location = new System.Drawing.Point(127, 8);
            this.CbClassRoom.Name = "CbClassRoom";
            this.CbClassRoom.Size = new System.Drawing.Size(242, 28);
            this.CbClassRoom.TabIndex = 1;
            this.CbClassRoom.SelectedIndexChanged += new System.EventHandler(this.CbClassRoom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NmToltalQuestion);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 46);
            this.panel3.TabIndex = 2;
            // 
            // NmToltalQuestion
            // 
            this.NmToltalQuestion.Location = new System.Drawing.Point(127, 9);
            this.NmToltalQuestion.Name = "NmToltalQuestion";
            this.NmToltalQuestion.Size = new System.Drawing.Size(242, 26);
            this.NmToltalQuestion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số câu hỏi:";
            // 
            // BtnExportExam
            // 
            this.BtnExportExam.AutoSize = true;
            this.BtnExportExam.Location = new System.Drawing.Point(12, 443);
            this.BtnExportExam.Name = "BtnExportExam";
            this.BtnExportExam.Size = new System.Drawing.Size(394, 30);
            this.BtnExportExam.TabIndex = 4;
            this.BtnExportExam.Text = "Xuất đề thi";
            this.BtnExportExam.UseVisualStyleBackColor = true;
            this.BtnExportExam.Click += new System.EventHandler(this.BtnExportExam_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 486);
            this.Controls.Add(this.BtnExportExam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí đề thi";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmExamPaperCodeQnt)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmDuration)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmToltalQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIAddExamPaper;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIManageClass;
        private System.Windows.Forms.ToolStripMenuItem TSMIManageSubject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CbClassRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CbSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NmToltalQuestion;
        private System.Windows.Forms.Button BtnExportExam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker DtpExamDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown NmDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown NmExamPaperCodeQnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSchoolName;
    }
}

