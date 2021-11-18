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
        public void allgroupHide()
        {
            groupArbeitstage.Hide();
            groupUrlaub.Hide();
            groupKrankheit.Hide();
            groupSuperArbeit.Hide();
            groupSuperUrlaub.Hide();
            groupSuperKrank.Hide();
            groupÜbersicht1.Hide();
            groupSuperÜbersicht.Hide();
        }
        DateTime EndOfTime;
        private void Startseite_Load(object sender, EventArgs e)
        {
            if (Form1.passingPosition == "Supervisor")
            {
                btnSupertools.Show();
                btnSupervisorEnd.Show();
            }
            else
            {
                btnSupertools.Hide();
                btnSupervisorEnd.Hide();
            }
            allgroupHide();
            timerReset(null, null);
            timer1.Start();
            lblWillkommen.Text = "Willkommen zurück, " + Form1.passingLogin + "!";
            btnÜbersicht_Click(sender, e); // alle Fenster schließen bei erneutem Login
        }

        private void timerReset(object sender, EventArgs e)
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
                lblAbm_LinkClicked(null, null);
            }
        }
        public void getNeuig()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Passwort FROM Benutzerdaten WHERE Anmeldename='Neuigkeiten'", con);
            DataTable dt1 = new DataTable();
            sda2.Fill(dt1);
            txtAusgabeEmploy.Text = dt1.Rows[0][0].ToString();
        }
        public void btnÜbersicht_Click(object sender, EventArgs e)
        {
            if (btnUrlaub.Text == "Urlaubstage verwalten")
            {
                getNeuig();
                lstAllOne();
                timerReset(null, null);
                allgroupHide();
                groupÜbersicht1.Show();
            }
            else
            {
                lstAll();
                allgroupHide();
                groupSuperÜbersicht.Show();
            }
        }

        private void btnUrlaub_Click(object sender, EventArgs e)
        {
            if (btnUrlaub.Text == "Urlaubstage verwalten")
            {
                lstUrlaub();
                timerReset(null, null);
                allgroupHide();
                groupUrlaub.Show();
            }
            else
            {
                lstSuperUrlaub(null);
                allgroupHide();
                groupSuperUrlaub.Show();
            }
        }


        private void btnArbeitszeit_Click(object sender, EventArgs e)
        {
            if (btnArbeitszeit.Text == "Arbeitszeit verwalten")
            {
                lstArbeit();
                timerReset(null, null);
                allgroupHide();
                groupArbeitstage.Show();
            }
            else
            {
                lstSuperArbeit();
                allgroupHide();
                groupSuperArbeit.Show();
            }
        }
        private void btnKrankheit_Click(object sender, EventArgs e)
        {
            if (btnKrankheit.Text == "Krankheitstage verwalten")
            {
                lstKrank();
                timerReset(null, null);
                allgroupHide();
                groupKrankheit.Show();
            }
            else
            {
                lstSuperKrank();
                allgroupHide();
                groupSuperKrank.Show();             
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


        private void MouseBewegt(object sender, MouseEventArgs e)
        {
            timerReset(null, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnÜbersicht_Click(null, null);
        }
        string constring = @"Data Source=DESKTOP-B8UQBUJ\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public void lstArbeit()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Datum,Anmeldename,Stunden FROM Kalendereinträge WHERE Anmeldename='"
                + Form1.passingLogin + "' AND Typ = 'Arbeit'", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sda.Fill(dt);

            dgvArbeit.DataSource = dt;
            ds.Tables.Add(dt);
            dgvArbeit.ReadOnly = true;
            for (int i = 0; i < dgvArbeit.Columns.Count - 1; i++)
            {
                dgvArbeit.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvArbeit.Columns[dgvArbeit.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvArbeit.Columns.Count; i++)
            {
                int colw = dgvArbeit.Columns[i].Width;
                dgvArbeit.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvArbeit.Columns[i].Width = colw;
            }

        }
        private void btnArb_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter();
            string sql = null;
            sql = "INSERT INTO Kalendereinträge (Datum,Anmeldename,Typ,Stunden) VALUES ('" +
                    CalendarArbeit.SelectionStart.ToShortDateString() + "','" + Form1.passingLogin + "','Arbeit','" + txtStunden.Text + "')";

            con.Open();
            sda.InsertCommand = new SqlCommand(sql, con);
            sda.InsertCommand.ExecuteNonQuery();
            lstArbeit();
            txtStunden.Text = "";
        }
        private void btnDelArbeit_Click(object sender, EventArgs e)
        {
            if (dgvArbeit.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;

                sql = "DELETE Kalendereinträge WHERE Datum='" + dgvArbeit.CurrentCell.Value.ToString() + "'";


                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstArbeit();
        }

        public void lstUrlaub()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Datum,Anmeldename,Genehmigt FROM Kalendereinträge WHERE Anmeldename='"
                + Form1.passingLogin + "' AND Typ ='Urlaub'", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sda.Fill(dt);
            dgvUrlaub.DataSource = dt;
            ds.Tables.Add(dt);
            dgvUrlaub.ReadOnly = true;
            for (int i = 0; i < dgvUrlaub.Columns.Count - 1; i++)
            {
                dgvUrlaub.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvUrlaub.Columns[dgvUrlaub.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvUrlaub.Columns.Count; i++)
            {
                int colw = dgvUrlaub.Columns[i].Width;
                dgvUrlaub.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvUrlaub.Columns[i].Width = colw;
            }
        }
        private void btnUrl_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter();
            string sql = null;
            if (CalendarUrlaub.SelectionStart.ToShortDateString() != CalendarUrlaub.SelectionEnd.ToShortDateString())
            {
                sql = "INSERT INTO Kalendereinträge (Datum,Anmeldename,Typ,Genehmigt) VALUES ('" +
                    CalendarUrlaub.SelectionStart.ToShortDateString() + " bis " + CalendarUrlaub.SelectionEnd.ToShortDateString()
                    + "','" + Form1.passingLogin + "','Urlaub','in Bearbeitung')";
            }
            else
            {
                sql = "INSERT INTO Kalendereinträge (Datum,Anmeldename,Typ,Genehmigt) VALUES ('" +
                    CalendarUrlaub.SelectionStart.ToShortDateString() + "','" + Form1.passingLogin + "','Urlaub','in Bearbeitung')";
            }
            con.Open();
            sda.InsertCommand = new SqlCommand(sql, con);
            sda.InsertCommand.ExecuteNonQuery();
            lstUrlaub();
        }
        private void btnDelUrlaub_Click(object sender, EventArgs e)
        {
            if (dgvUrlaub.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;
                sql = "DELETE Kalendereinträge WHERE Datum='" + dgvUrlaub.CurrentCell.Value.ToString() + "'";
                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstUrlaub();
        }
        public void lstKrank()
        {           
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Datum,Anmeldename FROM Kalendereinträge WHERE Anmeldename='"
                + Form1.passingLogin + "' AND Typ ='Krank'", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sda.Fill(dt);
            dgvKrank.DataSource = dt;
            ds.Tables.Add(dt);
            dgvKrank.ReadOnly = true;
            for (int i = 0; i < dgvKrank.Columns.Count - 1; i++)
            {
                dgvKrank.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvKrank.Columns[dgvKrank.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvKrank.Columns.Count; i++)
            {
                int colw = dgvKrank.Columns[i].Width;
                dgvKrank.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvKrank.Columns[i].Width = colw;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter();
            string sql = null;
            if (CalendarKrank.SelectionStart.ToShortDateString() != CalendarKrank.SelectionEnd.ToShortDateString())
            {
                sql = "INSERT INTO Kalendereinträge (Datum,Anmeldename,Typ) VALUES ('" +
                    CalendarKrank.SelectionStart.ToShortDateString() + " bis " + CalendarKrank.SelectionEnd.ToShortDateString()
                    + "','" + Form1.passingLogin + "','Krank')";
            }
            else
            {
                sql = "INSERT INTO Kalendereinträge (Datum,Anmeldename,Typ) VALUES ('" +
                    CalendarKrank.SelectionStart.ToShortDateString() + "','" + Form1.passingLogin + "','Krank')";
            }
            con.Open();
            sda.InsertCommand = new SqlCommand(sql, con);
            sda.InsertCommand.ExecuteNonQuery();
            lstKrank();
        }
        private void btnDelKrank_Click(object sender, EventArgs e)
        {
            if (dgvKrank.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;
                sql = "DELETE Kalendereinträge WHERE Datum='" + dgvKrank.CurrentCell.Value.ToString() + "'";
                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstKrank();
        }
        public void lstAll()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Anmeldename,Position FROM Benutzerdaten", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sda.Fill(dt);
            dgvÜbersicht.DataSource = dt;
            ds.Tables.Add(dt);
            dgvÜbersicht.ReadOnly = true;
            for (int i = 0; i < dgvÜbersicht.Columns.Count - 1; i++)
            {
                dgvÜbersicht.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvÜbersicht.Columns[dgvÜbersicht.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvÜbersicht.Columns.Count; i++)
            {
                int colw = dgvÜbersicht.Columns[i].Width;
                dgvÜbersicht.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvÜbersicht.Columns[i].Width = colw;
            }
        }
        public void lstSuperArbeit()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Datum, Anmeldename, Stunden FROM Kalendereinträge WHERE Typ = 'Arbeit'", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            if(sda != null)
            sda.Fill(dt);
            dgvSuperArbeit.DataSource = dt;
            ds.Tables.Add(dt);
            dgvSuperArbeit.ReadOnly = true;
            for (int i = 0; i < dgvSuperArbeit.Columns.Count - 1; i++)
            {
                dgvSuperArbeit.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvSuperArbeit.Columns[dgvSuperArbeit.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvSuperArbeit.Columns.Count; i++)
            {
                int colw = dgvSuperArbeit.Columns[i].Width;
                dgvSuperArbeit.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvSuperArbeit.Columns[i].Width = colw;
            }
        }
        private void button3_Click_1(object sender, EventArgs e) // arb löschen
        {
            if (dgvSuperArbeit.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;

                sql = "DELETE Kalendereinträge WHERE Datum='" + dgvSuperArbeit.CurrentCell.Value.ToString() + "' and Typ='Arbeit'";


                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstSuperArbeit();
        }
        private void button5_Click_1(object sender, EventArgs e) //alles Löschen Arbeit
        {
            if (dgvSuperArbeit.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;

                sql = "DELETE Kalendereinträge WHERE Typ = 'Arbeit'";


                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstSuperArbeit();
        }

        public void lstSuperKrank()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DISTINCT Datum, Anmeldename FROM Kalendereinträge WHERE Typ = 'Krank'", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            if (sda != null)
                sda.Fill(dt);
            dgvSuperKrank.DataSource = dt;
            ds.Tables.Add(dt);
            dgvSuperKrank.ReadOnly = true;
            for (int i = 0; i < dgvSuperKrank.Columns.Count - 1; i++)
            {
                dgvSuperKrank.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvSuperKrank.Columns[dgvSuperKrank.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvSuperKrank.Columns.Count; i++)
            {
                int colw = dgvSuperKrank.Columns[i].Width;
                dgvSuperKrank.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvSuperKrank.Columns[i].Width = colw;
            }
        }

        private void btnDelSuperKrank_Click(object sender, EventArgs e)
        {
            if (dgvSuperKrank.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;

                sql = "DELETE Kalendereinträge WHERE Datum='" + dgvSuperKrank.CurrentCell.Value.ToString() + "' and Typ='Krank'";


                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstSuperKrank();
        }

        private void btnDelAllSuperKrank_Click(object sender, EventArgs e)
        {
            if (dgvSuperKrank.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;

                sql = "DELETE Kalendereinträge WHERE Typ = 'Krank'";


                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstSuperKrank();
        }
        public void lstSuperUrlaub(string sdastr)
        {
            if (sdastr == null)
            {
                sdastr = "SELECT DISTINCT Datum, Anmeldename, Genehmigt FROM Kalendereinträge WHERE Typ = 'Urlaub'";
            }
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter(sdastr, con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            if (sda != null)
                sda.Fill(dt);
            dgvSuperUrl.DataSource = dt;
            ds.Tables.Add(dt);
            dgvSuperUrl.ReadOnly = true;
            for (int i = 0; i < dgvSuperUrl.Columns.Count - 1; i++)
            {
                dgvSuperUrl.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvSuperUrl.Columns[dgvSuperUrl.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvSuperUrl.Columns.Count; i++)
            {
                int colw = dgvSuperUrl.Columns[i].Width;
                dgvSuperUrl.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvSuperUrl.Columns[i].Width = colw;
            }
        }

        private void btnDelSuperUrlaub_Click(object sender, EventArgs e)
        {
            if (dgvSuperUrl.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;

                sql = "DELETE Kalendereinträge WHERE Datum='" + dgvSuperUrl.CurrentCell.Value.ToString() + "' and Typ='Urlaub'";


                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstSuperUrlaub(null);
        }

        private void btnDelAllSuperUrlaub_Click(object sender, EventArgs e)
        {
            if (dgvSuperUrl.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;

                sql = "DELETE Kalendereinträge WHERE Typ = 'Urlaub'";


                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstSuperUrlaub(null);
        }
        private void btnGeneSuperUrl_Click(object sender, EventArgs e)
        {
            if (dgvSuperUrl.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;

                sql = "UPDATE Kalendereinträge SET Genehmigt='Genehmigt' WHERE Datum='" + 
                    dgvSuperUrl.CurrentCell.Value.ToString() + "' and Typ='Urlaub'";


                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstSuperUrlaub(null);
        }

        private void btnAblehnenSuperUrl_Click(object sender, EventArgs e)
        {
            if (dgvSuperUrl.RowCount != 0)
            {
                SqlConnection con = new SqlConnection(constring);
                SqlDataAdapter sda = new SqlDataAdapter();
                string sql = null;

                sql = "UPDATE Kalendereinträge SET Genehmigt='Abgelehnt' WHERE Datum='" 
                    + dgvSuperUrl.CurrentCell.Value.ToString() + "' and Typ='Urlaub'";


                con.Open();
                sda.InsertCommand = new SqlCommand(sql, con);
                sda.InsertCommand.ExecuteNonQuery();
            }
            lstSuperUrlaub(null);
        }

        private void button1_Click(object sender, EventArgs e) // Supervisorbuttonclick
        {
            btnArbeitszeit.Text = "Alle Arbeitszeiten verwalten";
            btnUrlaub.Text = "Alle Urlaubstage verwalten";
            btnKrankheit.Text = "Alle Krankheitstage verwalten";

            allgroupHide();
            btnÜbersicht_Click(null, null);
            btnSupervisorEnd.Show();
            btnSupertools.Hide();

        }

        private void button3_Click(object sender, EventArgs e) //Supervisor Beenden
        {
            allgroupHide();
            btnSupertools.Show();
            btnSupervisorEnd.Hide();
            btnArbeitszeit.Text = "Arbeitszeit verwalten";
            btnUrlaub.Text = "Urlaubstage verwalten";
            btnKrankheit.Text = "Krankheitstage verwalten";
            btnÜbersicht_Click(null, null); //Übersicht öffnen
        }

        private void button1_Click_1(object sender, EventArgs e) //Neuigkeiten ändern
        {
            //txtAusgabeNeuig.Text = txtEingabeNeuig.Text;
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("UPDATE Benutzerdaten SET Passwort='"  + txtEingabeNeuig.Text + "' WHERE Anmeldename='Neuigkeiten'", con);
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Passwort FROM Benutzerdaten WHERE Anmeldename='Neuigkeiten'", con);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            sda2.Fill(dt1);
            txtAusgabeNeuig.Text = dt1.Rows[0][0].ToString();
            //txtEingabeNeuig.Text = "";
        }
        public void lstAllOne()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Datum,Anmeldename,Typ FROM Kalendereinträge WHERE Anmeldename='" + Form1.passingLogin + "'", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sda.Fill(dt);
            dgvÜbersicht1.DataSource = dt;
            ds.Tables.Add(dt);
            dgvÜbersicht1.ReadOnly = true;
            for (int i = 0; i < dgvÜbersicht1.Columns.Count - 1; i++)
            {
                dgvÜbersicht1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvÜbersicht1.Columns[dgvÜbersicht1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvÜbersicht1.Columns.Count; i++)
            {
                int colw = dgvÜbersicht1.Columns[i].Width;
                dgvÜbersicht1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvÜbersicht1.Columns[i].Width = colw;
            }
        }
    }
}
