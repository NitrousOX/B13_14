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
    public partial class Knjige : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B13_14;Integrated Security=True");

        int max = 0;
        public Knjige()
        {
            SqlCommand knjiga = new SqlCommand("select distinct Naziv from Knjiga order by naziv",conn);
            SqlCommand kategorija = new SqlCommand("select distinct Naziv from Kategorija order by naziv", conn);
            InitializeComponent();
            conn.Open();
            SqlDataReader rd = knjiga.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd.GetString(0));
            }
            conn.Close();
            comboBox1.SelectedIndex = 0;


            conn.Open();
            SqlDataReader rd1 = kategorija.ExecuteReader();
            while (rd1.Read())
            {
                comboBox2.Items.Add(rd1.GetString(0));
            }
            conn.Close();
            comboBox2.SelectedIndex = 0;
            radioButton1.Checked = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = null;
            Bbtn.Enabled = false;

            comboBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox2.Enabled = true;
            textBox3.Enabled = true;
            Ubtn.Enabled = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            Bbtn.Enabled = true;

            comboBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox2.Enabled = false;
            textBox3.Enabled = false;
            Ubtn.Enabled = false;

            comboBox1.Text = null;
            textBox2.Text = null;
            comboBox2.Text = null;
            textBox3.Text = null;
            
        }

        private void Ubtn_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand Upisi = new SqlCommand("Insert into Knjiga values(@p1,@p2,@p3,@p4,@p5)", conn);
                SqlCommand Provera = new SqlCommand("Select * from Kategorija",conn);
                SqlCommand Sifra = new SqlCommand("select MAX(KnjigaID) from Knjiga", conn);

                conn.Open();
                max = (Int32)Sifra.ExecuteScalar() +1;
                conn.Close();

                if (String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(comboBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
                {
                    throw new Exception("Morate sve popuniti");
                }
                else
                {
                    for(int i=0;i<textBox2.Text.Length;i++)
                    {
                        if (!Char.IsDigit(textBox2.Text[i]))
                            throw new Exception("Mora biti broj");
                    }
                    if (Convert.ToInt32(textBox2.Text) <= 0)
                        throw new Exception("Mora biti veci broj od 0");

                    int tmp=0;
                    conn.Open();
                    SqlDataReader rd = Provera.ExecuteReader();
                    while(rd.Read())
                    {
                        if (comboBox2.Text == rd[1].ToString())
                            tmp = rd.GetInt32(0);
                    }
                    conn.Close();

                    Upisi.Parameters.AddWithValue("@p1", max);
                    Upisi.Parameters.AddWithValue("@p2", comboBox1.Text);
                    Upisi.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox2.Text));
                    Upisi.Parameters.AddWithValue("@p4", tmp);
                    Upisi.Parameters.AddWithValue("@p5", textBox3.Text);

                    conn.Open();
                    Upisi.ExecuteNonQuery();
                    max++;
                    conn.Close();
                    MessageBox.Show("Uspesno ste upisali");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
            SqlCommand Provera = new SqlCommand("select KnjigaID,Knjiga.Naziv,BrojStrana,Komentar,Kategorija.Naziv from Knjiga join Kategorija on Kategorija.KategorijaID = Knjiga.KategorijaID where KnjigaID = @p1", conn);

            try
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if (!Char.IsDigit(textBox1.Text[i]))
                        {
                            textBox1.Text = null;
                            throw new Exception("Mora biti broj");
                        }
                    }

                    Provera.Parameters.AddWithValue("@p1", textBox1.Text);
                    conn.Open();
                    SqlDataReader rd = Provera.ExecuteReader();
                    if (rd.HasRows)
                    {
                        Bbtn.Enabled = true;
                        while (rd.Read())
                        {
                            comboBox1.Text = rd[1].ToString();
                            textBox2.Text = rd[2].ToString();
                            comboBox2.Text = rd[4].ToString();
                            textBox3.Text = rd[3].ToString();
                        }
                    }
                    else
                    {
                        comboBox1.Text = null;
                        textBox2.Text = null;
                        comboBox2.Text = null;
                        textBox3.Text = null;
                        Bbtn.Enabled = false;
                    }
                }
                else {
                    comboBox1.Text = null;
                    textBox2.Text = null;
                    comboBox2.Text = null;
                    textBox3.Text = null;
                    Bbtn.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void Bbtn_Click(object sender, EventArgs e)
        {
            SqlCommand Brisi = new SqlCommand("delete from Knjiga where KnjigaID = @p1",conn);
            Brisi.Parameters.AddWithValue("@p1", textBox1.Text);
            conn.Open();
            Brisi.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Uspesno ste Obrisali");
            max--;
        }

    }
}
