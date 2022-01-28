using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B13_14
{
    public partial class PoKategorijama : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B13_14;Integrated Security=True");
        public PoKategorijama()
        {
            SqlCommand Ucitavanje = new SqlCommand("select distinct Naziv from Kategorija order by Naziv", conn);
            InitializeComponent();

            conn.Open();
            SqlDataReader rd = Ucitavanje.ExecuteReader();
            while(rd.Read())
            {
                checkedListBox1.Items.Add(rd.GetString(0));
            }
            conn.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count >= 3)
            {
                MessageBox.Show("mora 3 kategorije");
                return;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
                series.Points.Clear();

            SqlCommand komanda = new SqlCommand(@"select Sum(Autor_Izdanje.BrojIzdanja),Kategorija.Naziv from Kategorija
inner join Knjiga on Kategorija.KategorijaID = Knjiga.KategorijaID inner join Autor_Izdanje on
Knjiga.KnjigaID = Autor_Izdanje.KnjigaID  where Kategorija.Naziv = @p0 or  Kategorija.Naziv = @p1 or Kategorija.Naziv = @p2 group by Kategorija.Naziv",conn);
            try
            {
                    if (checkedListBox1.CheckedItems.Count != 3)
                throw new Exception("morate izabrati 3 kategorije");

                komanda.Parameters.AddWithValue("@p0",checkedListBox1.CheckedItems[0].ToString());
                komanda.Parameters.AddWithValue("@p1", checkedListBox1.CheckedItems[1].ToString());
                komanda.Parameters.AddWithValue("@p2", checkedListBox1.CheckedItems[2].ToString());

                conn.Open();
                SqlDataReader reader = komanda.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["Broj knjiga"].Points.AddXY(reader.GetString(1), Convert.ToInt32(reader.GetInt32(0)));
                }
                conn.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
