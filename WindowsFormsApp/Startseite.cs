using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class Startseite : Form
    {
        public Startseite()
        {
            InitializeComponent();
        }

        DateTime EndOfTime;
        private void Startseite_Load(object sender, EventArgs e)
        {
            groupArbeitstage.Hide();
            groupUrlaub.Hide();
            groupKrankheit.Hide();
            groupSuperArbeit.Hide();
            groupSuperUrlaub.Hide();
            groupSuperKrank.Hide();
          
            timerReset(null, null);
            timer1.Start();
            button5_Click(sender, e); // alle Fenster schließen bei erneutem Login
        }

        private void timerReset(object sender,EventArgs e)
        {
            EndOfTime = DateTime.Now.AddMinutes(5);
            Timer tm = new Timer();
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = 1;
            tm.Enabled = true;
            tm_Tick(null, null);
        }
        private void tm_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = EndOfTime.Subtract(DateTime.Now);
            string s = string.Format("{0:d2}:{1:d2}", ts.Minutes, ts.Seconds);
            lblAutoLogoff.Text = s;
            if (ts.TotalMilliseconds < 0)
            {
                ((Timer)sender).Enabled = false;
                lblAbm_LinkClicked(null,null);
            }
        }
        public void button5_Click(object sender, EventArgs e)
        {
            if (btnUrlaub.Text == "Urlaubstage verwalten")
            {
                timerReset(null, null);
                groupUrlaub.Hide();
                groupKrankheit.Hide();
                groupArbeitstage.Hide();
            }
            else
            {
                groupSuperUrlaub.Hide();
                groupSuperArbeit.Hide();
                groupSuperKrank.Hide();
            }
        }
        
        private void btnUrlaub_Click(object sender, EventArgs e)
        {
            if (btnUrlaub.Text == "Urlaubstage verwalten")
            {
                lstUrlaub();
                timerReset(null, null);
                groupUrlaub.Show();
                groupArbeitstage.Hide();
                groupKrankheit.Hide();
            }
            else
            {
                button5_Click(null, null);
                groupSuperUrlaub.Show();
                groupSuperArbeit.Hide();
                groupSuperKrank.Hide();
            }
        }


        private void btnArbeitszeit_Click(object sender, EventArgs e)
        {
            if (btnArbeitszeit.Text == "Arbeitszeit verwalten")
            {
                timerReset(null, null);
                groupArbeitstage.Show();
                groupUrlaub.Hide();
                groupKrankheit.Hide();
            } else
            {
                button5_Click(null, null);
                groupSuperArbeit.Show();
                groupSuperUrlaub.Hide();
                groupSuperKrank.Hide();
            }
        }

        private void lblAbm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSecond.Location.Y);
        }

        private void btnKrankheit_Click(object sender, EventArgs e)
        {
            if (btnKrankheit.Text == "Krankheitstage verwalten")
            {
                timerReset(null, null);
                groupKrankheit.Show();
                groupArbeitstage.Hide();
                groupUrlaub.Hide();
            }
            else
            {
                button5_Click(null, null);
                groupSuperKrank.Show();
                groupSuperArbeit.Show();
                groupSuperUrlaub.Hide();
            }
        }

        private void MouseBewegt(object sender, MouseEventArgs e)
        {
            timerReset(null, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button5_Click(null, null);
        }
        public void lstUrlaub() { 
            //public Form1 form1 { get; set; }
            string constring = @"Data Source=DITIB-01\SQLEXPRESSNR2;Initial Catalog=master;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Datum,Anmeldename FROM Kalendereinträge WHERE Anmeldename='" + form1.txtLogin.Text + "'", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            ds.Tables.Add(dt);
            dataGridView1.ReadOnly = true;
        }
    
        
        private void btnUrl_Click(object sender, EventArgs e)
        {
            
            lblCalendarUrlaub.Text = 
                "Urlaub von " + CalendarUrlaub.SelectionStart.ToShortDateString() + " bis " + CalendarUrlaub.SelectionEnd.ToShortDateString();         
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lblCalendarKrank.Text = 
                "Krank von " + CalendarKrank.SelectionStart.ToShortDateString() + " bis " + CalendarKrank.SelectionEnd.ToShortDateString();
        }

        private void btnArb_Click(object sender, EventArgs e)
        {
            txtStunden.Text = "";
            lblCalendarArbeit.Text =
                "Gearbeitet an Tagen: " + CalendarArbeit.SelectionStart.ToShortDateString() + " - " + CalendarArbeit.SelectionEnd.ToShortDateString() + " für " + txtStunden.Text + " Stunden" ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupKrankheit.Hide();
            groupArbeitstage.Hide();
            groupUrlaub.Hide();

            btnSupertools.Hide();
            button3.Show();

            btnArbeitszeit.Text = "Alle Arbeitszeiten verwalten";
            btnUrlaub.Text = "Alle Urlaubstage verwalten";
            btnKrankheit.Text = "Alle Krankheitstage verwalten";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupSuperArbeit.Hide();
            groupSuperKrank.Hide();
            groupSuperUrlaub.Hide();

            btnSupertools.Show();
            btnArbeitszeit.Text = "Arbeitszeit verwalten";
            btnUrlaub.Text = "Urlaubstage verwalten";
            btnKrankheit.Text = "Krankheitstage verwalten";
        }
    }
}
