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
    public partial class Form7 : Form
    {

        String connectString = @"Data Source=DESKTOP-J3NURFP\SQLEXPRESS;Initial Catalog=" + '\u0022' + "Ferma Viticola" + '\u0022' + ";Integrated Security=True"; //Conectarea la baza de date

        public Form7()
        {
            InitializeComponent();
        }

        int selectedRow;    //Declaram o variabita de tip int "selectedRow"

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ferma_ViticolaDataSet3.Adresa' table. You can move, or remove it, as needed.
            this.adresaTableAdapter.Fill(this.ferma_ViticolaDataSet3.Adresa);
            disp_data();    //Apelam disp_data
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Butonul care inchide formularul
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //La apasarea unui rand din tabel, compeltarea in caseta textxbox se face automat cu datele de pe randul respectiv.
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();
            textBox5.Text = row.Cells[5].Value.ToString();
            textBox6.Text = row.Cells[6].Value.ToString();
            textBox7.Text = row.Cells[7].Value.ToString();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //Conectarea la baza de date + inserarea datelor in tabelul "Client" odata cu apasarea butonului "Insert"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Adresa values ('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a introdus cu succes!"); //Afisarea unui mesaj
        }

        public void disp_data()
        {
            //Conectarea cu baza de date + afisarea continutului tabelului "Adresa"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from Adresa";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            //Conectarea la baza de date + update-ul unui camp din tabelul "Adresa"
            //Conditia de update: orice caseta textbox trebuie sa contina ceva.
            //Update-ul se efectueaza la apasarea butonului "Update"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update Adresa set Tara = '" + textBox2.Text + "', Judet = '" + textBox3.Text + "', Oras = '" + textBox4.Text + "', Cod_postal = '" + textBox5.Text + "', Strada = '" + textBox6.Text + "'  where Numar = '" + textBox7.Text + "'";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a updatat cu succes!");//Afisarea unui mesaj
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Conextarea la baza de date + stergerea din tabelul "Adresa" a unui rand.
            //Conditia de strgere: caseta textbox1 trebuie sa contina ceva.
            //Stergerea se efectueaza la apasarea butonului "Delete"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from Adresa where Cod_postal = '" + textBox5.Text + "'";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a sters cu succes!");//Afisarea unui mesaj
        }
    }
}
