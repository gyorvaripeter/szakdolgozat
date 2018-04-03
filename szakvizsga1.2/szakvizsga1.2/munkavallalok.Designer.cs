namespace szakvizsga1._2
{
    partial class munkavallalok
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.munkatipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ceg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adatbazisDataSet3 = new szakvizsga1._2.AdatbazisDataSet3();
            this.munkavallalokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.munkavallalokTableAdapter = new szakvizsga1._2.AdatbazisDataSet3TableAdapters.MunkavallalokTableAdapter();
            this.azonosítóDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munkavallalokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munkatipusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orszagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fenykepDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkavallalokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.azonosítóDataGridViewTextBoxColumn,
            this.munkavallalokDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.cegDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.munkatipusDataGridViewTextBoxColumn1,
            this.telefonDataGridViewTextBoxColumn,
            this.cimDataGridViewTextBoxColumn,
            this.varosDataGridViewTextBoxColumn,
            this.megyeDataGridViewTextBoxColumn,
            this.irszamDataGridViewTextBoxColumn,
            this.orszagDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn,
            this.fenykepDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.munkavallalokBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView1.Location = new System.Drawing.Point(-33, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(916, 193);
            this.dataGridView1.TabIndex = 2;
            // 
            // munkatipusDataGridViewTextBoxColumn
            // 
            this.munkatipusDataGridViewTextBoxColumn.DataPropertyName = "Munka_tipus";
            this.munkatipusDataGridViewTextBoxColumn.HeaderText = "Munka_tipus";
            this.munkatipusDataGridViewTextBoxColumn.Name = "munkatipusDataGridViewTextBoxColumn";
            this.munkatipusDataGridViewTextBoxColumn.Width = 137;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Munkavallalok";
            this.dataGridViewTextBoxColumn1.HeaderText = "Munkavállalók";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // Ceg
            // 
            this.Ceg.DataPropertyName = "Ceg";
            this.Ceg.HeaderText = "Ceg";
            this.Ceg.Name = "Ceg";
            // 
            // adatbazisDataSet3
            // 
            this.adatbazisDataSet3.DataSetName = "AdatbazisDataSet3";
            this.adatbazisDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // munkavallalokBindingSource
            // 
            this.munkavallalokBindingSource.DataMember = "Munkavallalok";
            this.munkavallalokBindingSource.DataSource = this.adatbazisDataSet3;
            // 
            // munkavallalokTableAdapter
            // 
            this.munkavallalokTableAdapter.ClearBeforeFill = true;
            // 
            // azonosítóDataGridViewTextBoxColumn
            // 
            this.azonosítóDataGridViewTextBoxColumn.DataPropertyName = "Azonosító";
            this.azonosítóDataGridViewTextBoxColumn.HeaderText = "Azonosító";
            this.azonosítóDataGridViewTextBoxColumn.Name = "azonosítóDataGridViewTextBoxColumn";
            this.azonosítóDataGridViewTextBoxColumn.ReadOnly = true;
            this.azonosítóDataGridViewTextBoxColumn.Visible = false;
            this.azonosítóDataGridViewTextBoxColumn.Width = 117;
            // 
            // munkavallalokDataGridViewTextBoxColumn
            // 
            this.munkavallalokDataGridViewTextBoxColumn.DataPropertyName = "Munkavallalok";
            this.munkavallalokDataGridViewTextBoxColumn.HeaderText = "Munkavallalok";
            this.munkavallalokDataGridViewTextBoxColumn.Name = "munkavallalokDataGridViewTextBoxColumn";
            this.munkavallalokDataGridViewTextBoxColumn.Width = 152;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 115;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 111;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roleDataGridViewTextBoxColumn.Width = 70;
            // 
            // cegDataGridViewTextBoxColumn
            // 
            this.cegDataGridViewTextBoxColumn.DataPropertyName = "Ceg";
            this.cegDataGridViewTextBoxColumn.HeaderText = "Ceg";
            this.cegDataGridViewTextBoxColumn.Name = "cegDataGridViewTextBoxColumn";
            this.cegDataGridViewTextBoxColumn.Width = 64;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 80;
            // 
            // munkatipusDataGridViewTextBoxColumn1
            // 
            this.munkatipusDataGridViewTextBoxColumn1.DataPropertyName = "Munka_tipus";
            this.munkatipusDataGridViewTextBoxColumn1.HeaderText = "Munka_tipus";
            this.munkatipusDataGridViewTextBoxColumn1.Name = "munkatipusDataGridViewTextBoxColumn1";
            this.munkatipusDataGridViewTextBoxColumn1.Width = 137;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 94;
            // 
            // cimDataGridViewTextBoxColumn
            // 
            this.cimDataGridViewTextBoxColumn.DataPropertyName = "Cim";
            this.cimDataGridViewTextBoxColumn.HeaderText = "Cim";
            this.cimDataGridViewTextBoxColumn.Name = "cimDataGridViewTextBoxColumn";
            this.cimDataGridViewTextBoxColumn.Width = 62;
            // 
            // varosDataGridViewTextBoxColumn
            // 
            this.varosDataGridViewTextBoxColumn.DataPropertyName = "Varos";
            this.varosDataGridViewTextBoxColumn.HeaderText = "Varos";
            this.varosDataGridViewTextBoxColumn.Name = "varosDataGridViewTextBoxColumn";
            this.varosDataGridViewTextBoxColumn.Width = 80;
            // 
            // megyeDataGridViewTextBoxColumn
            // 
            this.megyeDataGridViewTextBoxColumn.DataPropertyName = "Megye";
            this.megyeDataGridViewTextBoxColumn.HeaderText = "Megye";
            this.megyeDataGridViewTextBoxColumn.Name = "megyeDataGridViewTextBoxColumn";
            this.megyeDataGridViewTextBoxColumn.Width = 88;
            // 
            // irszamDataGridViewTextBoxColumn
            // 
            this.irszamDataGridViewTextBoxColumn.DataPropertyName = "Ir_szam";
            this.irszamDataGridViewTextBoxColumn.HeaderText = "Ir_szam";
            this.irszamDataGridViewTextBoxColumn.Name = "irszamDataGridViewTextBoxColumn";
            this.irszamDataGridViewTextBoxColumn.Width = 96;
            // 
            // orszagDataGridViewTextBoxColumn
            // 
            this.orszagDataGridViewTextBoxColumn.DataPropertyName = "Orszag";
            this.orszagDataGridViewTextBoxColumn.HeaderText = "Orszag";
            this.orszagDataGridViewTextBoxColumn.Name = "orszagDataGridViewTextBoxColumn";
            this.orszagDataGridViewTextBoxColumn.Width = 91;
            // 
            // megjegyzesDataGridViewTextBoxColumn
            // 
            this.megjegyzesDataGridViewTextBoxColumn.DataPropertyName = "Megjegyzes";
            this.megjegyzesDataGridViewTextBoxColumn.HeaderText = "Megjegyzes";
            this.megjegyzesDataGridViewTextBoxColumn.Name = "megjegyzesDataGridViewTextBoxColumn";
            this.megjegyzesDataGridViewTextBoxColumn.Width = 131;
            // 
            // fenykepDataGridViewImageColumn
            // 
            this.fenykepDataGridViewImageColumn.DataPropertyName = "Fenykep";
            this.fenykepDataGridViewImageColumn.HeaderText = "Fenykep";
            this.fenykepDataGridViewImageColumn.Name = "fenykepDataGridViewImageColumn";
            this.fenykepDataGridViewImageColumn.Width = 82;
            // 
            // munkavallalok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 280);
            this.Controls.Add(this.dataGridView1);
            this.Name = "munkavallalok";
            this.Text = "munkavallalok";
            this.Load += new System.EventHandler(this.munkavallalok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.munkavallalokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkatipusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewComboBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ceg;
        private AdatbazisDataSet3 adatbazisDataSet3;
        private System.Windows.Forms.BindingSource munkavallalokBindingSource;
        private AdatbazisDataSet3TableAdapters.MunkavallalokTableAdapter munkavallalokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn azonosítóDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkavallalokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkatipusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn irszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orszagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fenykepDataGridViewImageColumn;
    }
}