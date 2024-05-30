﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using TestoBus.Models;
using TestoBus.Repozitoriji;

namespace TestoBus
{
    public partial class FrmMain : Form
    {
  
        public FrmMain()
        {
            InitializeComponent();
            UcitajZaposlenika();
            dgvVozniRedovi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVozniRedovi.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        public void UcitajZaposlenika()
        {
            txtKorime.Text = RepozitorijRadnik.ImePrezime();
            txtDatum.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            ShowRequests();
        }

        private void ShowRequests()
        {
            List<VozniRed> vozniRedovi = RepozitorijZahtjeva.DohvatiVozneRedove();
            if (vozniRedovi == null)
            {
                return;
            }

            dgvVozniRedovi.AutoGenerateColumns = true;
            dgvVozniRedovi.DataSource = vozniRedovi;

            /*dgvVozniRedovi.DefaultCellStyle.BackColor = Color.FromArgb(44, 44, 44);
            dgvVozniRedovi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 44, 44);
            dgvVozniRedovi.DefaultCellStyle.ForeColor = Color.White;
            dgvVozniRedovi.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 44, 44);
            dgvVozniRedovi.DefaultCellStyle.SelectionBackColor = Color.FromArgb(194, 214, 224);
            dgvVozniRedovi.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvVozniRedovi.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 44, 44);
            dgvVozniRedovi.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(194, 214, 224);*/

            dgvVozniRedovi.EnableHeadersVisualStyles = false;
            dgvVozniRedovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvVozniRedovi.Columns["Id"].HeaderText = "Šifra voznog reda";
            dgvVozniRedovi.Columns["Naziv"].HeaderText = "Naziv linije";
            dgvVozniRedovi.Columns["Polazisna"].HeaderText = "Polazišna stanica";
            dgvVozniRedovi.Columns["Odredisna"].HeaderText = "Odredišna stanica";
            dgvVozniRedovi.Columns["Vrijeme"].HeaderText = "Vrijeme trajanja vožnje";
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string tekstPretrage = txtPretrazivanje.Text;
            List<VozniRed> PretrazivanjeVoznihRedova = RepozitorijZahtjeva.PretraziVozneRedove(tekstPretrage); 

            if (PretrazivanjeVoznihRedova.Count == 0)
            {
                MessageBox.Show("Nije pronađen ni jedan upis!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvVozniRedovi.DataSource = PretrazivanjeVoznihRedova;
                dgvVozniRedovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void btnPonistiFilter_Click(object sender, EventArgs e)
        {
            string tekstPretrage = "reset";
            List<VozniRed> PretrazivanjeVoznihRedova = RepozitorijZahtjeva.PretraziVozneRedove(tekstPretrage);

            if (PretrazivanjeVoznihRedova.Count == 0)
            {
                MessageBox.Show("Nije pronađen ni jedan upis!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvVozniRedovi.DataSource = PretrazivanjeVoznihRedova;
                dgvVozniRedovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void btn_NoviVozniRed_Click(object sender, EventArgs e)
        {
            FrmInsert frmInsert = new FrmInsert();
            frmInsert.ShowDialog();
            ShowRequests();
        }

        private void btn_AzurirajVozniRed_Click(object sender, EventArgs e)
        {
            if (dgvVozniRedovi.CurrentRow == null)
            {
                MessageBox.Show("Nijedan red nije selektovan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VozniRed oznaceniVozniRed = dgvVozniRedovi.CurrentRow.DataBoundItem as VozniRed;
            if (oznaceniVozniRed != null)
            {
                FrmUpdate Azuriranje = new FrmUpdate(oznaceniVozniRed);
                Azuriranje.RequestUpdated += FrmUpdate_RequestUpdated;
                Azuriranje.ShowDialog();
            }
            else
            {
                MessageBox.Show("Odabrani red nije validan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowRequests();
        }

        private void FrmUpdate_RequestUpdated(object sender, EventArgs e)
        {
            ShowRequests();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            VozniRed oznaceniVozniRed = dgvVozniRedovi.CurrentRow.DataBoundItem as VozniRed;
            if (oznaceniVozniRed != null)
            { 
                RepozitorijZahtjeva.ObrisiVozniRed(oznaceniVozniRed.Id);
            }
            else
            {
                MessageBox.Show("Odabrani red nije validan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowRequests();
        }
    }

        

  }
