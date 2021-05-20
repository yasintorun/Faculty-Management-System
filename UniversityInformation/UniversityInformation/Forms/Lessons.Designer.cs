namespace UniversityInformation.Forms
{
    partial class Lessons
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
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.gbxUpdateLesson = new System.Windows.Forms.GroupBox();
            this.cbxUpdateLessonLecturer = new System.Windows.Forms.ComboBox();
            this.lblUpdateLessonLecturer = new System.Windows.Forms.Label();
            this.cbxUpdateLessonDepartment = new System.Windows.Forms.ComboBox();
            this.lblUpdateLessonDepartment = new System.Windows.Forms.Label();
            this.btnUpdateLesson = new System.Windows.Forms.Button();
            this.tbxUpdateLessonCredit = new System.Windows.Forms.TextBox();
            this.lblUpdateLessonCredit = new System.Windows.Forms.Label();
            this.tbxUpdateLessonClassroom = new System.Windows.Forms.TextBox();
            this.lblUpdateLessonClassroom = new System.Windows.Forms.Label();
            this.tbxUpdateLessonCode = new System.Windows.Forms.TextBox();
            this.lblUpdateLessonCode = new System.Windows.Forms.Label();
            this.gbxAddLesson = new System.Windows.Forms.GroupBox();
            this.cbxAddLessonLecturer = new System.Windows.Forms.ComboBox();
            this.lblAddLessonLecturer = new System.Windows.Forms.Label();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.cbxAddLessonDepartment = new System.Windows.Forms.ComboBox();
            this.lblAddLessonDepartment = new System.Windows.Forms.Label();
            this.tbxAddLessonCredit = new System.Windows.Forms.TextBox();
            this.lblAddLessonCredit = new System.Windows.Forms.Label();
            this.tbxAddLessonClassroom = new System.Windows.Forms.TextBox();
            this.lblAddLessonClassroom = new System.Windows.Forms.Label();
            this.tbxAddLessonCode = new System.Windows.Forms.TextBox();
            this.lblAddLessonCode = new System.Windows.Forms.Label();
            this.btnAddStudentToLesson = new System.Windows.Forms.Button();
            this.dgwLessons = new System.Windows.Forms.DataGridView();
            this.gbxUpdateLesson.SuspendLayout();
            this.gbxAddLesson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteLesson.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLesson.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteLesson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteLesson.Location = new System.Drawing.Point(885, 337);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(172, 33);
            this.btnDeleteLesson.TabIndex = 18;
            this.btnDeleteLesson.Text = "Dersi Sil";
            this.btnDeleteLesson.UseVisualStyleBackColor = false;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // gbxUpdateLesson
            // 
            this.gbxUpdateLesson.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbxUpdateLesson.Controls.Add(this.cbxUpdateLessonLecturer);
            this.gbxUpdateLesson.Controls.Add(this.lblUpdateLessonLecturer);
            this.gbxUpdateLesson.Controls.Add(this.cbxUpdateLessonDepartment);
            this.gbxUpdateLesson.Controls.Add(this.lblUpdateLessonDepartment);
            this.gbxUpdateLesson.Controls.Add(this.btnUpdateLesson);
            this.gbxUpdateLesson.Controls.Add(this.tbxUpdateLessonCredit);
            this.gbxUpdateLesson.Controls.Add(this.lblUpdateLessonCredit);
            this.gbxUpdateLesson.Controls.Add(this.tbxUpdateLessonClassroom);
            this.gbxUpdateLesson.Controls.Add(this.lblUpdateLessonClassroom);
            this.gbxUpdateLesson.Controls.Add(this.tbxUpdateLessonCode);
            this.gbxUpdateLesson.Controls.Add(this.lblUpdateLessonCode);
            this.gbxUpdateLesson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxUpdateLesson.Location = new System.Drawing.Point(493, 337);
            this.gbxUpdateLesson.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUpdateLesson.Name = "gbxUpdateLesson";
            this.gbxUpdateLesson.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUpdateLesson.Size = new System.Drawing.Size(361, 289);
            this.gbxUpdateLesson.TabIndex = 17;
            this.gbxUpdateLesson.TabStop = false;
            this.gbxUpdateLesson.Text = "Öğrenciyi Güncelle";
            // 
            // cbxUpdateLessonLecturer
            // 
            this.cbxUpdateLessonLecturer.BackColor = System.Drawing.Color.Lavender;
            this.cbxUpdateLessonLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUpdateLessonLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUpdateLessonLecturer.FormattingEnabled = true;
            this.cbxUpdateLessonLecturer.Location = new System.Drawing.Point(147, 190);
            this.cbxUpdateLessonLecturer.Name = "cbxUpdateLessonLecturer";
            this.cbxUpdateLessonLecturer.Size = new System.Drawing.Size(207, 24);
            this.cbxUpdateLessonLecturer.TabIndex = 15;
            // 
            // lblUpdateLessonLecturer
            // 
            this.lblUpdateLessonLecturer.AutoSize = true;
            this.lblUpdateLessonLecturer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateLessonLecturer.Location = new System.Drawing.Point(39, 193);
            this.lblUpdateLessonLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateLessonLecturer.Name = "lblUpdateLessonLecturer";
            this.lblUpdateLessonLecturer.Size = new System.Drawing.Size(101, 17);
            this.lblUpdateLessonLecturer.TabIndex = 14;
            this.lblUpdateLessonLecturer.Text = "Öğretim Üyesi:";
            // 
            // cbxUpdateLessonDepartment
            // 
            this.cbxUpdateLessonDepartment.BackColor = System.Drawing.Color.Lavender;
            this.cbxUpdateLessonDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUpdateLessonDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUpdateLessonDepartment.FormattingEnabled = true;
            this.cbxUpdateLessonDepartment.Location = new System.Drawing.Point(147, 149);
            this.cbxUpdateLessonDepartment.Name = "cbxUpdateLessonDepartment";
            this.cbxUpdateLessonDepartment.Size = new System.Drawing.Size(207, 24);
            this.cbxUpdateLessonDepartment.TabIndex = 13;
            this.cbxUpdateLessonDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxUpdateLessonDepartment_SelectedIndexChanged);
            // 
            // lblUpdateLessonDepartment
            // 
            this.lblUpdateLessonDepartment.AutoSize = true;
            this.lblUpdateLessonDepartment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateLessonDepartment.Location = new System.Drawing.Point(89, 152);
            this.lblUpdateLessonDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateLessonDepartment.Name = "lblUpdateLessonDepartment";
            this.lblUpdateLessonDepartment.Size = new System.Drawing.Size(51, 17);
            this.lblUpdateLessonDepartment.TabIndex = 12;
            this.lblUpdateLessonDepartment.Text = "Bölüm:";
            // 
            // btnUpdateLesson
            // 
            this.btnUpdateLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUpdateLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLesson.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateLesson.Location = new System.Drawing.Point(147, 233);
            this.btnUpdateLesson.Name = "btnUpdateLesson";
            this.btnUpdateLesson.Size = new System.Drawing.Size(207, 29);
            this.btnUpdateLesson.TabIndex = 11;
            this.btnUpdateLesson.Text = "Dersi Güncelle";
            this.btnUpdateLesson.UseVisualStyleBackColor = false;
            this.btnUpdateLesson.Click += new System.EventHandler(this.btnUpdateLesson_Click);
            // 
            // tbxUpdateLessonCredit
            // 
            this.tbxUpdateLessonCredit.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateLessonCredit.Location = new System.Drawing.Point(147, 66);
            this.tbxUpdateLessonCredit.MaxLength = 2;
            this.tbxUpdateLessonCredit.Name = "tbxUpdateLessonCredit";
            this.tbxUpdateLessonCredit.Size = new System.Drawing.Size(207, 23);
            this.tbxUpdateLessonCredit.TabIndex = 3;
            // 
            // lblUpdateLessonCredit
            // 
            this.lblUpdateLessonCredit.AutoSize = true;
            this.lblUpdateLessonCredit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateLessonCredit.Location = new System.Drawing.Point(51, 69);
            this.lblUpdateLessonCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateLessonCredit.Name = "lblUpdateLessonCredit";
            this.lblUpdateLessonCredit.Size = new System.Drawing.Size(89, 17);
            this.lblUpdateLessonCredit.TabIndex = 2;
            this.lblUpdateLessonCredit.Text = "Ders Kredisi:";
            // 
            // tbxUpdateLessonClassroom
            // 
            this.tbxUpdateLessonClassroom.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateLessonClassroom.Location = new System.Drawing.Point(147, 105);
            this.tbxUpdateLessonClassroom.MaxLength = 2;
            this.tbxUpdateLessonClassroom.Name = "tbxUpdateLessonClassroom";
            this.tbxUpdateLessonClassroom.Size = new System.Drawing.Size(207, 23);
            this.tbxUpdateLessonClassroom.TabIndex = 3;
            // 
            // lblUpdateLessonClassroom
            // 
            this.lblUpdateLessonClassroom.AutoSize = true;
            this.lblUpdateLessonClassroom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateLessonClassroom.Location = new System.Drawing.Point(85, 108);
            this.lblUpdateLessonClassroom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateLessonClassroom.Name = "lblUpdateLessonClassroom";
            this.lblUpdateLessonClassroom.Size = new System.Drawing.Size(55, 17);
            this.lblUpdateLessonClassroom.TabIndex = 2;
            this.lblUpdateLessonClassroom.Text = "Derslik:";
            // 
            // tbxUpdateLessonCode
            // 
            this.tbxUpdateLessonCode.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateLessonCode.Location = new System.Drawing.Point(147, 28);
            this.tbxUpdateLessonCode.MaxLength = 5;
            this.tbxUpdateLessonCode.Name = "tbxUpdateLessonCode";
            this.tbxUpdateLessonCode.Size = new System.Drawing.Size(207, 23);
            this.tbxUpdateLessonCode.TabIndex = 1;
            // 
            // lblUpdateLessonCode
            // 
            this.lblUpdateLessonCode.AutoSize = true;
            this.lblUpdateLessonCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUpdateLessonCode.Location = new System.Drawing.Point(61, 31);
            this.lblUpdateLessonCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateLessonCode.Name = "lblUpdateLessonCode";
            this.lblUpdateLessonCode.Size = new System.Drawing.Size(79, 17);
            this.lblUpdateLessonCode.TabIndex = 0;
            this.lblUpdateLessonCode.Text = "Ders Kodu:";
            // 
            // gbxAddLesson
            // 
            this.gbxAddLesson.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbxAddLesson.Controls.Add(this.cbxAddLessonLecturer);
            this.gbxAddLesson.Controls.Add(this.lblAddLessonLecturer);
            this.gbxAddLesson.Controls.Add(this.btnAddLesson);
            this.gbxAddLesson.Controls.Add(this.cbxAddLessonDepartment);
            this.gbxAddLesson.Controls.Add(this.lblAddLessonDepartment);
            this.gbxAddLesson.Controls.Add(this.tbxAddLessonCredit);
            this.gbxAddLesson.Controls.Add(this.lblAddLessonCredit);
            this.gbxAddLesson.Controls.Add(this.tbxAddLessonClassroom);
            this.gbxAddLesson.Controls.Add(this.lblAddLessonClassroom);
            this.gbxAddLesson.Controls.Add(this.tbxAddLessonCode);
            this.gbxAddLesson.Controls.Add(this.lblAddLessonCode);
            this.gbxAddLesson.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxAddLesson.Location = new System.Drawing.Point(93, 337);
            this.gbxAddLesson.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAddLesson.Name = "gbxAddLesson";
            this.gbxAddLesson.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAddLesson.Size = new System.Drawing.Size(361, 289);
            this.gbxAddLesson.TabIndex = 16;
            this.gbxAddLesson.TabStop = false;
            this.gbxAddLesson.Text = "Yeni Ders Ekle";
            // 
            // cbxAddLessonLecturer
            // 
            this.cbxAddLessonLecturer.BackColor = System.Drawing.Color.Lavender;
            this.cbxAddLessonLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddLessonLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAddLessonLecturer.FormattingEnabled = true;
            this.cbxAddLessonLecturer.Location = new System.Drawing.Point(147, 187);
            this.cbxAddLessonLecturer.Name = "cbxAddLessonLecturer";
            this.cbxAddLessonLecturer.Size = new System.Drawing.Size(207, 24);
            this.cbxAddLessonLecturer.TabIndex = 13;
            // 
            // lblAddLessonLecturer
            // 
            this.lblAddLessonLecturer.AutoSize = true;
            this.lblAddLessonLecturer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddLessonLecturer.Location = new System.Drawing.Point(39, 190);
            this.lblAddLessonLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddLessonLecturer.Name = "lblAddLessonLecturer";
            this.lblAddLessonLecturer.Size = new System.Drawing.Size(101, 17);
            this.lblAddLessonLecturer.TabIndex = 12;
            this.lblAddLessonLecturer.Text = "Öğretim Üyesi:";
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAddLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLesson.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddLesson.Location = new System.Drawing.Point(147, 233);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(207, 29);
            this.btnAddLesson.TabIndex = 11;
            this.btnAddLesson.Text = "Ders Ekle";
            this.btnAddLesson.UseVisualStyleBackColor = false;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // cbxAddLessonDepartment
            // 
            this.cbxAddLessonDepartment.BackColor = System.Drawing.Color.Lavender;
            this.cbxAddLessonDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddLessonDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAddLessonDepartment.FormattingEnabled = true;
            this.cbxAddLessonDepartment.Location = new System.Drawing.Point(147, 146);
            this.cbxAddLessonDepartment.Name = "cbxAddLessonDepartment";
            this.cbxAddLessonDepartment.Size = new System.Drawing.Size(207, 24);
            this.cbxAddLessonDepartment.TabIndex = 7;
            this.cbxAddLessonDepartment.SelectedIndexChanged += new System.EventHandler(this.cbxAddLessonDepartment_SelectedIndexChanged);
            // 
            // lblAddLessonDepartment
            // 
            this.lblAddLessonDepartment.AutoSize = true;
            this.lblAddLessonDepartment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddLessonDepartment.Location = new System.Drawing.Point(89, 149);
            this.lblAddLessonDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddLessonDepartment.Name = "lblAddLessonDepartment";
            this.lblAddLessonDepartment.Size = new System.Drawing.Size(51, 17);
            this.lblAddLessonDepartment.TabIndex = 6;
            this.lblAddLessonDepartment.Text = "Bölüm:";
            // 
            // tbxAddLessonCredit
            // 
            this.tbxAddLessonCredit.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddLessonCredit.Location = new System.Drawing.Point(147, 66);
            this.tbxAddLessonCredit.MaxLength = 2;
            this.tbxAddLessonCredit.Name = "tbxAddLessonCredit";
            this.tbxAddLessonCredit.Size = new System.Drawing.Size(207, 23);
            this.tbxAddLessonCredit.TabIndex = 3;
            // 
            // lblAddLessonCredit
            // 
            this.lblAddLessonCredit.AutoSize = true;
            this.lblAddLessonCredit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddLessonCredit.Location = new System.Drawing.Point(51, 69);
            this.lblAddLessonCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddLessonCredit.Name = "lblAddLessonCredit";
            this.lblAddLessonCredit.Size = new System.Drawing.Size(89, 17);
            this.lblAddLessonCredit.TabIndex = 2;
            this.lblAddLessonCredit.Text = "Ders Kredisi:";
            // 
            // tbxAddLessonClassroom
            // 
            this.tbxAddLessonClassroom.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddLessonClassroom.Location = new System.Drawing.Point(147, 105);
            this.tbxAddLessonClassroom.MaxLength = 2;
            this.tbxAddLessonClassroom.Name = "tbxAddLessonClassroom";
            this.tbxAddLessonClassroom.Size = new System.Drawing.Size(207, 23);
            this.tbxAddLessonClassroom.TabIndex = 3;
            // 
            // lblAddLessonClassroom
            // 
            this.lblAddLessonClassroom.AutoSize = true;
            this.lblAddLessonClassroom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddLessonClassroom.Location = new System.Drawing.Point(85, 108);
            this.lblAddLessonClassroom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddLessonClassroom.Name = "lblAddLessonClassroom";
            this.lblAddLessonClassroom.Size = new System.Drawing.Size(55, 17);
            this.lblAddLessonClassroom.TabIndex = 2;
            this.lblAddLessonClassroom.Text = "Derslik:";
            // 
            // tbxAddLessonCode
            // 
            this.tbxAddLessonCode.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddLessonCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxAddLessonCode.Location = new System.Drawing.Point(147, 28);
            this.tbxAddLessonCode.MaxLength = 5;
            this.tbxAddLessonCode.Name = "tbxAddLessonCode";
            this.tbxAddLessonCode.Size = new System.Drawing.Size(207, 23);
            this.tbxAddLessonCode.TabIndex = 1;
            // 
            // lblAddLessonCode
            // 
            this.lblAddLessonCode.AutoSize = true;
            this.lblAddLessonCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddLessonCode.Location = new System.Drawing.Point(61, 31);
            this.lblAddLessonCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddLessonCode.Name = "lblAddLessonCode";
            this.lblAddLessonCode.Size = new System.Drawing.Size(79, 17);
            this.lblAddLessonCode.TabIndex = 0;
            this.lblAddLessonCode.Text = "Ders Kodu:";
            // 
            // btnAddStudentToLesson
            // 
            this.btnAddStudentToLesson.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddStudentToLesson.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddStudentToLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudentToLesson.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddStudentToLesson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudentToLesson.Location = new System.Drawing.Point(885, 406);
            this.btnAddStudentToLesson.Name = "btnAddStudentToLesson";
            this.btnAddStudentToLesson.Size = new System.Drawing.Size(172, 33);
            this.btnAddStudentToLesson.TabIndex = 19;
            this.btnAddStudentToLesson.Text = "Derse Öğrenci Ekle";
            this.btnAddStudentToLesson.UseVisualStyleBackColor = false;
            this.btnAddStudentToLesson.Click += new System.EventHandler(this.btnAddStudentToLesson_Click);
            // 
            // dgwLessons
            // 
            this.dgwLessons.AllowUserToResizeColumns = false;
            this.dgwLessons.AllowUserToResizeRows = false;
            this.dgwLessons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwLessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLessons.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwLessons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwLessons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwLessons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLessons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwLessons.ColumnHeadersHeight = 30;
            this.dgwLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwLessons.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwLessons.EnableHeadersVisualStyles = false;
            this.dgwLessons.GridColor = System.Drawing.SystemColors.Menu;
            this.dgwLessons.Location = new System.Drawing.Point(93, 26);
            this.dgwLessons.Margin = new System.Windows.Forms.Padding(5);
            this.dgwLessons.MultiSelect = false;
            this.dgwLessons.Name = "dgwLessons";
            this.dgwLessons.ReadOnly = true;
            this.dgwLessons.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwLessons.RowHeadersVisible = false;
            this.dgwLessons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwLessons.RowTemplate.Height = 30;
            this.dgwLessons.RowTemplate.ReadOnly = true;
            this.dgwLessons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwLessons.Size = new System.Drawing.Size(964, 281);
            this.dgwLessons.TabIndex = 20;
            this.dgwLessons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLessons_CellClick);
            // 
            // Lessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1151, 677);
            this.Controls.Add(this.dgwLessons);
            this.Controls.Add(this.btnAddStudentToLesson);
            this.Controls.Add(this.btnDeleteLesson);
            this.Controls.Add(this.gbxUpdateLesson);
            this.Controls.Add(this.gbxAddLesson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lessons";
            this.Text = "Lessons";
            this.VisibleChanged += new System.EventHandler(this.Lessons_VisibleChanged);
            this.gbxUpdateLesson.ResumeLayout(false);
            this.gbxUpdateLesson.PerformLayout();
            this.gbxAddLesson.ResumeLayout(false);
            this.gbxAddLesson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLessons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.GroupBox gbxUpdateLesson;
        private System.Windows.Forms.ComboBox cbxUpdateLessonDepartment;
        private System.Windows.Forms.Label lblUpdateLessonDepartment;
        private System.Windows.Forms.Button btnUpdateLesson;
        private System.Windows.Forms.TextBox tbxUpdateLessonCredit;
        private System.Windows.Forms.Label lblUpdateLessonCredit;
        private System.Windows.Forms.TextBox tbxUpdateLessonClassroom;
        private System.Windows.Forms.Label lblUpdateLessonClassroom;
        private System.Windows.Forms.TextBox tbxUpdateLessonCode;
        private System.Windows.Forms.Label lblUpdateLessonCode;
        private System.Windows.Forms.GroupBox gbxAddLesson;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.ComboBox cbxAddLessonDepartment;
        private System.Windows.Forms.Label lblAddLessonDepartment;
        private System.Windows.Forms.TextBox tbxAddLessonCredit;
        private System.Windows.Forms.Label lblAddLessonCredit;
        private System.Windows.Forms.TextBox tbxAddLessonClassroom;
        private System.Windows.Forms.Label lblAddLessonClassroom;
        private System.Windows.Forms.TextBox tbxAddLessonCode;
        private System.Windows.Forms.Label lblAddLessonCode;
        private System.Windows.Forms.ComboBox cbxUpdateLessonLecturer;
        private System.Windows.Forms.Label lblUpdateLessonLecturer;
        private System.Windows.Forms.ComboBox cbxAddLessonLecturer;
        private System.Windows.Forms.Label lblAddLessonLecturer;
        private System.Windows.Forms.Button btnAddStudentToLesson;
        private System.Windows.Forms.DataGridView dgwLessons;
    }
}