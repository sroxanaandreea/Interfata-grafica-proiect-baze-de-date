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
    public partial class Form5 : Form
    {

        String connectString = @"Data Source=DESKTOP-J3NURFP\SQLEXPRESS;Initial Catalog=" + '\u0022' + "Ferma Viticola" + '\u0022' + ";Integrated Security=True"; //Conectarea la baza de date


        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Butonul care inchide formularul
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //Adaug in caseta combobox3 corespunzatoare textului "Verificati" datele corespunzatoare
            comboBox3.Items.Add("cate comenzi trebuie sa livreze un curier");
            comboBox3.Items.Add("numele si prenumele clientului care a comandat un produs cu pretul mai mare de 50RON");
            comboBox3.Items.Add("toate comenzile date din Judetul Prahova");
            comboBox3.Items.Add("toate comenzile date de o persoana cu sex feminin");
            comboBox3.Items.Add("numele si tipul produselor comandate de un client a carui adresa este din judetul Bucuresti");
            comboBox3.Items.Add("produsele comandate de client cu varsta mai mare de 30 de ani.");
            comboBox3.Items.Add("in ce an s-au plasat cele mai multe comenzi. Afisati anul si numarul comenzilor");
            comboBox3.Items.Add("curierii care livreaza cel putin 2 comenzi");
            comboBox3.Items.Add("curierii care nu livreaza nicio comanda");
            comboBox3.Items.Add("numele, culoarea si stilul primelor 3 produse in functie de pret");

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verific daca in caseta combobox3 corespunzatoare textului "verificati" a fost selectat textul "cate comenzi trebuie sa livreze un curier"
            //Daca da atunci se efectueaza interogarea corespunzatoare 
            if (comboBox3.SelectedItem == ("cate comenzi trebuie sa livreze un curier"))
            {
                //Se creeaza conexiunea cu baza de date
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT C.Nume, Count(CM.ID_Curier) as Cate_Comenzi_Livreaza FROM  Curier C INNER JOIN Comenzi CM ON C.ID_Curier = CM.ID_Curier GROUP BY C.Nume ", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlCon.Close();
            }

            //Verific daca in caseta combobox3 corespunzatoare textului "numele si prenumele clientului care a comandat un produs cu pretul mai mare de 50RON"
            //Daca da atunci se efectueaza interogarea corespunzatoare 
            if (comboBox3.SelectedItem == ("numele si prenumele clientului care a comandat un produs cu pretul mai mare de 50RON"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CL.Nume_Client, CL.Prenume_Client, P.Pret FROM Client CL JOIN Comenzi CM ON CL.ID_Client = CM.ID_Client JOIN Produs P ON CM.ID_Produs = P.ID_Produs WHERE P.Pret > 50 ", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlCon.Close();
            }

            //Verific daca in caseta combobox3 corespunzatoare textului "toate comenzile date din Judetul Prahova"
            //Daca da atunci se efectueaza interogarea corespunzatoare 
            if (comboBox3.SelectedItem == ("toate comenzile date din Judetul Prahova"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CM.Nume_Comanda FROM  Comenzi CM JOIN Adresa A ON CM.ID_Adresa = A.ID_Adresa WHERE A.Judet = 'Prahova'  ", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlCon.Close();
            }

            //Verific daca in caseta combobox3 corespunzatoare textului "toate comenzile date de o persoana cu sex feminin"
            //Daca da atunci se efectueaza interogarea corespunzatoare 
            if (comboBox3.SelectedItem == ("toate comenzile date de o persoana cu sex feminin"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CM.Nume_Comanda FROM  Comenzi CM JOIN Client CL ON CM.ID_Client = CL.ID_Client WHERE CL.Sex = 'F'  ", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlCon.Close();
            }

            //Verific daca in caseta combobox3 corespunzatoare textului "numele si tipul produselor comandate de un client a carui adresa este din judetul Bucuresti"
            //Daca da atunci se efectueaza interogarea corespunzatoare 
            if (comboBox3.SelectedItem == ("numele si tipul produselor comandate de un client a carui adresa este din judetul Bucuresti"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT P.Nume_produs , P.Stil, P.Culoare FROM Produs P JOIN Comenzi CM ON P.ID_Produs = CM.ID_Produs JOIN Client CL ON CM.ID_Client = CL.ID_Client JOIN Adresa A ON CL.ID_Adresa = A.ID_Adresa WHERE A.Judet = 'Bucuresti'  ", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlCon.Close();
            }

            //Verific daca in caseta combobox3 corespunzatoare textului "produsele comandate de client cu varsta mai mare de 30 de ani."
            //Daca da atunci se efectueaza interogarea corespunzatoare 
            if (comboBox3.SelectedItem == ("produsele comandate de client cu varsta mai mare de 30 de ani."))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT P.Nume_produs , P.Stil, P.Culoare, P.Cantitate_sticla, P.Pret FROM Produs P JOIN Comenzi CM ON P.ID_Produs = CM.ID_Produs JOIN Client CL ON CM.ID_Client = CL.ID_Client WHERE CL.Data_nasterii > '1990-01-01'  ", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlCon.Close();
            }

            //Verific daca in caseta combobox3 corespunzatoare textului "in ce an s-au plasat cele mai multe comenzi. Afisati anul si numarul comenzilor"
            //Daca da atunci se efectueaza interogarea corespunzatoare 
            if (comboBox3.SelectedItem == ("in ce an s-au plasat cele mai multe comenzi. Afisati anul si numarul comenzilor"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT year(CM.Data), count(*) FROM Comenzi CM WHERE year(CM.Data) IS NOT NULL GROUP BY year(CM.Data) HAVING count(*) >= ALL(SELECT count(*) FROM Comenzi CMM WHERE year(CMM.Data) IS NOT NULL GROUP BY year(CMM.Data))  ", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlCon.Close();
            }

            //Verific daca in caseta combobox3 corespunzatoare textului "curierii care livreaza cel putin 2 comenzi"
            //Daca da atunci se efectueaza interogarea corespunzatoare 
            if (comboBox3.SelectedItem == ("curierii care livreaza cel putin 2 comenzi"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CR.Nume, CR.Prenume FROM Curier CR WHERE 1 < (SELECT count(*) FROM Comenzi CM WHERE CR.ID_Curier = CM.ID_Curier) ", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlCon.Close();
            }

            //Verific daca in caseta combobox3 corespunzatoare textului "curierii care nu livreaza nicio comanda"
            //Daca da atunci se efectueaza interogarea corespunzatoare 
            if (comboBox3.SelectedItem == ("curierii care nu livreaza nicio comanda"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select CR.Nume, CR.Prenume FROM Curier CR WHERE NOT EXISTS(SELECT CM.ID_Curier FROM Comenzi CM WHERE CM.ID_Curier = CR.ID_Curier)  ", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlCon.Close();
            }

            //Verific daca in caseta combobox3 corespunzatoare textului "numele, culoarea si stilul primelor 3 produse in functie de pret"
            //Daca da atunci se efectueaza interogarea corespunzatoare 
            if (comboBox3.SelectedItem == ("numele, culoarea si stilul primelor 3 produse in functie de pret"))
            {
                SqlConnection sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT P.Nume_produs, P.Culoare, P.Stil FROM Produs P WHERE 3 > (SELECT count(B.Pret) FROM Produs B WHERE P.Pret < B.Pret)  ", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlCon.Close();
            }
        
        }
    }
}
