using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TestoBus.Models
{
    public class RepozitorijZahtjeva
    {
        public static List<VozniRed> DohvatiVozneRedove()
        {
            List<VozniRed> zahtjevi = new List<VozniRed>();

            string sql = "SELECT * FROM dbo.VozniRed";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    VozniRed zahtjev = KreirajObjekt(reader);
                    zahtjevi.Add(zahtjev);
                }
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }

        public static List<VozniRed> PretraziVozneRedove(string parametar)
        {
            int.TryParse(parametar, out int numericParametar);
            string sql;

            if (numericParametar >= 1 && numericParametar <= 5)
            {
                sql = $"SELECT * FROM dbo.VozniRed where id_voznog_reda = {parametar}";
            }
            else if (parametar == "reset")
            {
                sql = "SELECT * FROM dbo.VozniRed";
            }
            else 
            {
                sql = $"SELECT * FROM dbo.VozniRed where vrijeme_trajanja = {parametar}";
            }

            if (!int.TryParse(parametar, out _) && parametar != "reset")
            {
                MessageBox.Show("Error: Parametar sadrži tekst.");
                return null;
            }

            List<VozniRed> zahtjevi = new List<VozniRed>();
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    VozniRed zahtjev = KreirajObjekt(reader);
                    zahtjevi.Add(zahtjev);
                }
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }
        public static VozniRed KreirajObjekt(SqlDataReader reader)
        {
            int id = int.Parse(reader["id_voznog_reda"].ToString());
            string naziv = reader["naziv_linije"].ToString();
            string polazisna = reader["polazisna_stanica"].ToString();
            string odredisna = reader["odredisna_stanica"].ToString();
            int vrijeme = int.Parse(reader["vrijeme_trajanja"].ToString());
            var novi = new VozniRed
            {
                Id = id,
                Naziv = naziv,
                Polazisna = polazisna,
                Odredisna = odredisna,
                Vrijeme = vrijeme,
            };
            return novi;
        }
    }
}
