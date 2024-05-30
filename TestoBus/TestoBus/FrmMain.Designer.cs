namespace TestoBus
{
    partial class FrmMain
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
            this.lblNaslovApk = new System.Windows.Forms.Label();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblVozniRedovi = new System.Windows.Forms.Label();
            this.btn_NoviVozniRed = new System.Windows.Forms.Button();
            this.btn_AzurirajVozniRed = new System.Windows.Forms.Button();
            this.vozniRedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pI2324_nrastija22_DBDataSet = new TestoBus.PI2324_nrastija22_DBDataSet();
            this.vozniRedTableAdapter = new TestoBus.PI2324_nrastija22_DBDataSetTableAdapters.VozniRedTableAdapter();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.RichTextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.vozniRedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVozniRedovi = new System.Windows.Forms.DataGridView();
            this.idvoznogredaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivlinijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polazisnastanicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odredisnastanicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemetrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozniRedBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPonistiFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nrastija22_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozniRedovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslovApk
            // 
            this.lblNaslovApk.AutoSize = true;
            this.lblNaslovApk.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovApk.Location = new System.Drawing.Point(50, 24);
            this.lblNaslovApk.Name = "lblNaslovApk";
            this.lblNaslovApk.Size = new System.Drawing.Size(283, 69);
            this.lblNaslovApk.TabIndex = 0;
            this.lblNaslovApk.Text = "TestoBus";
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(1077, 24);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(245, 26);
            this.txtKorime.TabIndex = 1;
            // 
            // txtDatum
            // 
            this.txtDatum.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDatum.Location = new System.Drawing.Point(1077, 61);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(245, 26);
            this.txtDatum.TabIndex = 2;
            // 
            // lblVozniRedovi
            // 
            this.lblVozniRedovi.AutoSize = true;
            this.lblVozniRedovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVozniRedovi.Location = new System.Drawing.Point(55, 247);
            this.lblVozniRedovi.Name = "lblVozniRedovi";
            this.lblVozniRedovi.Size = new System.Drawing.Size(215, 40);
            this.lblVozniRedovi.TabIndex = 4;
            this.lblVozniRedovi.Text = "Vozni redovi";
            // 
            // btn_NoviVozniRed
            // 
            this.btn_NoviVozniRed.Location = new System.Drawing.Point(1120, 133);
            this.btn_NoviVozniRed.Name = "btn_NoviVozniRed";
            this.btn_NoviVozniRed.Size = new System.Drawing.Size(158, 40);
            this.btn_NoviVozniRed.TabIndex = 5;
            this.btn_NoviVozniRed.Text = "Novi vozni red";
            this.btn_NoviVozniRed.UseVisualStyleBackColor = true;
            this.btn_NoviVozniRed.Click += new System.EventHandler(this.btn_NoviVozniRed_Click);
            // 
            // btn_AzurirajVozniRed
            // 
            this.btn_AzurirajVozniRed.Location = new System.Drawing.Point(1120, 190);
            this.btn_AzurirajVozniRed.Name = "btn_AzurirajVozniRed";
            this.btn_AzurirajVozniRed.Size = new System.Drawing.Size(157, 39);
            this.btn_AzurirajVozniRed.TabIndex = 6;
            this.btn_AzurirajVozniRed.Text = "Azuriraj vozni red";
            this.btn_AzurirajVozniRed.UseVisualStyleBackColor = true;
            this.btn_AzurirajVozniRed.Click += new System.EventHandler(this.btn_AzurirajVozniRed_Click);
            // 
            // vozniRedBindingSource
            // 
            this.vozniRedBindingSource.DataMember = "VozniRed";
            this.vozniRedBindingSource.DataSource = this.pI2324_nrastija22_DBDataSet;
            // 
            // pI2324_nrastija22_DBDataSet
            // 
            this.pI2324_nrastija22_DBDataSet.DataSetName = "PI2324_nrastija22_DBDataSet";
            this.pI2324_nrastija22_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vozniRedTableAdapter
            // 
            this.vozniRedTableAdapter.ClearBeforeFill = true;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretrazivanje.Location = new System.Drawing.Point(481, 197);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(189, 32);
            this.lblPretrazivanje.TabIndex = 8;
            this.lblPretrazivanje.Text = "Pretrazivanje:";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtPretrazivanje.Location = new System.Drawing.Point(487, 232);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(249, 54);
            this.txtPretrazivanje.TabIndex = 9;
            this.txtPretrazivanje.Text = "";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(742, 232);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(149, 55);
            this.btnPretrazi.TabIndex = 10;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // vozniRedBindingSource1
            // 
            this.vozniRedBindingSource1.DataMember = "VozniRed";
            this.vozniRedBindingSource1.DataSource = this.pI2324_nrastija22_DBDataSet;
            // 
            // dgvVozniRedovi
            // 
            this.dgvVozniRedovi.AutoGenerateColumns = false;
            this.dgvVozniRedovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozniRedovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvoznogredaDataGridViewTextBoxColumn,
            this.nazivlinijeDataGridViewTextBoxColumn,
            this.polazisnastanicaDataGridViewTextBoxColumn,
            this.odredisnastanicaDataGridViewTextBoxColumn,
            this.vrijemetrajanjaDataGridViewTextBoxColumn});
            this.dgvVozniRedovi.DataSource = this.vozniRedBindingSource;
            this.dgvVozniRedovi.Location = new System.Drawing.Point(63, 305);
            this.dgvVozniRedovi.Name = "dgvVozniRedovi";
            this.dgvVozniRedovi.RowHeadersWidth = 62;
            this.dgvVozniRedovi.RowTemplate.Height = 28;
            this.dgvVozniRedovi.Size = new System.Drawing.Size(1258, 480);
            this.dgvVozniRedovi.TabIndex = 11;
            // 
            // idvoznogredaDataGridViewTextBoxColumn
            // 
            this.idvoznogredaDataGridViewTextBoxColumn.DataPropertyName = "id_voznog_reda";
            this.idvoznogredaDataGridViewTextBoxColumn.HeaderText = "id_voznog_reda";
            this.idvoznogredaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idvoznogredaDataGridViewTextBoxColumn.Name = "idvoznogredaDataGridViewTextBoxColumn";
            this.idvoznogredaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazivlinijeDataGridViewTextBoxColumn
            // 
            this.nazivlinijeDataGridViewTextBoxColumn.DataPropertyName = "naziv_linije";
            this.nazivlinijeDataGridViewTextBoxColumn.HeaderText = "naziv_linije";
            this.nazivlinijeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nazivlinijeDataGridViewTextBoxColumn.Name = "nazivlinijeDataGridViewTextBoxColumn";
            this.nazivlinijeDataGridViewTextBoxColumn.Width = 150;
            // 
            // polazisnastanicaDataGridViewTextBoxColumn
            // 
            this.polazisnastanicaDataGridViewTextBoxColumn.DataPropertyName = "polazisna_stanica";
            this.polazisnastanicaDataGridViewTextBoxColumn.HeaderText = "polazisna_stanica";
            this.polazisnastanicaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.polazisnastanicaDataGridViewTextBoxColumn.Name = "polazisnastanicaDataGridViewTextBoxColumn";
            this.polazisnastanicaDataGridViewTextBoxColumn.Width = 150;
            // 
            // odredisnastanicaDataGridViewTextBoxColumn
            // 
            this.odredisnastanicaDataGridViewTextBoxColumn.DataPropertyName = "odredisna_stanica";
            this.odredisnastanicaDataGridViewTextBoxColumn.HeaderText = "odredisna_stanica";
            this.odredisnastanicaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.odredisnastanicaDataGridViewTextBoxColumn.Name = "odredisnastanicaDataGridViewTextBoxColumn";
            this.odredisnastanicaDataGridViewTextBoxColumn.Width = 150;
            // 
            // vrijemetrajanjaDataGridViewTextBoxColumn
            // 
            this.vrijemetrajanjaDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_trajanja";
            this.vrijemetrajanjaDataGridViewTextBoxColumn.HeaderText = "vrijeme_trajanja";
            this.vrijemetrajanjaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vrijemetrajanjaDataGridViewTextBoxColumn.Name = "vrijemetrajanjaDataGridViewTextBoxColumn";
            this.vrijemetrajanjaDataGridViewTextBoxColumn.Width = 150;
            // 
            // vozniRedBindingSource2
            // 
            this.vozniRedBindingSource2.DataMember = "VozniRed";
            this.vozniRedBindingSource2.DataSource = this.pI2324_nrastija22_DBDataSet;
            // 
            // btnPonistiFilter
            // 
            this.btnPonistiFilter.Location = new System.Drawing.Point(742, 182);
            this.btnPonistiFilter.Name = "btnPonistiFilter";
            this.btnPonistiFilter.Size = new System.Drawing.Size(148, 46);
            this.btnPonistiFilter.TabIndex = 12;
            this.btnPonistiFilter.Text = "Poništi";
            this.btnPonistiFilter.UseVisualStyleBackColor = true;
            this.btnPonistiFilter.Click += new System.EventHandler(this.btnPonistiFilter_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1360, 820);
            this.Controls.Add(this.btnPonistiFilter);
            this.Controls.Add(this.dgvVozniRedovi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.btn_AzurirajVozniRed);
            this.Controls.Add(this.btn_NoviVozniRed);
            this.Controls.Add(this.lblVozniRedovi);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.lblNaslovApk);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pI2324_nrastija22_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozniRedovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozniRedBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovApk;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblVozniRedovi;
        private System.Windows.Forms.Button btn_NoviVozniRed;
        private System.Windows.Forms.Button btn_AzurirajVozniRed;
        private PI2324_nrastija22_DBDataSet pI2324_nrastija22_DBDataSet;
        private System.Windows.Forms.BindingSource vozniRedBindingSource;
        private PI2324_nrastija22_DBDataSetTableAdapters.VozniRedTableAdapter vozniRedTableAdapter;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.RichTextBox txtPretrazivanje;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.BindingSource vozniRedBindingSource1;
        private System.Windows.Forms.DataGridView dgvVozniRedovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvoznogredaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivlinijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polazisnastanicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odredisnastanicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemetrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vozniRedBindingSource2;
        private System.Windows.Forms.Button btnPonistiFilter;
    }
}