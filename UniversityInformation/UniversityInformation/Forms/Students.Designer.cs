namespace UniversityInformation.Forms
{
    partial class Students
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
            this.gbxAddStudent = new System.Windows.Forms.GroupBox();
            this.tbxAddStudentNo = new System.Windows.Forms.TextBox();
            this.lblAddStudentNo = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.cbxAddStudentMajor = new System.Windows.Forms.ComboBox();
            this.lblAddStudentMajor = new System.Windows.Forms.Label();
            this.cbxAddStudentDepartment = new System.Windows.Forms.ComboBox();
            this.lblAddStudentDepartment = new System.Windows.Forms.Label();
            this.tbxAddStudentPhone = new System.Windows.Forms.TextBox();
            this.lblAddStudentPhoneNumber = new System.Windows.Forms.Label();
            this.tbxAddStudentFirstname = new System.Windows.Forms.TextBox();
            this.lblAddStudentFirstname = new System.Windows.Forms.Label();
            this.tbxAddStudentLastname = new System.Windows.Forms.TextBox();
            this.lblAddStudentLastname = new System.Windows.Forms.Label();
            this.tbxAddStudentTc = new System.Windows.Forms.TextBox();
            this.lblAddStudentTc = new System.Windows.Forms.Label();
            this.gbxUpdateStudent = new System.Windows.Forms.GroupBox();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.tbxUpdateStudentPhone = new System.Windows.Forms.TextBox();
            this.lblUpdateStudentPhoneNumber = new System.Windows.Forms.Label();
            this.tbxUpdateStudentFirstname = new System.Windows.Forms.TextBox();
            this.lblUpdateStudentFirstname = new System.Windows.Forms.Label();
            this.tbxUpdateStudentLastname = new System.Windows.Forms.TextBox();
            this.lblUpdateStudentLastname = new System.Windows.Forms.Label();
            this.tbxUpdateStudentTc = new System.Windows.Forms.TextBox();
            this.lblUpdateStudentTc = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.gbxAddStudent.SuspendLayout();
            this.gbxUpdateStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAddStudent
            // 
            this.gbxAddStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbxAddStudent.Controls.Add(this.tbxAddStudentNo);
            this.gbxAddStudent.Controls.Add(this.lblAddStudentNo);
            this.gbxAddStudent.Controls.Add(this.btnAddStudent);
            this.gbxAddStudent.Controls.Add(this.cbxAddStudentMajor);
            this.gbxAddStudent.Controls.Add(this.lblAddStudentMajor);
            this.gbxAddStudent.Controls.Add(this.cbxAddStudentDepartment);
            this.gbxAddStudent.Controls.Add(this.lblAddStudentDepartment);
            this.gbxAddStudent.Controls.Add(this.tbxAddStudentPhone);
            this.gbxAddStudent.Controls.Add(this.lblAddStudentPhoneNumber);
            this.gbxAddStudent.Controls.Add(this.tbxAddStudentFirstname);
            this.gbxAddStudent.Controls.Add(this.lblAddStudentFirstname);
            this.gbxAddStudent.Controls.Add(this.tbxAddStudentLastname);
            this.gbxAddStudent.Controls.Add(this.lblAddStudentLastname);
            this.gbxAddStudent.Controls.Add(this.tbxAddStudentTc);
            this.gbxAddStudent.Controls.Add(this.lblAddStudentTc);
            this.gbxAddStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxAddStudent.Location = new System.Drawing.Point(81, 310);
            this.gbxAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAddStudent.Name = "gbxAddStudent";
            this.gbxAddStudent.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAddStudent.Size = new System.Drawing.Size(361, 340);
            this.gbxAddStudent.TabIndex = 1;
            this.gbxAddStudent.TabStop = false;
            this.gbxAddStudent.Text = "Yeni Öğrenci Ekle";
            // 
            // tbxAddStudentNo
            // 
            this.tbxAddStudentNo.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddStudentNo.Location = new System.Drawing.Point(147, 226);
            this.tbxAddStudentNo.MaxLength = 9;
            this.tbxAddStudentNo.Name = "tbxAddStudentNo";
            this.tbxAddStudentNo.Size = new System.Drawing.Size(207, 23);
            this.tbxAddStudentNo.TabIndex = 13;
            // 
            // lblAddStudentNo
            // 
            this.lblAddStudentNo.AutoSize = true;
            this.lblAddStudentNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddStudentNo.Location = new System.Drawing.Point(16, 229);
            this.lblAddStudentNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddStudentNo.Name = "lblAddStudentNo";
            this.lblAddStudentNo.Size = new System.Drawing.Size(126, 17);
            this.lblAddStudentNo.TabIndex = 12;
            this.lblAddStudentNo.Text = "Öğrenci Numarası:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddStudent.Location = new System.Drawing.Point(163, 304);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(159, 29);
            this.btnAddStudent.TabIndex = 11;
            this.btnAddStudent.Text = "Öğrenci Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // cbxAddStudentMajor
            // 
            this.cbxAddStudentMajor.BackColor = System.Drawing.Color.Lavender;
            this.cbxAddStudentMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddStudentMajor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAddStudentMajor.FormattingEnabled = true;
            this.cbxAddStudentMajor.Items.AddRange(new object[] {
            "Ana Bilim Dalı",
            "Çift Ana Dal"});
            this.cbxAddStudentMajor.Location = new System.Drawing.Point(147, 266);
            this.cbxAddStudentMajor.Name = "cbxAddStudentMajor";
            this.cbxAddStudentMajor.Size = new System.Drawing.Size(207, 24);
            this.cbxAddStudentMajor.TabIndex = 9;
            // 
            // lblAddStudentMajor
            // 
            this.lblAddStudentMajor.AutoSize = true;
            this.lblAddStudentMajor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddStudentMajor.Location = new System.Drawing.Point(78, 269);
            this.lblAddStudentMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddStudentMajor.Name = "lblAddStudentMajor";
            this.lblAddStudentMajor.Size = new System.Drawing.Size(62, 17);
            this.lblAddStudentMajor.TabIndex = 8;
            this.lblAddStudentMajor.Text = "Ana Dal:";
            // 
            // cbxAddStudentDepartment
            // 
            this.cbxAddStudentDepartment.BackColor = System.Drawing.Color.Lavender;
            this.cbxAddStudentDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddStudentDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAddStudentDepartment.FormattingEnabled = true;
            this.cbxAddStudentDepartment.Location = new System.Drawing.Point(147, 183);
            this.cbxAddStudentDepartment.Name = "cbxAddStudentDepartment";
            this.cbxAddStudentDepartment.Size = new System.Drawing.Size(207, 24);
            this.cbxAddStudentDepartment.TabIndex = 7;
            // 
            // lblAddStudentDepartment
            // 
            this.lblAddStudentDepartment.AutoSize = true;
            this.lblAddStudentDepartment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddStudentDepartment.Location = new System.Drawing.Point(89, 186);
            this.lblAddStudentDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddStudentDepartment.Name = "lblAddStudentDepartment";
            this.lblAddStudentDepartment.Size = new System.Drawing.Size(51, 17);
            this.lblAddStudentDepartment.TabIndex = 6;
            this.lblAddStudentDepartment.Text = "Bölüm:";
            // 
            // tbxAddStudentPhone
            // 
            this.tbxAddStudentPhone.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddStudentPhone.Location = new System.Drawing.Point(147, 144);
            this.tbxAddStudentPhone.MaxLength = 11;
            this.tbxAddStudentPhone.Name = "tbxAddStudentPhone";
            this.tbxAddStudentPhone.Size = new System.Drawing.Size(207, 23);
            this.tbxAddStudentPhone.TabIndex = 5;
            // 
            // lblAddStudentPhoneNumber
            // 
            this.lblAddStudentPhoneNumber.AutoSize = true;
            this.lblAddStudentPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddStudentPhoneNumber.Location = new System.Drawing.Point(16, 147);
            this.lblAddStudentPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddStudentPhoneNumber.Name = "lblAddStudentPhoneNumber";
            this.lblAddStudentPhoneNumber.Size = new System.Drawing.Size(124, 17);
            this.lblAddStudentPhoneNumber.TabIndex = 4;
            this.lblAddStudentPhoneNumber.Text = "Telefon Numarası:";
            // 
            // tbxAddStudentFirstname
            // 
            this.tbxAddStudentFirstname.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddStudentFirstname.Location = new System.Drawing.Point(147, 66);
            this.tbxAddStudentFirstname.MaxLength = 20;
            this.tbxAddStudentFirstname.Name = "tbxAddStudentFirstname";
            this.tbxAddStudentFirstname.Size = new System.Drawing.Size(207, 23);
            this.tbxAddStudentFirstname.TabIndex = 3;
            // 
            // lblAddStudentFirstname
            // 
            this.lblAddStudentFirstname.AutoSize = true;
            this.lblAddStudentFirstname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddStudentFirstname.Location = new System.Drawing.Point(104, 69);
            this.lblAddStudentFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddStudentFirstname.Name = "lblAddStudentFirstname";
            this.lblAddStudentFirstname.Size = new System.Drawing.Size(36, 17);
            this.lblAddStudentFirstname.TabIndex = 2;
            this.lblAddStudentFirstname.Text = "İsim:";
            // 
            // tbxAddStudentLastname
            // 
            this.tbxAddStudentLastname.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddStudentLastname.Location = new System.Drawing.Point(147, 105);
            this.tbxAddStudentLastname.MaxLength = 20;
            this.tbxAddStudentLastname.Name = "tbxAddStudentLastname";
            this.tbxAddStudentLastname.Size = new System.Drawing.Size(207, 23);
            this.tbxAddStudentLastname.TabIndex = 3;
            // 
            // lblAddStudentLastname
            // 
            this.lblAddStudentLastname.AutoSize = true;
            this.lblAddStudentLastname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddStudentLastname.Location = new System.Drawing.Point(80, 108);
            this.lblAddStudentLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddStudentLastname.Name = "lblAddStudentLastname";
            this.lblAddStudentLastname.Size = new System.Drawing.Size(60, 17);
            this.lblAddStudentLastname.TabIndex = 2;
            this.lblAddStudentLastname.Text = "Soyisim:";
            // 
            // tbxAddStudentTc
            // 
            this.tbxAddStudentTc.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddStudentTc.Location = new System.Drawing.Point(147, 28);
            this.tbxAddStudentTc.MaxLength = 11;
            this.tbxAddStudentTc.Name = "tbxAddStudentTc";
            this.tbxAddStudentTc.Size = new System.Drawing.Size(207, 23);
            this.tbxAddStudentTc.TabIndex = 1;
            // 
            // lblAddStudentTc
            // 
            this.lblAddStudentTc.AutoSize = true;
            this.lblAddStudentTc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddStudentTc.Location = new System.Drawing.Point(8, 31);
            this.lblAddStudentTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddStudentTc.Name = "lblAddStudentTc";
            this.lblAddStudentTc.Size = new System.Drawing.Size(132, 17);
            this.lblAddStudentTc.TabIndex = 0;
            this.lblAddStudentTc.Text = "Tc Kimlik Numarası:";
            // 
            // gbxUpdateStudent
            // 
            this.gbxUpdateStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbxUpdateStudent.Controls.Add(this.btnUpdateStudent);
            this.gbxUpdateStudent.Controls.Add(this.tbxUpdateStudentPhone);
            this.gbxUpdateStudent.Controls.Add(this.lblUpdateStudentPhoneNumber);
            this.gbxUpdateStudent.Controls.Add(this.tbxUpdateStudentFirstname);
            this.gbxUpdateStudent.Controls.Add(this.lblUpdateStudentFirstname);
            this.gbxUpdateStudent.Controls.Add(this.tbxUpdateStudentLastname);
            this.gbxUpdateStudent.Controls.Add(this.lblUpdateStudentLastname);
            this.gbxUpdateStudent.Controls.Add(this.tbxUpdateStudentTc);
            this.gbxUpdateStudent.Controls.Add(this.lblUpdateStudentTc);
            this.gbxUpdateStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxUpdateStudent.Location = new System.Drawing.Point(513, 310);
            this.gbxUpdateStudent.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUpdateStudent.Name = "gbxUpdateStudent";
            this.gbxUpdateStudent.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUpdateStudent.Size = new System.Drawing.Size(361, 233);
            this.gbxUpdateStudent.TabIndex = 12;
            this.gbxUpdateStudent.TabStop = false;
            this.gbxUpdateStudent.Text = "Öğrenciyi Güncelle";
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateStudent.Location = new System.Drawing.Point(147, 186);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(159, 29);
            this.btnUpdateStudent.TabIndex = 11;
            this.btnUpdateStudent.Text = "Öğrenci Güncelle";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // tbxUpdateStudentPhone
            // 
            this.tbxUpdateStudentPhone.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateStudentPhone.Location = new System.Drawing.Point(147, 144);
            this.tbxUpdateStudentPhone.MaxLength = 11;
            this.tbxUpdateStudentPhone.Name = "tbxUpdateStudentPhone";
            this.tbxUpdateStudentPhone.Size = new System.Drawing.Size(207, 23);
            this.tbxUpdateStudentPhone.TabIndex = 5;
            // 
            // lblUpdateStudentPhoneNumber
            // 
            this.lblUpdateStudentPhoneNumber.AutoSize = true;
            this.lblUpdateStudentPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateStudentPhoneNumber.Location = new System.Drawing.Point(16, 147);
            this.lblUpdateStudentPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateStudentPhoneNumber.Name = "lblUpdateStudentPhoneNumber";
            this.lblUpdateStudentPhoneNumber.Size = new System.Drawing.Size(124, 17);
            this.lblUpdateStudentPhoneNumber.TabIndex = 4;
            this.lblUpdateStudentPhoneNumber.Text = "Telefon Numarası:";
            // 
            // tbxUpdateStudentFirstname
            // 
            this.tbxUpdateStudentFirstname.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateStudentFirstname.Location = new System.Drawing.Point(147, 66);
            this.tbxUpdateStudentFirstname.MaxLength = 20;
            this.tbxUpdateStudentFirstname.Name = "tbxUpdateStudentFirstname";
            this.tbxUpdateStudentFirstname.Size = new System.Drawing.Size(207, 23);
            this.tbxUpdateStudentFirstname.TabIndex = 3;
            // 
            // lblUpdateStudentFirstname
            // 
            this.lblUpdateStudentFirstname.AutoSize = true;
            this.lblUpdateStudentFirstname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateStudentFirstname.Location = new System.Drawing.Point(104, 69);
            this.lblUpdateStudentFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateStudentFirstname.Name = "lblUpdateStudentFirstname";
            this.lblUpdateStudentFirstname.Size = new System.Drawing.Size(36, 17);
            this.lblUpdateStudentFirstname.TabIndex = 2;
            this.lblUpdateStudentFirstname.Text = "İsim:";
            // 
            // tbxUpdateStudentLastname
            // 
            this.tbxUpdateStudentLastname.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateStudentLastname.Location = new System.Drawing.Point(147, 105);
            this.tbxUpdateStudentLastname.MaxLength = 20;
            this.tbxUpdateStudentLastname.Name = "tbxUpdateStudentLastname";
            this.tbxUpdateStudentLastname.Size = new System.Drawing.Size(207, 23);
            this.tbxUpdateStudentLastname.TabIndex = 3;
            // 
            // lblUpdateStudentLastname
            // 
            this.lblUpdateStudentLastname.AutoSize = true;
            this.lblUpdateStudentLastname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateStudentLastname.Location = new System.Drawing.Point(80, 108);
            this.lblUpdateStudentLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateStudentLastname.Name = "lblUpdateStudentLastname";
            this.lblUpdateStudentLastname.Size = new System.Drawing.Size(60, 17);
            this.lblUpdateStudentLastname.TabIndex = 2;
            this.lblUpdateStudentLastname.Text = "Soyisim:";
            // 
            // tbxUpdateStudentTc
            // 
            this.tbxUpdateStudentTc.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateStudentTc.Location = new System.Drawing.Point(147, 28);
            this.tbxUpdateStudentTc.MaxLength = 11;
            this.tbxUpdateStudentTc.Name = "tbxUpdateStudentTc";
            this.tbxUpdateStudentTc.Size = new System.Drawing.Size(207, 23);
            this.tbxUpdateStudentTc.TabIndex = 1;
            // 
            // lblUpdateStudentTc
            // 
            this.lblUpdateStudentTc.AutoSize = true;
            this.lblUpdateStudentTc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateStudentTc.Location = new System.Drawing.Point(8, 31);
            this.lblUpdateStudentTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateStudentTc.Name = "lblUpdateStudentTc";
            this.lblUpdateStudentTc.Size = new System.Drawing.Size(132, 17);
            this.lblUpdateStudentTc.TabIndex = 0;
            this.lblUpdateStudentTc.Text = "Tc Kimlik Numarası:";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteStudent.Location = new System.Drawing.Point(926, 333);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(159, 32);
            this.btnDeleteStudent.TabIndex = 13;
            this.btnDeleteStudent.Text = "Öğrenciyi Sil";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // dgwStudents
            // 
            this.dgwStudents.AllowUserToResizeColumns = false;
            this.dgwStudents.AllowUserToResizeRows = false;
            this.dgwStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwStudents.ColumnHeadersHeight = 30;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwStudents.EnableHeadersVisualStyles = false;
            this.dgwStudents.GridColor = System.Drawing.SystemColors.Menu;
            this.dgwStudents.Location = new System.Drawing.Point(81, 14);
            this.dgwStudents.Margin = new System.Windows.Forms.Padding(5);
            this.dgwStudents.MultiSelect = false;
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.ReadOnly = true;
            this.dgwStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwStudents.RowHeadersVisible = false;
            this.dgwStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwStudents.RowTemplate.Height = 30;
            this.dgwStudents.RowTemplate.ReadOnly = true;
            this.dgwStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwStudents.Size = new System.Drawing.Size(1004, 274);
            this.dgwStudents.TabIndex = 14;
            this.dgwStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudents_CellClick);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1151, 677);
            this.Controls.Add(this.dgwStudents);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.gbxUpdateStudent);
            this.Controls.Add(this.gbxAddStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Students";
            this.Text = "Students";
            this.VisibleChanged += new System.EventHandler(this.Students_VisibleChanged);
            this.gbxAddStudent.ResumeLayout(false);
            this.gbxAddStudent.PerformLayout();
            this.gbxUpdateStudent.ResumeLayout(false);
            this.gbxUpdateStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxAddStudent;
        private System.Windows.Forms.Label lblAddStudentTc;
        private System.Windows.Forms.ComboBox cbxAddStudentMajor;
        private System.Windows.Forms.Label lblAddStudentMajor;
        private System.Windows.Forms.ComboBox cbxAddStudentDepartment;
        private System.Windows.Forms.Label lblAddStudentDepartment;
        private System.Windows.Forms.TextBox tbxAddStudentPhone;
        private System.Windows.Forms.Label lblAddStudentPhoneNumber;
        private System.Windows.Forms.TextBox tbxAddStudentFirstname;
        private System.Windows.Forms.Label lblAddStudentFirstname;
        private System.Windows.Forms.TextBox tbxAddStudentLastname;
        private System.Windows.Forms.Label lblAddStudentLastname;
        private System.Windows.Forms.TextBox tbxAddStudentTc;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.GroupBox gbxUpdateStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.TextBox tbxUpdateStudentPhone;
        private System.Windows.Forms.Label lblUpdateStudentPhoneNumber;
        private System.Windows.Forms.TextBox tbxUpdateStudentFirstname;
        private System.Windows.Forms.Label lblUpdateStudentFirstname;
        private System.Windows.Forms.TextBox tbxUpdateStudentLastname;
        private System.Windows.Forms.Label lblUpdateStudentLastname;
        private System.Windows.Forms.TextBox tbxUpdateStudentTc;
        private System.Windows.Forms.Label lblUpdateStudentTc;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.TextBox tbxAddStudentNo;
        private System.Windows.Forms.Label lblAddStudentNo;
        private System.Windows.Forms.DataGridView dgwStudents;
    }
}