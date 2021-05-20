namespace UniversityInformation.Forms
{
    partial class Lecturers
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
            this.gbxAddLecturer = new System.Windows.Forms.GroupBox();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.cbxAddLecturerDepartment = new System.Windows.Forms.ComboBox();
            this.lblAddLecturerDepartment = new System.Windows.Forms.Label();
            this.tbxAddLecturerFirstname = new System.Windows.Forms.TextBox();
            this.lblAddLecturerFirstname = new System.Windows.Forms.Label();
            this.tbxAddLecturerLastname = new System.Windows.Forms.TextBox();
            this.lblAddLecturerLastname = new System.Windows.Forms.Label();
            this.tbxAddLecturerIdentityNo = new System.Windows.Forms.TextBox();
            this.lblAddLecturerIdentityNo = new System.Windows.Forms.Label();
            this.gbxUpdateLecturer = new System.Windows.Forms.GroupBox();
            this.cbxUpdateLecturerDepartment = new System.Windows.Forms.ComboBox();
            this.lblUpdateLecturerDepartment = new System.Windows.Forms.Label();
            this.btnUpdateLecturer = new System.Windows.Forms.Button();
            this.tbxUpdateLecturerFirstname = new System.Windows.Forms.TextBox();
            this.lblUpdateLecturerFirstname = new System.Windows.Forms.Label();
            this.tbxUpdateLecturerLastname = new System.Windows.Forms.TextBox();
            this.lblUpdateLecturerLastname = new System.Windows.Forms.Label();
            this.tbxUpdateLecturerIdentityNo = new System.Windows.Forms.TextBox();
            this.lblUpdateLecturerIdentityNo = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.dgwLecturers = new System.Windows.Forms.DataGridView();
            this.gbxAddLecturer.SuspendLayout();
            this.gbxUpdateLecturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAddLecturer
            // 
            this.gbxAddLecturer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbxAddLecturer.Controls.Add(this.btnAddLecturer);
            this.gbxAddLecturer.Controls.Add(this.cbxAddLecturerDepartment);
            this.gbxAddLecturer.Controls.Add(this.lblAddLecturerDepartment);
            this.gbxAddLecturer.Controls.Add(this.tbxAddLecturerFirstname);
            this.gbxAddLecturer.Controls.Add(this.lblAddLecturerFirstname);
            this.gbxAddLecturer.Controls.Add(this.tbxAddLecturerLastname);
            this.gbxAddLecturer.Controls.Add(this.lblAddLecturerLastname);
            this.gbxAddLecturer.Controls.Add(this.tbxAddLecturerIdentityNo);
            this.gbxAddLecturer.Controls.Add(this.lblAddLecturerIdentityNo);
            this.gbxAddLecturer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxAddLecturer.Location = new System.Drawing.Point(94, 324);
            this.gbxAddLecturer.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAddLecturer.Name = "gbxAddLecturer";
            this.gbxAddLecturer.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAddLecturer.Size = new System.Drawing.Size(361, 255);
            this.gbxAddLecturer.TabIndex = 2;
            this.gbxAddLecturer.TabStop = false;
            this.gbxAddLecturer.Text = "Yeni Öğretim Görevlisi Ekle";
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAddLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLecturer.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddLecturer.Location = new System.Drawing.Point(147, 196);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(207, 29);
            this.btnAddLecturer.TabIndex = 11;
            this.btnAddLecturer.Text = "Öğretim Üyesi Ekle";
            this.btnAddLecturer.UseVisualStyleBackColor = false;
            this.btnAddLecturer.Click += new System.EventHandler(this.btnAddLecturer_Click);
            // 
            // cbxAddLecturerDepartment
            // 
            this.cbxAddLecturerDepartment.BackColor = System.Drawing.Color.Lavender;
            this.cbxAddLecturerDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddLecturerDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAddLecturerDepartment.FormattingEnabled = true;
            this.cbxAddLecturerDepartment.Location = new System.Drawing.Point(147, 146);
            this.cbxAddLecturerDepartment.Name = "cbxAddLecturerDepartment";
            this.cbxAddLecturerDepartment.Size = new System.Drawing.Size(207, 24);
            this.cbxAddLecturerDepartment.TabIndex = 7;
            // 
            // lblAddLecturerDepartment
            // 
            this.lblAddLecturerDepartment.AutoSize = true;
            this.lblAddLecturerDepartment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddLecturerDepartment.Location = new System.Drawing.Point(89, 149);
            this.lblAddLecturerDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddLecturerDepartment.Name = "lblAddLecturerDepartment";
            this.lblAddLecturerDepartment.Size = new System.Drawing.Size(51, 17);
            this.lblAddLecturerDepartment.TabIndex = 6;
            this.lblAddLecturerDepartment.Text = "Bölüm:";
            // 
            // tbxAddLecturerFirstname
            // 
            this.tbxAddLecturerFirstname.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddLecturerFirstname.Location = new System.Drawing.Point(147, 66);
            this.tbxAddLecturerFirstname.MaxLength = 20;
            this.tbxAddLecturerFirstname.Name = "tbxAddLecturerFirstname";
            this.tbxAddLecturerFirstname.Size = new System.Drawing.Size(207, 23);
            this.tbxAddLecturerFirstname.TabIndex = 3;
            // 
            // lblAddLecturerFirstname
            // 
            this.lblAddLecturerFirstname.AutoSize = true;
            this.lblAddLecturerFirstname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddLecturerFirstname.Location = new System.Drawing.Point(104, 69);
            this.lblAddLecturerFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddLecturerFirstname.Name = "lblAddLecturerFirstname";
            this.lblAddLecturerFirstname.Size = new System.Drawing.Size(36, 17);
            this.lblAddLecturerFirstname.TabIndex = 2;
            this.lblAddLecturerFirstname.Text = "İsim:";
            // 
            // tbxAddLecturerLastname
            // 
            this.tbxAddLecturerLastname.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddLecturerLastname.Location = new System.Drawing.Point(147, 105);
            this.tbxAddLecturerLastname.MaxLength = 20;
            this.tbxAddLecturerLastname.Name = "tbxAddLecturerLastname";
            this.tbxAddLecturerLastname.Size = new System.Drawing.Size(207, 23);
            this.tbxAddLecturerLastname.TabIndex = 3;
            // 
            // lblAddLecturerLastname
            // 
            this.lblAddLecturerLastname.AutoSize = true;
            this.lblAddLecturerLastname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddLecturerLastname.Location = new System.Drawing.Point(80, 108);
            this.lblAddLecturerLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddLecturerLastname.Name = "lblAddLecturerLastname";
            this.lblAddLecturerLastname.Size = new System.Drawing.Size(60, 17);
            this.lblAddLecturerLastname.TabIndex = 2;
            this.lblAddLecturerLastname.Text = "Soyisim:";
            // 
            // tbxAddLecturerIdentityNo
            // 
            this.tbxAddLecturerIdentityNo.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddLecturerIdentityNo.Location = new System.Drawing.Point(147, 28);
            this.tbxAddLecturerIdentityNo.MaxLength = 4;
            this.tbxAddLecturerIdentityNo.Name = "tbxAddLecturerIdentityNo";
            this.tbxAddLecturerIdentityNo.Size = new System.Drawing.Size(207, 23);
            this.tbxAddLecturerIdentityNo.TabIndex = 1;
            // 
            // lblAddLecturerIdentityNo
            // 
            this.lblAddLecturerIdentityNo.AutoSize = true;
            this.lblAddLecturerIdentityNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddLecturerIdentityNo.Location = new System.Drawing.Point(39, 31);
            this.lblAddLecturerIdentityNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddLecturerIdentityNo.Name = "lblAddLecturerIdentityNo";
            this.lblAddLecturerIdentityNo.Size = new System.Drawing.Size(101, 17);
            this.lblAddLecturerIdentityNo.TabIndex = 0;
            this.lblAddLecturerIdentityNo.Text = "Sicil Numarası:";
            // 
            // gbxUpdateLecturer
            // 
            this.gbxUpdateLecturer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbxUpdateLecturer.Controls.Add(this.cbxUpdateLecturerDepartment);
            this.gbxUpdateLecturer.Controls.Add(this.lblUpdateLecturerDepartment);
            this.gbxUpdateLecturer.Controls.Add(this.btnUpdateLecturer);
            this.gbxUpdateLecturer.Controls.Add(this.tbxUpdateLecturerFirstname);
            this.gbxUpdateLecturer.Controls.Add(this.lblUpdateLecturerFirstname);
            this.gbxUpdateLecturer.Controls.Add(this.tbxUpdateLecturerLastname);
            this.gbxUpdateLecturer.Controls.Add(this.lblUpdateLecturerLastname);
            this.gbxUpdateLecturer.Controls.Add(this.tbxUpdateLecturerIdentityNo);
            this.gbxUpdateLecturer.Controls.Add(this.lblUpdateLecturerIdentityNo);
            this.gbxUpdateLecturer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxUpdateLecturer.Location = new System.Drawing.Point(494, 324);
            this.gbxUpdateLecturer.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUpdateLecturer.Name = "gbxUpdateLecturer";
            this.gbxUpdateLecturer.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUpdateLecturer.Size = new System.Drawing.Size(361, 255);
            this.gbxUpdateLecturer.TabIndex = 13;
            this.gbxUpdateLecturer.TabStop = false;
            this.gbxUpdateLecturer.Text = "Öğrenciyi Güncelle";
            // 
            // cbxUpdateLecturerDepartment
            // 
            this.cbxUpdateLecturerDepartment.BackColor = System.Drawing.Color.Lavender;
            this.cbxUpdateLecturerDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUpdateLecturerDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUpdateLecturerDepartment.FormattingEnabled = true;
            this.cbxUpdateLecturerDepartment.Location = new System.Drawing.Point(147, 149);
            this.cbxUpdateLecturerDepartment.Name = "cbxUpdateLecturerDepartment";
            this.cbxUpdateLecturerDepartment.Size = new System.Drawing.Size(207, 24);
            this.cbxUpdateLecturerDepartment.TabIndex = 13;
            // 
            // lblUpdateLecturerDepartment
            // 
            this.lblUpdateLecturerDepartment.AutoSize = true;
            this.lblUpdateLecturerDepartment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateLecturerDepartment.Location = new System.Drawing.Point(89, 152);
            this.lblUpdateLecturerDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateLecturerDepartment.Name = "lblUpdateLecturerDepartment";
            this.lblUpdateLecturerDepartment.Size = new System.Drawing.Size(51, 17);
            this.lblUpdateLecturerDepartment.TabIndex = 12;
            this.lblUpdateLecturerDepartment.Text = "Bölüm:";
            // 
            // btnUpdateLecturer
            // 
            this.btnUpdateLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUpdateLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLecturer.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateLecturer.Location = new System.Drawing.Point(147, 196);
            this.btnUpdateLecturer.Name = "btnUpdateLecturer";
            this.btnUpdateLecturer.Size = new System.Drawing.Size(207, 29);
            this.btnUpdateLecturer.TabIndex = 11;
            this.btnUpdateLecturer.Text = "Öğretim Üyesini Güncelle";
            this.btnUpdateLecturer.UseVisualStyleBackColor = false;
            this.btnUpdateLecturer.Click += new System.EventHandler(this.btnUpdateLecturer_Click);
            // 
            // tbxUpdateLecturerFirstname
            // 
            this.tbxUpdateLecturerFirstname.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateLecturerFirstname.Location = new System.Drawing.Point(147, 66);
            this.tbxUpdateLecturerFirstname.MaxLength = 20;
            this.tbxUpdateLecturerFirstname.Name = "tbxUpdateLecturerFirstname";
            this.tbxUpdateLecturerFirstname.Size = new System.Drawing.Size(207, 23);
            this.tbxUpdateLecturerFirstname.TabIndex = 3;
            // 
            // lblUpdateLecturerFirstname
            // 
            this.lblUpdateLecturerFirstname.AutoSize = true;
            this.lblUpdateLecturerFirstname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateLecturerFirstname.Location = new System.Drawing.Point(104, 69);
            this.lblUpdateLecturerFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateLecturerFirstname.Name = "lblUpdateLecturerFirstname";
            this.lblUpdateLecturerFirstname.Size = new System.Drawing.Size(36, 17);
            this.lblUpdateLecturerFirstname.TabIndex = 2;
            this.lblUpdateLecturerFirstname.Text = "İsim:";
            // 
            // tbxUpdateLecturerLastname
            // 
            this.tbxUpdateLecturerLastname.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateLecturerLastname.Location = new System.Drawing.Point(147, 105);
            this.tbxUpdateLecturerLastname.MaxLength = 20;
            this.tbxUpdateLecturerLastname.Name = "tbxUpdateLecturerLastname";
            this.tbxUpdateLecturerLastname.Size = new System.Drawing.Size(207, 23);
            this.tbxUpdateLecturerLastname.TabIndex = 3;
            // 
            // lblUpdateLecturerLastname
            // 
            this.lblUpdateLecturerLastname.AutoSize = true;
            this.lblUpdateLecturerLastname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateLecturerLastname.Location = new System.Drawing.Point(80, 108);
            this.lblUpdateLecturerLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateLecturerLastname.Name = "lblUpdateLecturerLastname";
            this.lblUpdateLecturerLastname.Size = new System.Drawing.Size(60, 17);
            this.lblUpdateLecturerLastname.TabIndex = 2;
            this.lblUpdateLecturerLastname.Text = "Soyisim:";
            // 
            // tbxUpdateLecturerIdentityNo
            // 
            this.tbxUpdateLecturerIdentityNo.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateLecturerIdentityNo.Location = new System.Drawing.Point(147, 28);
            this.tbxUpdateLecturerIdentityNo.MaxLength = 4;
            this.tbxUpdateLecturerIdentityNo.Name = "tbxUpdateLecturerIdentityNo";
            this.tbxUpdateLecturerIdentityNo.Size = new System.Drawing.Size(207, 23);
            this.tbxUpdateLecturerIdentityNo.TabIndex = 1;
            // 
            // lblUpdateLecturerIdentityNo
            // 
            this.lblUpdateLecturerIdentityNo.AutoSize = true;
            this.lblUpdateLecturerIdentityNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateLecturerIdentityNo.Location = new System.Drawing.Point(39, 31);
            this.lblUpdateLecturerIdentityNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateLecturerIdentityNo.Name = "lblUpdateLecturerIdentityNo";
            this.lblUpdateLecturerIdentityNo.Size = new System.Drawing.Size(101, 17);
            this.lblUpdateLecturerIdentityNo.TabIndex = 0;
            this.lblUpdateLecturerIdentityNo.Text = "Sicil Numarası:";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteStudent.Location = new System.Drawing.Point(886, 324);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(172, 33);
            this.btnDeleteStudent.TabIndex = 14;
            this.btnDeleteStudent.Text = "Öğretim Görevlisini Sil";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // dgwLecturers
            // 
            this.dgwLecturers.AllowUserToResizeColumns = false;
            this.dgwLecturers.AllowUserToResizeRows = false;
            this.dgwLecturers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwLecturers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLecturers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwLecturers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwLecturers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwLecturers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLecturers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwLecturers.ColumnHeadersHeight = 30;
            this.dgwLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwLecturers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwLecturers.EnableHeadersVisualStyles = false;
            this.dgwLecturers.GridColor = System.Drawing.SystemColors.Menu;
            this.dgwLecturers.Location = new System.Drawing.Point(94, 31);
            this.dgwLecturers.Margin = new System.Windows.Forms.Padding(5);
            this.dgwLecturers.MultiSelect = false;
            this.dgwLecturers.Name = "dgwLecturers";
            this.dgwLecturers.ReadOnly = true;
            this.dgwLecturers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwLecturers.RowHeadersVisible = false;
            this.dgwLecturers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwLecturers.RowTemplate.Height = 30;
            this.dgwLecturers.RowTemplate.ReadOnly = true;
            this.dgwLecturers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwLecturers.Size = new System.Drawing.Size(964, 260);
            this.dgwLecturers.TabIndex = 15;
            this.dgwLecturers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLecturers_CellClick);
            // 
            // Lecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(71)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1151, 677);
            this.Controls.Add(this.dgwLecturers);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.gbxUpdateLecturer);
            this.Controls.Add(this.gbxAddLecturer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lecturers";
            this.Text = "Lecturers";
            this.VisibleChanged += new System.EventHandler(this.Lecturers_VisibleChanged);
            this.gbxAddLecturer.ResumeLayout(false);
            this.gbxAddLecturer.PerformLayout();
            this.gbxUpdateLecturer.ResumeLayout(false);
            this.gbxUpdateLecturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLecturers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxAddLecturer;
        private System.Windows.Forms.Button btnAddLecturer;
        private System.Windows.Forms.ComboBox cbxAddLecturerDepartment;
        private System.Windows.Forms.Label lblAddLecturerDepartment;
        private System.Windows.Forms.TextBox tbxAddLecturerFirstname;
        private System.Windows.Forms.Label lblAddLecturerFirstname;
        private System.Windows.Forms.TextBox tbxAddLecturerLastname;
        private System.Windows.Forms.Label lblAddLecturerLastname;
        private System.Windows.Forms.TextBox tbxAddLecturerIdentityNo;
        private System.Windows.Forms.Label lblAddLecturerIdentityNo;
        private System.Windows.Forms.GroupBox gbxUpdateLecturer;
        private System.Windows.Forms.ComboBox cbxUpdateLecturerDepartment;
        private System.Windows.Forms.Label lblUpdateLecturerDepartment;
        private System.Windows.Forms.Button btnUpdateLecturer;
        private System.Windows.Forms.TextBox tbxUpdateLecturerFirstname;
        private System.Windows.Forms.Label lblUpdateLecturerFirstname;
        private System.Windows.Forms.TextBox tbxUpdateLecturerLastname;
        private System.Windows.Forms.Label lblUpdateLecturerLastname;
        private System.Windows.Forms.TextBox tbxUpdateLecturerIdentityNo;
        private System.Windows.Forms.Label lblUpdateLecturerIdentityNo;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.DataGridView dgwLecturers;
    }
}