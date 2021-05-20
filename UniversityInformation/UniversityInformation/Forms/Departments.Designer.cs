namespace UniversityInformation.Forms
{
    partial class Departments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwDepartments = new System.Windows.Forms.DataGridView();
            this.gbxAddDepartments = new System.Windows.Forms.GroupBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.tbxAddDepartmentName = new System.Windows.Forms.TextBox();
            this.lblAddDepartmentName = new System.Windows.Forms.Label();
            this.tbxAddDepartmentCode = new System.Windows.Forms.TextBox();
            this.lblAddDepartmentCode = new System.Windows.Forms.Label();
            this.gbxUpdateDepartment = new System.Windows.Forms.GroupBox();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.tbxUpdateDepartmentName = new System.Windows.Forms.TextBox();
            this.lblUpdateDepartmentName = new System.Windows.Forms.Label();
            this.tbxUpdateDepartmentCode = new System.Windows.Forms.TextBox();
            this.lblUpdateDepartmentCode = new System.Windows.Forms.Label();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartments)).BeginInit();
            this.gbxAddDepartments.SuspendLayout();
            this.gbxUpdateDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwDepartments
            // 
            this.dgwDepartments.AllowUserToResizeColumns = false;
            this.dgwDepartments.AllowUserToResizeRows = false;
            this.dgwDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDepartments.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwDepartments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwDepartments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwDepartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwDepartments.ColumnHeadersHeight = 30;
            this.dgwDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwDepartments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwDepartments.EnableHeadersVisualStyles = false;
            this.dgwDepartments.GridColor = System.Drawing.SystemColors.Menu;
            this.dgwDepartments.Location = new System.Drawing.Point(130, 27);
            this.dgwDepartments.Margin = new System.Windows.Forms.Padding(5);
            this.dgwDepartments.MultiSelect = false;
            this.dgwDepartments.Name = "dgwDepartments";
            this.dgwDepartments.ReadOnly = true;
            this.dgwDepartments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwDepartments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwDepartments.RowHeadersVisible = false;
            this.dgwDepartments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwDepartments.RowTemplate.Height = 30;
            this.dgwDepartments.RowTemplate.ReadOnly = true;
            this.dgwDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDepartments.Size = new System.Drawing.Size(620, 260);
            this.dgwDepartments.TabIndex = 0;
            this.dgwDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDepartments_CellClick);
            // 
            // gbxAddDepartments
            // 
            this.gbxAddDepartments.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbxAddDepartments.Controls.Add(this.btnAddDepartment);
            this.gbxAddDepartments.Controls.Add(this.tbxAddDepartmentName);
            this.gbxAddDepartments.Controls.Add(this.lblAddDepartmentName);
            this.gbxAddDepartments.Controls.Add(this.tbxAddDepartmentCode);
            this.gbxAddDepartments.Controls.Add(this.lblAddDepartmentCode);
            this.gbxAddDepartments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxAddDepartments.Location = new System.Drawing.Point(59, 335);
            this.gbxAddDepartments.Name = "gbxAddDepartments";
            this.gbxAddDepartments.Size = new System.Drawing.Size(282, 187);
            this.gbxAddDepartments.TabIndex = 1;
            this.gbxAddDepartments.TabStop = false;
            this.gbxAddDepartments.Text = "Yeni Bölüm Ekle";
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddDepartment.Location = new System.Drawing.Point(105, 132);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(159, 29);
            this.btnAddDepartment.TabIndex = 4;
            this.btnAddDepartment.Text = "Bölüm Ekle";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // tbxAddDepartmentName
            // 
            this.tbxAddDepartmentName.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAddDepartmentName.Location = new System.Drawing.Point(105, 82);
            this.tbxAddDepartmentName.Name = "tbxAddDepartmentName";
            this.tbxAddDepartmentName.Size = new System.Drawing.Size(159, 23);
            this.tbxAddDepartmentName.TabIndex = 3;
            // 
            // lblAddDepartmentName
            // 
            this.lblAddDepartmentName.AutoSize = true;
            this.lblAddDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddDepartmentName.Location = new System.Drawing.Point(24, 85);
            this.lblAddDepartmentName.Name = "lblAddDepartmentName";
            this.lblAddDepartmentName.Size = new System.Drawing.Size(75, 17);
            this.lblAddDepartmentName.TabIndex = 2;
            this.lblAddDepartmentName.Text = "Bölüm Adı:";
            // 
            // tbxAddDepartmentCode
            // 
            this.tbxAddDepartmentCode.BackColor = System.Drawing.Color.Lavender;
            this.tbxAddDepartmentCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAddDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAddDepartmentCode.Location = new System.Drawing.Point(105, 36);
            this.tbxAddDepartmentCode.MaxLength = 3;
            this.tbxAddDepartmentCode.Name = "tbxAddDepartmentCode";
            this.tbxAddDepartmentCode.Size = new System.Drawing.Size(159, 23);
            this.tbxAddDepartmentCode.TabIndex = 1;
            // 
            // lblAddDepartmentCode
            // 
            this.lblAddDepartmentCode.AutoSize = true;
            this.lblAddDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddDepartmentCode.Location = new System.Drawing.Point(11, 39);
            this.lblAddDepartmentCode.Name = "lblAddDepartmentCode";
            this.lblAddDepartmentCode.Size = new System.Drawing.Size(88, 17);
            this.lblAddDepartmentCode.TabIndex = 0;
            this.lblAddDepartmentCode.Text = "Bölüm Kodu:";
            // 
            // gbxUpdateDepartment
            // 
            this.gbxUpdateDepartment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gbxUpdateDepartment.Controls.Add(this.btnUpdateDepartment);
            this.gbxUpdateDepartment.Controls.Add(this.tbxUpdateDepartmentName);
            this.gbxUpdateDepartment.Controls.Add(this.lblUpdateDepartmentName);
            this.gbxUpdateDepartment.Controls.Add(this.tbxUpdateDepartmentCode);
            this.gbxUpdateDepartment.Controls.Add(this.lblUpdateDepartmentCode);
            this.gbxUpdateDepartment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxUpdateDepartment.Location = new System.Drawing.Point(367, 335);
            this.gbxUpdateDepartment.Name = "gbxUpdateDepartment";
            this.gbxUpdateDepartment.Size = new System.Drawing.Size(289, 187);
            this.gbxUpdateDepartment.TabIndex = 5;
            this.gbxUpdateDepartment.TabStop = false;
            this.gbxUpdateDepartment.Text = "Bölümü Düzenle";
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUpdateDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDepartment.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateDepartment.Location = new System.Drawing.Point(105, 132);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(159, 29);
            this.btnUpdateDepartment.TabIndex = 4;
            this.btnUpdateDepartment.Text = "Bölümü Güncelle";
            this.btnUpdateDepartment.UseVisualStyleBackColor = false;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // tbxUpdateDepartmentName
            // 
            this.tbxUpdateDepartmentName.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateDepartmentName.Location = new System.Drawing.Point(105, 82);
            this.tbxUpdateDepartmentName.Name = "tbxUpdateDepartmentName";
            this.tbxUpdateDepartmentName.Size = new System.Drawing.Size(159, 23);
            this.tbxUpdateDepartmentName.TabIndex = 3;
            // 
            // lblUpdateDepartmentName
            // 
            this.lblUpdateDepartmentName.AutoSize = true;
            this.lblUpdateDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateDepartmentName.Location = new System.Drawing.Point(24, 85);
            this.lblUpdateDepartmentName.Name = "lblUpdateDepartmentName";
            this.lblUpdateDepartmentName.Size = new System.Drawing.Size(75, 17);
            this.lblUpdateDepartmentName.TabIndex = 2;
            this.lblUpdateDepartmentName.Text = "Bölüm Adı:";
            // 
            // tbxUpdateDepartmentCode
            // 
            this.tbxUpdateDepartmentCode.BackColor = System.Drawing.Color.Lavender;
            this.tbxUpdateDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateDepartmentCode.Location = new System.Drawing.Point(105, 36);
            this.tbxUpdateDepartmentCode.MaxLength = 3;
            this.tbxUpdateDepartmentCode.Name = "tbxUpdateDepartmentCode";
            this.tbxUpdateDepartmentCode.Size = new System.Drawing.Size(159, 23);
            this.tbxUpdateDepartmentCode.TabIndex = 1;
            // 
            // lblUpdateDepartmentCode
            // 
            this.lblUpdateDepartmentCode.AutoSize = true;
            this.lblUpdateDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdateDepartmentCode.Location = new System.Drawing.Point(11, 39);
            this.lblUpdateDepartmentCode.Name = "lblUpdateDepartmentCode";
            this.lblUpdateDepartmentCode.Size = new System.Drawing.Size(88, 17);
            this.lblUpdateDepartmentCode.TabIndex = 0;
            this.lblUpdateDepartmentCode.Text = "Bölüm Kodu:";
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteDepartment.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDepartment.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteDepartment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteDepartment.Location = new System.Drawing.Point(686, 398);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(159, 26);
            this.btnDeleteDepartment.TabIndex = 5;
            this.btnDeleteDepartment.Text = "Bölümü Sil";
            this.btnDeleteDepartment.UseVisualStyleBackColor = false;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(886, 571);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.gbxUpdateDepartment);
            this.Controls.Add(this.gbxAddDepartments);
            this.Controls.Add(this.dgwDepartments);
            this.Name = "Departments";
            this.Text = "edrsxb";
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepartments)).EndInit();
            this.gbxAddDepartments.ResumeLayout(false);
            this.gbxAddDepartments.PerformLayout();
            this.gbxUpdateDepartment.ResumeLayout(false);
            this.gbxUpdateDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDepartments;
        private System.Windows.Forms.GroupBox gbxAddDepartments;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.TextBox tbxAddDepartmentName;
        private System.Windows.Forms.Label lblAddDepartmentName;
        private System.Windows.Forms.TextBox tbxAddDepartmentCode;
        private System.Windows.Forms.Label lblAddDepartmentCode;
        private System.Windows.Forms.GroupBox gbxUpdateDepartment;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.TextBox tbxUpdateDepartmentName;
        private System.Windows.Forms.Label lblUpdateDepartmentName;
        private System.Windows.Forms.TextBox tbxUpdateDepartmentCode;
        private System.Windows.Forms.Label lblUpdateDepartmentCode;
        private System.Windows.Forms.Button btnDeleteDepartment;
    }
}