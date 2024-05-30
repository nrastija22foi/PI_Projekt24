namespace TestoBus
{
    partial class FrmInsert
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.lblVrijemeTrajanja = new System.Windows.Forms.Label();
            this.lblOdredisna = new System.Windows.Forms.Label();
            this.lblPolazišna = new System.Windows.Forms.Label();
            this.lblNazivLinije = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.lblNaslovApk = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNazivLinije = new System.Windows.Forms.RichTextBox();
            this.txtPolazisna = new System.Windows.Forms.TextBox();
            this.txtOdredisna = new System.Windows.Forms.TextBox();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(385, 561);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(253, 70);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unesi vozni red";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // lblVrijemeTrajanja
            // 
            this.lblVrijemeTrajanja.AutoSize = true;
            this.lblVrijemeTrajanja.Location = new System.Drawing.Point(140, 505);
            this.lblVrijemeTrajanja.Name = "lblVrijemeTrajanja";
            this.lblVrijemeTrajanja.Size = new System.Drawing.Size(122, 20);
            this.lblVrijemeTrajanja.TabIndex = 1;
            this.lblVrijemeTrajanja.Text = "Vrijeme trajanja:";
            // 
            // lblOdredisna
            // 
            this.lblOdredisna.AutoSize = true;
            this.lblOdredisna.Location = new System.Drawing.Point(136, 446);
            this.lblOdredisna.Name = "lblOdredisna";
            this.lblOdredisna.Size = new System.Drawing.Size(141, 20);
            this.lblOdredisna.TabIndex = 2;
            this.lblOdredisna.Text = "Odredišna stanica:";
            // 
            // lblPolazišna
            // 
            this.lblPolazišna.AutoSize = true;
            this.lblPolazišna.Location = new System.Drawing.Point(136, 386);
            this.lblPolazišna.Name = "lblPolazišna";
            this.lblPolazišna.Size = new System.Drawing.Size(136, 20);
            this.lblPolazišna.TabIndex = 3;
            this.lblPolazišna.Text = "Polazišna stanica:";
            // 
            // lblNazivLinije
            // 
            this.lblNazivLinije.AutoSize = true;
            this.lblNazivLinije.Location = new System.Drawing.Point(162, 288);
            this.lblNazivLinije.Name = "lblNazivLinije";
            this.lblNazivLinije.Size = new System.Drawing.Size(85, 20);
            this.lblNazivLinije.TabIndex = 4;
            this.lblNazivLinije.Text = "Naziv linije:";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(140, 214);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(137, 20);
            this.lblSifra.TabIndex = 5;
            this.lblSifra.Text = "Šifra voznog reda:";
            // 
            // txtDatum
            // 
            this.txtDatum.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDatum.Location = new System.Drawing.Point(675, 79);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(245, 26);
            this.txtDatum.TabIndex = 8;
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(675, 33);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(245, 26);
            this.txtKorime.TabIndex = 7;
            // 
            // lblNaslovApk
            // 
            this.lblNaslovApk.AutoSize = true;
            this.lblNaslovApk.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslovApk.Location = new System.Drawing.Point(41, 42);
            this.lblNaslovApk.Name = "lblNaslovApk";
            this.lblNaslovApk.Size = new System.Drawing.Size(283, 69);
            this.lblNaslovApk.TabIndex = 6;
            this.lblNaslovApk.Text = "TestoBus";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(293, 208);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(433, 26);
            this.txtSifra.TabIndex = 9;
            // 
            // txtNazivLinije
            // 
            this.txtNazivLinije.Location = new System.Drawing.Point(293, 249);
            this.txtNazivLinije.Name = "txtNazivLinije";
            this.txtNazivLinije.Size = new System.Drawing.Size(433, 94);
            this.txtNazivLinije.TabIndex = 10;
            this.txtNazivLinije.Text = "";
            // 
            // txtPolazisna
            // 
            this.txtPolazisna.Location = new System.Drawing.Point(293, 383);
            this.txtPolazisna.Name = "txtPolazisna";
            this.txtPolazisna.Size = new System.Drawing.Size(433, 26);
            this.txtPolazisna.TabIndex = 11;
            // 
            // txtOdredisna
            // 
            this.txtOdredisna.Location = new System.Drawing.Point(293, 440);
            this.txtOdredisna.Name = "txtOdredisna";
            this.txtOdredisna.Size = new System.Drawing.Size(433, 26);
            this.txtOdredisna.TabIndex = 12;
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.Location = new System.Drawing.Point(293, 499);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.Size = new System.Drawing.Size(433, 26);
            this.txtVrijeme.TabIndex = 13;
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(971, 661);
            this.Controls.Add(this.txtVrijeme);
            this.Controls.Add(this.txtOdredisna);
            this.Controls.Add(this.txtPolazisna);
            this.Controls.Add(this.txtNazivLinije);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.lblNaslovApk);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblNazivLinije);
            this.Controls.Add(this.lblPolazišna);
            this.Controls.Add(this.lblOdredisna);
            this.Controls.Add(this.lblVrijemeTrajanja);
            this.Controls.Add(this.btnUnos);
            this.Name = "FrmInsert";
            this.Text = "FrmInsert";
            this.Load += new System.EventHandler(this.FrmInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Label lblVrijemeTrajanja;
        private System.Windows.Forms.Label lblOdredisna;
        private System.Windows.Forms.Label lblPolazišna;
        private System.Windows.Forms.Label lblNazivLinije;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.Label lblNaslovApk;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.RichTextBox txtNazivLinije;
        private System.Windows.Forms.TextBox txtPolazisna;
        private System.Windows.Forms.TextBox txtOdredisna;
        private System.Windows.Forms.TextBox txtVrijeme;
    }
}