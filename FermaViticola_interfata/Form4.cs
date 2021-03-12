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
    public partial class Form4 : Form
    {

        String connectString = @"Data Source=DESKTOP-J3NURFP\SQLEXPRESS;Initial Catalog=" + '\u0022' + "Ferma Viticola" + '\u0022' + ";Integrated Security=True";//Conectarea la baza de date

        public Form4()
        {
            InitializeComponent();
        }

        int selectedRow;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Butonul care inchide formularul
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ferma_ViticolaDataSet.Curier' table. You can move, or remove it, as needed.
            this.curierTableAdapter.Fill(this.ferma_ViticolaDataSet.Curier);

            disp_data();    //Apelam disp_data
        }

        public void disp_data()
        {
            //Conectarea cu baza de date + afisarea continutului tabelului "Curier"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from Curier";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            sqlCon.Close();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //Conectarea la baza de date + inserarea datelor in tabelul "Curier" odata cu apasarea butonului "Insert"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Curier values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a introdus cu succes!"); //Afisarea unui mesaj
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Conectarea la baza de date + stergerea din tabelul "Curier" a unui rand.
            //Conditia de strgere: caseta textbox2 trebuie sa contina ceva.
            //Stergerea se efectueaza la apasarea butonului "Delete"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from Curier where Nume = '" + textBox2.Text + "'";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a sters cu succes!");//Afisarea unui mesaj
        }

        private void Update_Click(object sender, EventArgs e)
        {
            //Conectarea la baza de date + update-ul unui camp din tabelul "Curier"
            //Conditia de update: orice caseta textbox trebuie sa contina ceva.
            //Update-ul se efectueaza la apasarea butonului "Update"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update Curier set Nume = '" + textBox2.Text + "', Prenume = '" + textBox3.Text + "', Nr_telefon = '" + textBox4.Text + "'  where Nr_telefon = '" + textBox4.Text+"'";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a updatat cu succes!");//Afisarea unui mesaj
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //La apasarea unui rand din tabel, compeltarea in caseta textxbox se face automat cu datele de pe randul respectiv.
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
        }
    }
}
