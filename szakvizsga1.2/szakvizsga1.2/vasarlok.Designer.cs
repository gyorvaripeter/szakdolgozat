namespace szakvizsga1._2
{
    partial class vasarlok
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vasarloIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasarloneveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.munkatipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orszagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eladoTipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasarlokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adatbazisDataSet = new szakvizsga1._2.AdatbazisDataSet();
            this.vasarlokTableAdapter = new szakvizsga1._2.AdatbazisDataSetTableAdapters.VasarlokTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vasarlokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(94, 295);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(114, 54);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Módosítás";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
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
            this.vasarloIDDataGridViewTextBoxColumn,
            this.vasarloneveDataGridViewTextBoxColumn,
            this.munkatipusDataGridViewTextBoxColumn,
            this.telefonszamDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.varosDataGridViewTextBoxColumn,
            this.megyeDataGridViewTextBoxColumn,
            this.irszamDataGridViewTextBoxColumn,
            this.orszagDataGridViewTextBoxColumn,
            this.eladoTipusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vasarlokBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 193);
            this.dataGridView1.TabIndex = 1;
            // 
            // vasarloIDDataGridViewTextBoxColumn
            // 
            this.vasarloIDDataGridViewTextBoxColumn.DataPropertyName = "Vasarlo_ID";
            this.vasarloIDDataGridViewTextBoxColumn.HeaderText = "Vasarlo_ID";
            this.vasarloIDDataGridViewTextBoxColumn.Name = "vasarloIDDataGridViewTextBoxColumn";
            this.vasarloIDDataGridViewTextBoxColumn.Visible = false;
            this.vasarloIDDataGridViewTextBoxColumn.Width = 121;
            // 
            // vasarloneveDataGridViewTextBoxColumn
            // 
            this.vasarloneveDataGridViewTextBoxColumn.DataPropertyName = "Vasarlo_neve";
            this.vasarloneveDataGridViewTextBoxColumn.HeaderText = "Vasarlo_neve";
            this.vasarloneveDataGridViewTextBoxColumn.Name = "vasarloneveDataGridViewTextBoxColumn";
            this.vasarloneveDataGridViewTextBoxColumn.Width = 142;
            // 
            // munkatipusDataGridViewTextBoxColumn
            // 
            this.munkatipusDataGridViewTextBoxColumn.DataPropertyName = "Munka_tipus";
            this.munkatipusDataGridViewTextBoxColumn.HeaderText = "Munka_tipus";
            this.munkatipusDataGridViewTextBoxColumn.Name = "munkatipusDataGridViewTextBoxColumn";
            this.munkatipusDataGridViewTextBoxColumn.Width = 137;
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            this.telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            this.telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            this.telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            this.telefonszamDataGridViewTextBoxColumn.Width = 137;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 98;
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
            // eladoTipusDataGridViewTextBoxColumn
            // 
            this.eladoTipusDataGridViewTextBoxColumn.DataPropertyName = "Elado_Tipus";
            this.eladoTipusDataGridViewTextBoxColumn.HeaderText = "Elado_Tipus";
            this.eladoTipusDataGridViewTextBoxColumn.Name = "eladoTipusDataGridViewTextBoxColumn";
            this.eladoTipusDataGridViewTextBoxColumn.Visible = false;
            this.eladoTipusDataGridViewTextBoxColumn.Width = 130;
            // 
            // vasarlokBindingSource
            // 
            this.vasarlokBindingSource.DataMember = "Vasarlok";
            this.vasarlokBindingSource.DataSource = this.adatbazisDataSet;
            // 
            // adatbazisDataSet
            // 
            this.adatbazisDataSet.DataSetName = "AdatbazisDataSet";
            this.adatbazisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vasarlokTableAdapter
            // 
            this.vasarlokTableAdapter.ClearBeforeFill = true;
            // 
            // vasarlok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroTile1);
            this.Name = "vasarlok";
            this.Text = "vasarlok";
            this.Load += new System.EventHandler(this.vasarlok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vasarlokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdatbazisDataSet adatbazisDataSet;
        private System.Windows.Forms.BindingSource vasarlokBindingSource;
        private AdatbazisDataSetTableAdapters.VasarlokTableAdapter vasarlokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasarloIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vasarloneveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkatipusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn irszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orszagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eladoTipusDataGridViewTextBoxColumn;
    }
}