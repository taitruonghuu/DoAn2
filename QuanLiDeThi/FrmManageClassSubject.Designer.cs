namespace QuanLiDeThi
{
    partial class FrmManageClassSubject
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
            this.LsvSelectedSubjects = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRemoveOne = new System.Windows.Forms.Button();
            this.BtnRemoveAll = new System.Windows.Forms.Button();
            this.BtnAddOne = new System.Windows.Forms.Button();
            this.BtnAddAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LsvRemainingSubjects = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LsvSelectedSubjects
            // 
            this.LsvSelectedSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvSelectedSubjects.HideSelection = false;
            this.LsvSelectedSubjects.Location = new System.Drawing.Point(4, 23);
            this.LsvSelectedSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.LsvSelectedSubjects.MultiSelect = false;
            this.LsvSelectedSubjects.Name = "LsvSelectedSubjects";
            this.LsvSelectedSubjects.Size = new System.Drawing.Size(326, 372);
            this.LsvSelectedSubjects.TabIndex = 0;
            this.LsvSelectedSubjects.UseCompatibleStateImageBehavior = false;
            this.LsvSelectedSubjects.View = System.Windows.Forms.View.List;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LsvSelectedSubjects);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(334, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học thuộc lớp";
            // 
            // BtnRemoveOne
            // 
            this.BtnRemoveOne.AutoSize = true;
            this.BtnRemoveOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveOne.Location = new System.Drawing.Point(354, 145);
            this.BtnRemoveOne.Name = "BtnRemoveOne";
            this.BtnRemoveOne.Size = new System.Drawing.Size(75, 30);
            this.BtnRemoveOne.TabIndex = 2;
            this.BtnRemoveOne.Text = ">";
            this.BtnRemoveOne.UseVisualStyleBackColor = true;
            this.BtnRemoveOne.Click += new System.EventHandler(this.BtnRemoveOne_Click);
            // 
            // BtnRemoveAll
            // 
            this.BtnRemoveAll.AutoSize = true;
            this.BtnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveAll.Location = new System.Drawing.Point(354, 192);
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.Size = new System.Drawing.Size(75, 30);
            this.BtnRemoveAll.TabIndex = 3;
            this.BtnRemoveAll.Text = ">>";
            this.BtnRemoveAll.UseVisualStyleBackColor = true;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // BtnAddOne
            // 
            this.BtnAddOne.AutoSize = true;
            this.BtnAddOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddOne.Location = new System.Drawing.Point(354, 238);
            this.BtnAddOne.Name = "BtnAddOne";
            this.BtnAddOne.Size = new System.Drawing.Size(75, 30);
            this.BtnAddOne.TabIndex = 4;
            this.BtnAddOne.Text = "<";
            this.BtnAddOne.UseVisualStyleBackColor = true;
            this.BtnAddOne.Click += new System.EventHandler(this.BtnAddOne_Click);
            // 
            // BtnAddAll
            // 
            this.BtnAddAll.AutoSize = true;
            this.BtnAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAll.Location = new System.Drawing.Point(354, 286);
            this.BtnAddAll.Name = "BtnAddAll";
            this.BtnAddAll.Size = new System.Drawing.Size(75, 30);
            this.BtnAddAll.TabIndex = 5;
            this.BtnAddAll.Text = "<<";
            this.BtnAddAll.UseVisualStyleBackColor = true;
            this.BtnAddAll.Click += new System.EventHandler(this.BtnAddAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LsvRemainingSubjects);
            this.groupBox2.Location = new System.Drawing.Point(436, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(334, 399);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Môn học còn lại";
            // 
            // LsvRemainingSubjects
            // 
            this.LsvRemainingSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LsvRemainingSubjects.HideSelection = false;
            this.LsvRemainingSubjects.Location = new System.Drawing.Point(4, 23);
            this.LsvRemainingSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.LsvRemainingSubjects.MultiSelect = false;
            this.LsvRemainingSubjects.Name = "LsvRemainingSubjects";
            this.LsvRemainingSubjects.Size = new System.Drawing.Size(326, 372);
            this.LsvRemainingSubjects.TabIndex = 0;
            this.LsvRemainingSubjects.UseCompatibleStateImageBehavior = false;
            this.LsvRemainingSubjects.View = System.Windows.Forms.View.List;
            // 
            // FrmManageClassSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnAddAll);
            this.Controls.Add(this.BtnAddOne);
            this.Controls.Add(this.BtnRemoveAll);
            this.Controls.Add(this.BtnRemoveOne);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmManageClassSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa danh sách môn học theo lớp";
            this.Load += new System.EventHandler(this.FrmManageClassSubject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LsvSelectedSubjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRemoveOne;
        private System.Windows.Forms.Button BtnRemoveAll;
        private System.Windows.Forms.Button BtnAddOne;
        private System.Windows.Forms.Button BtnAddAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LsvRemainingSubjects;
    }
}