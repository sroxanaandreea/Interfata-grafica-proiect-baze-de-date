using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FermaViticola_interfata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();   //Apelam metoda in constructor;
        }

        private void customizeDesign()
        {
            panelEDITsubMenu.Visible = false; //Ascundem panoul "SubMenu" al butonului edit
        }

        private void hideSubMenu()
        {
            //In cazul in care panoul esti vizibil, se ascunde
            if (panelEDITsubMenu.Visible == true)
                panelEDITsubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            //Ascunde panoul de submeniu in cazul in care este deschis
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
  
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEDITsubMenu); //invocam metoda de a 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4()); //Deschide formularul 4 la apasarea butonului "Tabel Curier"
            hideSubMenu();              //Apelam hideSubMenu
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3()); //Deschide formularul 3 la apasarea butonului "Tabel Produs"
            hideSubMenu();              //Apelam hideSubMenu
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();              //Apelam hideSubMenu
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6()); //Deschide formularul 6 la apasarea butonului "Tabel Client"
            hideSubMenu();              //Apelam hideSubMenu
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7()); //Deschide formularul 7 la apasarea butonului "Tabel Adresa"
            hideSubMenu();              //Apelam hideSubMenu
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        //Pentru a deschide un formular "copil" in interiorul acestuia am nevoie de un nou Panel
        //Pentru ca formularul copil sa se deschida, trebuia sa ma asigur ca oricare alt formular deschis, se inchide
        //Atfel declaram o variabila privata "activeForm", iar valoarea acesteia o setam pe null.
        private Form activeForm = null; 
        private void openChildForm(Form childForm)
        {
            //Verificam daca exista vreun formular deschis si il inchidem
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;                             //Salvam formular care se deschide in variabila "activeForm"
            childForm.TopLevel = false;                         //Declaram ca formular tocmai deschis nu este principalul formular
            childForm.FormBorderStyle = FormBorderStyle.None;   //Scoatem marginile formularului nou deschis
            childForm.Dock = DockStyle.Fill;                    //Formularul se va intinde pe intreaga portiune a panoului
            panelChildForm.Controls.Add(childForm);             //In panoul "panelChildForm" adaugam formularul "copil"
            panelChildForm.Tag = childForm;
            childForm.BringToFront();                           //Aducem elementele din fomular in fata
            childForm.Show();                                   //Afisam formularul
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //La apasarea butonului "Home" se revine la pagina principala prin inchiderea oricarui formular activ la momentul respectiv.
            if (activeForm != null)
                activeForm.Close();
        }

        private void btnBazaDeDate_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2()); //Deschide formularul 2 la apasarea butonului "Baza de date"
        }

        private void btnInterogari_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5()); //Deschide formularul 5 la apasarea butonului "Interogari"
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Ferma Viticola Database";
        }
    }
}
