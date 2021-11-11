using System;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "Hallo " + txtLogin.Text + ", willkommen zurück!";
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUrlaub_Click(object sender, EventArgs e)
        {
            timerReset(null, null);
            groupUrlaub.Show();
            groupArbeitstage.Hide();
            groupKrankheit.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

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

        private void lblAngemeldetals_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Am " + txtTag.Text + "." + txtMonat.Text + "."+ txtJahr.Text + " wurde " + txtStunden.Text + " Stunden geschufftet. Heftig!");
        }

        private void groupArbeitstage_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupKrankheit_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblAutoLogoff_Click(object sender, EventArgs e)
        {

        }

        private void MouseBewegt(object sender, MouseEventArgs e)
        {
            timerReset(null, null);
        }
    }
}
