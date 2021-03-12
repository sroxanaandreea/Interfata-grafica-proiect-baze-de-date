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
    public partial class Form3 : Form
    {

        String connectString = @"Data Source=DESKTOP-J3NURFP\SQLEXPRESS;Initial Catalog=" + '\u0022' + "Ferma Viticola" + '\u0022' + ";Integrated Security=True"; //Conectarea la baza de date

        public Form3()
        {
            InitializeComponent();
        }

        int selectedRow;    //Declaram o variabita de tip int "selectedRow"

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Butonul care inchide formularul
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ferma_ViticolaDataSet1.Produs' table. You can move, or remove it, as needed.
            this.produsTableAdapter.Fill(this.ferma_ViticolaDataSet1.Produs);
            disp_data();    //Apelam disp_data

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //La apasarea unui rand din tabel, compeltarea in caseta textxbox se face automat cu datele de pe randul respectiv.
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
            textBox7.Text = row.Cells[6].Value.ToString();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //Conectarea la baza de date + inserarea datelor in tabelul "Produs" odata cu apasarea butonului "Insert"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Produs values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a introdus cu succes!"); //Afisarea unui mesaj
        }

        public void disp_data()
        {
            //Conectarea cu baza de date + afisarea continutului tabelului "Produs"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from Produs";
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
            //Conectarea la baza de date + update-ul unui camp din tabelul "Produs"
            //Conditia de update: orice caseta textbox trebuie sa contina ceva.
            //Update-ul se efectueaza la apasarea butonului "Update"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update Produs set Nume_produs = '" + textBox2.Text + "', Culoare = '" + textBox3.Text + "', Stil = '" + textBox4.Text + "', ID_TipProdus = '" + textBox7.Text + "'  where Pret = '" + textBox6.Text + "'";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a updatat cu succes!");//Afisarea unui mesaj
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Conextarea la baza de date + stergerea din tabelul "Produs" a unui rand.
            //Conditia de strgere: caseta textbox2 trebuie sa contina ceva.
            //Stergerea se efectueaza la apasarea butonului "Delete"
            SqlConnection sqlCon = new SqlConnection(connectString);
            sqlCon.Open();
            SqlCommand com = sqlCon.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from Produs where Nume_produs = '" + textBox2.Text + "'";
            com.ExecuteNonQuery();
            sqlCon.Close();
            disp_data();
            MessageBox.Show("S-a sters cu succes!");//Afisarea unui mesaj
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
