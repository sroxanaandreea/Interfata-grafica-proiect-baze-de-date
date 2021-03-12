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
    public partial class Form6 : Form
    {

        String connectString = @"Data Source=DESKTOP-J3NURFP\SQLEXPRESS;Initial Catalog=" + '\u0022' + "Ferma Viticola" + '\u0022' + ";Integrated Security=True"; //Conectarea la baza de date

        public Form6()
        {
            InitializeComponent();
        }

        int selectedRow;    //Declaram o variabita de tip int "selectedRow"

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ferma_ViticolaDataSet2.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.ferma_ViticolaDataSet2.Client);
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
            com.CommandText = "insert into Client values ('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a introdus cu succes!"); //Afisarea unui mesaj
        }

        public void disp_data()
        {
            //Conectarea cu baza de date + afisarea continutului tabelului "Client"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from Client";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            sqlCon.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            //Conectarea la baza de date + update-ul unui camp din tabelul "Client"
            //Conditia de update: orice caseta textbox trebuie sa contina ceva.
            //Update-ul se efectueaza la apasarea butonului "Update"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update Client set Nume_Client = '" + textBox1.Text + "', Prenume_Client = '" + textBox2.Text + "', Nr_telefon_Client = '" + textBox3.Text + "', Sex = '" + textBox5.Text + "', Data_nasterii = '" + textBox6.Text + "', ID_Adresa = '" + textBox7.Text + "'  where Adresa_email = '" + textBox4.Text + "'";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a updatat cu succes!");//Afisarea unui mesaj
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Conextarea la baza de date + stergerea din tabelul "Client" a unui rand.
            //Conditia de strgere: caseta textbox1 trebuie sa contina ceva.
            //Stergerea se efectueaza la apasarea butonului "Delete"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from Client where Nume_Client = '" + textBox1.Text + "'";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a sters cu succes!");//Afisarea unui mesaj
        }
    }
}
