﻿using System;
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
        public static string passingLogin;
        public static string passingPosition;
        Startseite startseite = new Startseite();

        public Form1()
        {
            InitializeComponent();
        }
        string constring = @"Data Source=DESKTOP-B8UQBUJ\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            //startseite.ShowDialog();        
            SqlConnection con = new SqlConnection(constring); // making connection   
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
                passingLogin = txtLogin.Text;
                passingPosition = dt2.Rows[0][0].ToString();
                startseite.ShowDialog();
                lblPasserror.Hide();
            }
            else
            {
                lblPasserror.Show();
                lblPasserror.Text = "Invalid username or password";
            }
            checkBox1.Checked = false;
        }  
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
