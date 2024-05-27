using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using TestoBus.Models;

namespace TestoBus
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            LoadData();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.vozniRedTableAdapter.Fill(this.pI2324_nrastija22_DBDataSet.VozniRed);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData(string searchTerm = "")
        {
            DB.OpenConnection();
            DB.SetConfiguration("PI2324_nrastija22_DB", "PI2324_nrastija22_User", "dxUnFiR#");

            // Kreiraj SQL upit za pretragu
            string query = "SELECT * FROM VozniRed";
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " WHERE vrijeme_trajanja LIKE @SearchTerm";
            }

            // Dobij podatke iz baze
            var parameters = new { SearchTerm = "%" + searchTerm + "%" };
            var data = DB.GetDataReader(query);
            dataGridView1.DataSource = data;

            string search = txtSearch.Text;
            List<VozniRed> requestsSearch = RequestRepository.GetRequestsSearch(FrmLogin.LoggedSubmitter.Id, search);
            if (requestsSearch.Count == 0)
            {
                MessageBox.Show("Nije pronađen nijedan zahtjev!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dataGridView1.DataSource = requestsSearch;

                dataGridView1.Columns["Id"].HeaderText = "Šifra voznog reda";
                dataGridView1.Columns["Naziv"].HeaderText = "Naziv voznog reda";
                dataGridView1.Columns["Polazisna"].HeaderText = "Polazišna stanica";
                dataGridView1.Columns["Odredisna"].HeaderText = "Odredišna stanica";
                dataGridView1.Columns["Vrijeme"].HeaderText = "Vrijeme trajanja";
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string searchTerm = txtPretrazivanje.Text;
            LoadData(searchTerm);
        }
    }
}
