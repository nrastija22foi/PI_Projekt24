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
            this.lblNaslovApk = new System.Windows.Forms.Label();
            this.txt_Korime = new System.Windows.Forms.TextBox();
            this.txt_Datum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_NoviVozniRed = new System.Windows.Forms.Button();
            this.btn_NoviAutobus = new System.Windows.Forms.Button();
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
            // txt_Korime
            // 
            this.txt_Korime.Location = new System.Drawing.Point(486, 24);
            this.txt_Korime.Name = "txt_Korime";
            this.txt_Korime.Size = new System.Drawing.Size(245, 26);
            this.txt_Korime.TabIndex = 1;
            // 
            // txt_Datum
            // 
            this.txt_Datum.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Datum.Location = new System.Drawing.Point(486, 61);
            this.txt_Datum.Name = "txt_Datum";
            this.txt_Datum.Size = new System.Drawing.Size(245, 26);
            this.txt_Datum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Popis autobusa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vozni redovi";
            // 
            // btn_NoviVozniRed
            // 
            this.btn_NoviVozniRed.Location = new System.Drawing.Point(289, 401);
            this.btn_NoviVozniRed.Name = "btn_NoviVozniRed";
            this.btn_NoviVozniRed.Size = new System.Drawing.Size(203, 40);
            this.btn_NoviVozniRed.TabIndex = 5;
            this.btn_NoviVozniRed.Text = "Novi vozni red";
            this.btn_NoviVozniRed.UseVisualStyleBackColor = true;
            // 
            // btn_NoviAutobus
            // 
            this.btn_NoviAutobus.Location = new System.Drawing.Point(326, 136);
            this.btn_NoviAutobus.Name = "btn_NoviAutobus";
            this.btn_NoviAutobus.Size = new System.Drawing.Size(227, 39);
            this.btn_NoviAutobus.TabIndex = 6;
            this.btn_NoviAutobus.Text = "Novi autobus";
            this.btn_NoviAutobus.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(836, 830);
            this.Controls.Add(this.btn_NoviAutobus);
            this.Controls.Add(this.btn_NoviVozniRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Datum);
            this.Controls.Add(this.txt_Korime);
            this.Controls.Add(this.lblNaslovApk);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovApk;
        private System.Windows.Forms.TextBox txt_Korime;
        private System.Windows.Forms.TextBox txt_Datum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_NoviVozniRed;
        private System.Windows.Forms.Button btn_NoviAutobus;
    }
}