namespace UniversityInformation.Forms
{
    partial class LessonRecords
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
            this.lblAddStudent = new System.Windows.Forms.Label();
            this.btnAddStudents = new System.Windows.Forms.Button();
            this.checkStudentNoList = new System.Windows.Forms.CheckedListBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddStudent.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblAddStudent.Location = new System.Drawing.Point(97, 9);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(422, 34);
            this.lblAddStudent.TabIndex = 1;
            this.lblAddStudent.Text = "Derse Öğrenci eklemek için yandaki kutucuğu işaretle.\r\nÇıkarmak istedigin öğrenci" +
    " için kutucuğun işaretini kaldır.\r\n";
            // 
            // btnAddStudents
            // 
            this.btnAddStudents.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddStudents.FlatAppearance.BorderSize = 0;
            this.btnAddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudents.Location = new System.Drawing.Point(428, 86);
            this.btnAddStudents.Name = "btnAddStudents";
            this.btnAddStudents.Size = new System.Drawing.Size(206, 38);
            this.btnAddStudents.TabIndex = 2;
            this.btnAddStudents.Text = "Seçili Öğrencileri Derse Ekle";
            this.btnAddStudents.UseVisualStyleBackColor = false;
            this.btnAddStudents.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // checkStudentNoList
            // 
            this.checkStudentNoList.FormattingEnabled = true;
            this.checkStudentNoList.Items.AddRange(new object[] {
            "Test",
            "Deneme"});
            this.checkStudentNoList.Location = new System.Drawing.Point(185, 88);
            this.checkStudentNoList.Name = "checkStudentNoList";
            this.checkStudentNoList.Size = new System.Drawing.Size(210, 364);
            this.checkStudentNoList.TabIndex = 4;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSelectAll.FlatAppearance.BorderSize = 0;
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Location = new System.Drawing.Point(24, 88);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(145, 34);
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.Text = "Hepsini Seç";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.LightSalmon;
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Location = new System.Drawing.Point(24, 141);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(145, 34);
            this.btnRemoveAll.TabIndex = 6;
            this.btnRemoveAll.Text = "Hepsini kaldır";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // LessonRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(668, 473);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.checkStudentNoList);
            this.Controls.Add(this.btnAddStudents);
            this.Controls.Add(this.lblAddStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LessonRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LessonRecords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddStudent;
        private System.Windows.Forms.Button btnAddStudents;
        private System.Windows.Forms.CheckedListBox checkStudentNoList;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnRemoveAll;
    }
}