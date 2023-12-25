namespace QuanLiDeThi
{
    partial class FrmClassRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLoadClass = new System.Windows.Forms.Button();
            this.BtnDeleteClass = new System.Windows.Forms.Button();
            this.BtnUpdateClass = new System.Windows.Forms.Button();
            this.BtnAddClass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvClassRoom = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtClassId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LsvSubjects = new System.Windows.Forms.ListView();
            this.BtnEditSubjectsByClassId = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClassRoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLoadClass);
            this.panel1.Controls.Add(this.BtnDeleteClass);
            this.panel1.Controls.Add(this.BtnUpdateClass);
            this.panel1.Controls.Add(this.BtnAddClass);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 37);
            this.panel1.TabIndex = 1;
            // 
            // BtnLoadClass
            // 
            this.BtnLoadClass.AutoSize = true;
            this.BtnLoadClass.Image = global::QuanLiDeThi.Properties.Resources.load_24;
            this.BtnLoadClass.Location = new System.Drawing.Point(246, 3);
            this.BtnLoadClass.Name = "BtnLoadClass";
            this.BtnLoadClass.Size = new System.Drawing.Size(75, 30);
            this.BtnLoadClass.TabIndex = 3;
            this.BtnLoadClass.UseVisualStyleBackColor = true;
            this.BtnLoadClass.Click += new System.EventHandler(this.BtnLoadClass_Click);
            // 
            // BtnDeleteClass
            // 
            this.BtnDeleteClass.AutoSize = true;
            this.BtnDeleteClass.Image = global::QuanLiDeThi.Properties.Resources.delete_24;
            this.BtnDeleteClass.Location = new System.Drawing.Point(165, 3);
            this.BtnDeleteClass.Name = "BtnDeleteClass";
            this.BtnDeleteClass.Size = new System.Drawing.Size(75, 30);
            this.BtnDeleteClass.TabIndex = 2;
            this.BtnDeleteClass.UseVisualStyleBackColor = true;
            this.BtnDeleteClass.Click += new System.EventHandler(this.BtnDeleteClass_Click);
            // 
            // BtnUpdateClass
            // 
            this.BtnUpdateClass.AutoSize = true;
            this.BtnUpdateClass.Image = global::QuanLiDeThi.Properties.Resources.edit_24;
            this.BtnUpdateClass.Location = new System.Drawing.Point(84, 3);
            this.BtnUpdateClass.Name = "BtnUpdateClass";
            this.BtnUpdateClass.Size = new System.Drawing.Size(75, 30);
            this.BtnUpdateClass.TabIndex = 1;
            this.BtnUpdateClass.UseVisualStyleBackColor = true;
            this.BtnUpdateClass.Click += new System.EventHandler(this.BtnUpdateClass_Click);
            // 
            // BtnAddClass
            // 
            this.BtnAddClass.AutoSize = true;
            this.BtnAddClass.Image = global::QuanLiDeThi.Properties.Resources.add_24;
            this.BtnAddClass.Location = new System.Drawing.Point(3, 3);
            this.BtnAddClass.Name = "BtnAddClass";
            this.BtnAddClass.Size = new System.Drawing.Size(75, 30);
            this.BtnAddClass.TabIndex = 0;
            this.BtnAddClass.UseVisualStyleBackColor = true;
            this.BtnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvClassRoom);
            this.panel2.Location = new System.Drawing.Point(12, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 332);
            this.panel2.TabIndex = 2;
            // 
            // DgvClassRoom
            // 
            this.DgvClassRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClassRoom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClassRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvClassRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvClassRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvClassRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvClassRoom.Location = new System.Drawing.Point(0, 0);
            this.DgvClassRoom.Name = "DgvClassRoom";
            this.DgvClassRoom.RowHeadersWidth = 51;
            this.DgvClassRoom.RowTemplate.Height = 24;
            this.DgvClassRoom.Size = new System.Drawing.Size(325, 332);
            this.DgvClassRoom.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(343, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtClassId);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(7, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 43);
            this.panel3.TabIndex = 3;
            // 
            // TxtClassId
            // 
            this.TxtClassId.Location = new System.Drawing.Point(95, 9);
            this.TxtClassId.Name = "TxtClassId";
            this.TxtClassId.ReadOnly = true;
            this.TxtClassId.Size = new System.Drawing.Size(184, 26);
            this.TxtClassId.TabIndex = 1;
            this.TxtClassId.TextChanged += new System.EventHandler(this.TxtClassId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TxtClassName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(7, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(282, 43);
            this.panel4.TabIndex = 1;
            // 
            // TxtClassName
            // 
            this.TxtClassName.Location = new System.Drawing.Point(95, 7);
            this.TxtClassName.Name = "TxtClassName";
            this.TxtClassName.Size = new System.Drawing.Size(184, 26);
            this.TxtClassName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LsvSubjects);
            this.groupBox2.Controls.Add(this.BtnEditSubjectsByClassId);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(343, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 235);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn học";
            // 
            // LsvSubjects
            // 
            this.LsvSubjects.HideSelection = false;
            this.LsvSubjects.Location = new System.Drawing.Point(7, 25);
            this.LsvSubjects.Name = "LsvSubjects";
            this.LsvSubjects.Size = new System.Drawing.Size(288, 168);
            this.LsvSubjects.TabIndex = 7;
            this.LsvSubjects.UseCompatibleStateImageBehavior = false;
            this.LsvSubjects.View = System.Windows.Forms.View.List;
            // 
            // BtnEditSubjectsByClassId
            // 
            this.BtnEditSubjectsByClassId.AutoSize = true;
            this.BtnEditSubjectsByClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditSubjectsByClassId.Location = new System.Drawing.Point(7, 199);
            this.BtnEditSubjectsByClassId.Name = "BtnEditSubjectsByClassId";
            this.BtnEditSubjectsByClassId.Size = new System.Drawing.Size(282, 30);
            this.BtnEditSubjectsByClassId.TabIndex = 6;
            this.BtnEditSubjectsByClassId.Text = "Chỉnh sửa";
            this.BtnEditSubjectsByClassId.UseVisualStyleBackColor = true;
            this.BtnEditSubjectsByClassId.Click += new System.EventHandler(this.BtnEditSubjectsByClassId_Click);
            // 
            // FrmClassRoom
            // 
            this.AcceptButton = this.BtnAddClass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmClassRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí lớp học";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClassRoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLoadClass;
        private System.Windows.Forms.Button BtnDeleteClass;
        private System.Windows.Forms.Button BtnUpdateClass;
        private System.Windows.Forms.Button BtnAddClass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvClassRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtClassId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEditSubjectsByClassId;
        private System.Windows.Forms.ListView LsvSubjects;
    }
}