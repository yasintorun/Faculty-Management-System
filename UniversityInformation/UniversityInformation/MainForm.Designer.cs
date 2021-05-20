namespace UniversityInformation
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnLessons = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnLecturers = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnAboutUs);
            this.panelMenu.Controls.Add(this.btnNotes);
            this.panelMenu.Controls.Add(this.btnLessons);
            this.panelMenu.Controls.Add(this.btnStudents);
            this.panelMenu.Controls.Add(this.btnLecturers);
            this.panelMenu.Controls.Add(this.btnDepartments);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 796);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.ImageIndex = 0;
            this.btnAboutUs.ImageList = this.ımageList1;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 380);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAboutUs.Size = new System.Drawing.Size(220, 60);
            this.btnAboutUs.TabIndex = 6;
            this.btnAboutUs.Text = "    Hakkımızda";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "about.png");
            this.ımageList1.Images.SetKeyName(1, "lecture.png");
            this.ımageList1.Images.SetKeyName(2, "lecturer.png");
            this.ımageList1.Images.SetKeyName(3, "note.png");
            this.ımageList1.Images.SetKeyName(4, "school.png");
            this.ımageList1.Images.SetKeyName(5, "student.png");
            // 
            // btnNotes
            // 
            this.btnNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.ImageIndex = 3;
            this.btnNotes.ImageList = this.ımageList1;
            this.btnNotes.Location = new System.Drawing.Point(0, 320);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNotes.Size = new System.Drawing.Size(220, 60);
            this.btnNotes.TabIndex = 5;
            this.btnNotes.Text = "    Notlar";
            this.btnNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnLessons
            // 
            this.btnLessons.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLessons.FlatAppearance.BorderSize = 0;
            this.btnLessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLessons.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLessons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLessons.ImageIndex = 1;
            this.btnLessons.ImageList = this.ımageList1;
            this.btnLessons.Location = new System.Drawing.Point(0, 260);
            this.btnLessons.Name = "btnLessons";
            this.btnLessons.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLessons.Size = new System.Drawing.Size(220, 60);
            this.btnLessons.TabIndex = 4;
            this.btnLessons.Text = "    Dersler";
            this.btnLessons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLessons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLessons.UseVisualStyleBackColor = true;
            this.btnLessons.Click += new System.EventHandler(this.btnLessons_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.ImageIndex = 5;
            this.btnStudents.ImageList = this.ımageList1;
            this.btnStudents.Location = new System.Drawing.Point(0, 200);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStudents.Size = new System.Drawing.Size(220, 60);
            this.btnStudents.TabIndex = 3;
            this.btnStudents.Text = "    Öğrenciler";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnLecturers
            // 
            this.btnLecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLecturers.FlatAppearance.BorderSize = 0;
            this.btnLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLecturers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturers.ImageIndex = 2;
            this.btnLecturers.ImageList = this.ımageList1;
            this.btnLecturers.Location = new System.Drawing.Point(0, 140);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLecturers.Size = new System.Drawing.Size(220, 60);
            this.btnLecturers.TabIndex = 2;
            this.btnLecturers.Text = "    Öğretim Üyeleri";
            this.btnLecturers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLecturers.UseVisualStyleBackColor = true;
            this.btnLecturers.Click += new System.EventHandler(this.btnLecturers_Click);
            // 
            // btnDepartments
            // 
            this.btnDepartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartments.FlatAppearance.BorderSize = 0;
            this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartments.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.ImageIndex = 4;
            this.btnDepartments.ImageList = this.ımageList1;
            this.btnDepartments.Location = new System.Drawing.Point(0, 80);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDepartments.Size = new System.Drawing.Size(220, 60);
            this.btnDepartments.TabIndex = 1;
            this.btnDepartments.Text = "    Bölümler";
            this.btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartments.UseVisualStyleBackColor = true;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fakülte Yönetim Sistemi";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1167, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(540, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Anasayfa";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1167, 716);
            this.panelDesktop.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 796);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1400, 830);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fakülte Yönetim Sistemi";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnLessons;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnLecturers;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

