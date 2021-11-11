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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Am " + txtTag.Text + "." + txtMonat.Text + "."+ txtJahr.Text + " wurde " + txtStunden.Text + " Stunden geschufftet. Heftig!");
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {          
            dtPickKrankBis.MinDate = dtPickKrankVon.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dtPickKrankBis.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dtPickKrankBis.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button5_Click(null, null);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dtPickUrlaubBis.MinDate = dtPickUrlaubVon.Value;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dtPickUrlaubBis.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dtPickUrlaubBis.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Enabled == true)
            {
                lblUrlaubAusgabe.Text = "Urlaub von " + dtPickUrlaubVon.Value.Date.ToShortDateString() + " bis " + dtPickUrlaubBis.Value.Date.ToShortDateString();
            }
            else
            {
                lblUrlaubAusgabe.Text = "Urlaub am " + dtPickUrlaubVon.Value.Date.ToShortDateString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Enabled == true)
            {
                lblAbmDatum.Text = "Kranktage von " + dtPickKrankVon.Value.Date.ToShortDateString() + " bis " + dtPickKrankBis.Value.Date.ToShortDateString();
            }
            else
            {
                lblAbmDatum.Text = "Kranktag am " + dtPickKrankVon.Value.Date.ToShortDateString();
            }
        }
    }
}
