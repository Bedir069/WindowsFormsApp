using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace WindowsFormsApp
{

    public partial class Form1 : Form
    { 
              
        Startseite startseite = new Startseite();
        Help help = new Help();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B8UQBUJ\SQLEXPRESS;Initial Catalog=Benutzerdatenbank;Integrated Security=True"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Benutzerdaten WHERE Anmeldename='" + txtLogin.Text + "' AND Passwort='" + txtPassword.Text + "'", con);
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Position FROM Benutzerdaten WHERE Anmeldename='" + txtLogin.Text + "' AND Passwort='" + txtPassword.Text + "'", con);

            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            DataTable dt2 = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            sda2.Fill(dt2);
            if (dt.Rows[0][0].ToString() == "1")
            {
                startseite.lblAngemeldetals.Text = "Angemeldet als " + dt2.Rows[0][0].ToString();
                startseite.ShowDialog();
                lblPasserror.Hide();
            }
            else
                lblPasserror.Show();
                lblPasserror.Text = "Invalid username or password";
        }
        
        private void hide()
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SoFT_Click(object sender, EventArgs e)
        {

        }
   

        private void lblHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            help.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    
    }
}
