using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            timerReset(null, null);
            groupUrlaub.Hide();
            groupKrankheit.Hide();
            groupArbeitstage.Hide();
        }

        private void btnUrlaub_Click(object sender, EventArgs e)
        {
            timerReset(null, null);
            groupUrlaub.Show();
            groupArbeitstage.Hide();
            groupKrankheit.Hide();
        }


        private void btnArbeitszeit_Click(object sender, EventArgs e)
        {
            timerReset(null, null);
            groupArbeitstage.Show();
            groupUrlaub.Hide();
            groupKrankheit.Hide();
        }

        private void lblAbm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            //lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            //lblDay.Text = DateTime.Now.ToString("dddd");
            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSecond.Location.Y);
        }

        private void btnKrankheit_Click(object sender, EventArgs e)
        {
            timerReset(null, null);
            groupKrankheit.Show();
            groupArbeitstage.Hide();
            groupUrlaub.Hide();
        }

        private void MouseBewegt(object sender, MouseEventArgs e)
        {
            timerReset(null, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button5_Click(null, null);
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
            lblCalendarArbeit.Text =
                "Gearbeitet an Tagen: " + CalendarArbeit.SelectionStart.ToShortDateString() + " - " + CalendarArbeit.SelectionEnd.ToShortDateString() + " für " + txtStunden.Text + " Stunden" ;
        }
    }
}
