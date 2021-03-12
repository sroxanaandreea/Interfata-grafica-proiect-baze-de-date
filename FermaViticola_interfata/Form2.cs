using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace FermaViticola_interfata
{
    public partial class Form2 : Form
    {
        //Conectarea la baza de date
        String connectString = @"Data Source=DESKTOP-J3NURFP\SQLEXPRESS;Initial Catalog=" + '\u0022' + "Ferma Viticola" + '\u0022' + ";Integrated Security=True"; //Conectarea la baza de date

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Verific daca itemul selectat in combobox1 corespunzator textului "selectati tabelul" este "Produs" 
            
            if (comboBox1.SelectedItem == ("Produs"))
            {
                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Nume_Produs"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Nume_produs"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produs WHERE Nume_produs like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Culoare"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Culoare"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produs WHERE Culoare like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Stil"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Stil"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produs WHERE Stil like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Cantitate_sticla"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Cantitate_sticla"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produs WHERE Cantitate_sticla like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Pret"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Pret"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produs WHERE Pret like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }
            }

            //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Tip_produs"
            //Daca este ,atunci se vor afisa doar produsele cautate.
            if (comboBox1.SelectedItem == ("Tip_Produs"))
            {
                if (comboBox2.SelectedItem == ("Categorie"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tip_Produs WHERE Categorie like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

            }

            //Verific daca itemul selectat in combobox1 corespunzator textului "selectati tabelul" este "Curier" 
            if (comboBox1.SelectedItem == ("Curier"))
            {
                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Nume_curier"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Nume_curier"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Curier WHERE Nume_curier like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Prenume_curier"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Prenume_curier"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Curier WHERE Prenume_curier like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Nr_telefon_curier"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Nr_telefon_curier"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Curier WHERE Nr_telefon_curier like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

            }

            //Verific daca itemul selectat in combobox1 corespunzator textului "selectati tabelul" este "Comenzi" 
            if (comboBox1.SelectedItem == ("Comenzi"))
            {
                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Data"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Data"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Comenzi WHERE Data like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Ora"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Ora"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Comenzi WHERE Ora like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

            }

            //Verific daca itemul selectat in combobox1 corespunzator textului "selectati tabelul" este "Client"
            if (comboBox1.SelectedItem == ("Client"))
            {
                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Nume_client"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Nume_client"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE Nume_client like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Prenume_client"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Prenume_client"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE Prenume_client like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Nr_telefon_client"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Nr_telefon_client"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE Nr_telefon_client like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Adresa_email"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Adresa_email"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE Adresa_email like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Sex"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Sex"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE Sex like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Data_nasterii"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Data_nasterii"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Client WHERE Data_nasterii like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }
            }

            //Verific daca itemul selectat in combobox1 corespunzator textului "selectati tabelul" este "Adresa"
            if (comboBox1.SelectedItem == ("Adresa"))
            {
                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Tara"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Tara"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Adresa WHERE Tara like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Judet"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Judet"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Adresa WHERE Judet like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Oras"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Oras"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Adresa WHERE Oras like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Cod_postal"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Cos_postal"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Adresa WHERE Cod_postal like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Strada"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Strada"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Adresa WHERE Strada like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }

                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Numar"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Numar"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Adresa WHERE Numar like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }
            }

            //Verific daca itemul selectat in combobox1 corespunzator textului "selectati tabelul" este "Tip_Adresa"
            if (comboBox1.SelectedItem == ("Tip_Adresa"))
            {
                //Verific daca itemul selectat in combobox2 corespunzator textului "Cautati dupa" este "Tip"
                //Daca este ,atunci se vor afisa doar produsele cautate.
                if (comboBox2.SelectedItem == ("Tip"))
                {
                    SqlConnection sqlCon = new SqlConnection(connectString);
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tip_Adresa WHERE Tip like '" + textBox1.Text + "%' ", sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlCon.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Butonul care inchide formularul
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.adresaTableAdapter.Fill(this.ferma_ViticolaDataSet.Adresa);
            //Adaug in caseta "Selectati tabelul" numele tabelelor din baza de date
            comboBox1.Items.Add("Produs");
            comboBox1.Items.Add("Tip_Produs");
            comboBox1.Items.Add("Curier");
            comboBox1.Items.Add("Comenzi");
            comboBox1.Items.Add("Client");
            comboBox1.Items.Add("Adresa");
            comboBox1.Items.Add("Tip_Adresa");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verific daca itemul selectat in combobox1 corespunzatoare textului "selectati tabelul" este "Produs"
            //Daca este atunci in caseta combobox2 corespunzatoare textului "cautati dupa" adauga datele
            if (comboBox1.SelectedItem == ("Produs"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString); //Conectarea la baza de date
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Produs", sqlCon); //Se afiseaza toate datele din tabelul "Produs"
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                //Se ascund coloanele 0 si 6
                dataGridView1.Columns[0].Visible = false; 
                dataGridView1.Columns[6].Visible = false;
                sqlCon.Close();

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Nume_produs");
                comboBox2.Items.Add("Culoare");
                comboBox2.Items.Add("Stil");
                comboBox2.Items.Add("Cantitate_sticla");
                comboBox2.Items.Add("Pret");
            }

            //Verific daca itemul selectat in combobox1 corespunzatoare textului "selectati tabelul" este "Tip_Produs"
            //Daca este atunci in caseta combobox2 corespunzatoare textului "cautati dupa" adauga datele
            if (comboBox1.SelectedItem == ("Tip_Produs"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Tip_Produs", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                sqlCon.Close();

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Categorie");
            }

            //Verific daca itemul selectat in combobox1 corespunzatoare textului "selectati tabelul" este "Curier"
            //Daca este atunci in caseta combobox2 corespunzatoare textului "cautati dupa" adauga datele
            if (comboBox1.SelectedItem == ("Curier"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Curier", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                sqlCon.Close();

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Nume_curier");
                comboBox2.Items.Add("Prenume_curier");
                comboBox2.Items.Add("Nr_telefon_curier");
            }

            //Verific daca itemul selectat in combobox1 corespunzatoare textului "selectati tabelul" este "Comenzi"
            //Daca este atunci in caseta combobox2 corespunzatoare textului "cautati dupa" adauga datele
            if (comboBox1.SelectedItem == ("Comenzi"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Comenzi", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                sqlCon.Close();

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Data");
                comboBox2.Items.Add("Ora");
            }

            //Verific daca itemul selectat in combobox1 corespunzatoare textului "selectati tabelul" este "Client"
            //Daca este atunci in caseta combobox2 corespunzatoare textului "cautati dupa" adauga datele
            if (comboBox1.SelectedItem == ("Client"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Client", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                sqlCon.Close();

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Nume_client");
                comboBox2.Items.Add("Prenume_client");
                comboBox2.Items.Add("Nr_telefon_client");
                comboBox2.Items.Add("Adresa_email");
                comboBox2.Items.Add("Sex");
                comboBox2.Items.Add("Data_nasterii");
            }

            //Verific daca itemul selectat in combobox1 corespunzatoare textului "selectati tabelul" este "Adresa"
            //Daca este atunci in caseta combobox2 corespunzatoare textului "cautati dupa" adauga datele
            if (comboBox1.SelectedItem == ("Adresa"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Adresa", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                sqlCon.Close();

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Tara");
                comboBox2.Items.Add("Judet");
                comboBox2.Items.Add("Oras");
                comboBox2.Items.Add("Cod_postal");
                comboBox2.Items.Add("Strada");
                comboBox2.Items.Add("Numar");
            }

            //Verific daca itemul selectat in combobox1 corespunzatoare textului "selectati tabelul" este "Tip_Adresa"
            //Daca este atunci in caseta combobox2 corespunzatoare textului "cautati dupa" adauga datele
            if (comboBox1.SelectedItem == ("Tip_Adresa"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Tip_Adresa", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                sqlCon.Close();

                comboBox2.Items.Clear();
                comboBox2.Items.Add("Tip");
            }
        }
    }
}
