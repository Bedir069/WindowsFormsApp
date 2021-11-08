
namespace WindowsFormsApp
{
    partial class Startseite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startseite));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAngemeldetals = new System.Windows.Forms.Label();
            this.lblAbm = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnÜbersicht = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnKrankheit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnUrlaub = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnArbeitszeit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupArbeitstage = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitelArbeitszeit = new System.Windows.Forms.Label();
            this.btnArbeitstage = new System.Windows.Forms.Button();
            this.lblAnzahlStunden = new System.Windows.Forms.Label();
            this.lblJahr = new System.Windows.Forms.Label();
            this.lblMonat = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtStunden = new System.Windows.Forms.TextBox();
            this.txtJahr = new System.Windows.Forms.TextBox();
            this.txtMonat = new System.Windows.Forms.TextBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.groupArbeitstage.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(33, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(240, 16);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.lblSecond);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblAngemeldetals);
            this.panel1.Controls.Add(this.lblAbm);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 546);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel7.Controls.Add(this.monthCalendar1);
            this.panel7.Location = new System.Drawing.Point(928, 230);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 201);
            this.panel7.TabIndex = 4;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.LavenderBlush;
            this.monthCalendar1.Location = new System.Drawing.Point(23, 20);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblSecond.Font = new System.Drawing.Font("Marlboro", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSecond.Location = new System.Drawing.Point(1079, 158);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(65, 29);
            this.lblSecond.TabIndex = 9;
            this.lblSecond.Text = "lblSec";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblTime.Font = new System.Drawing.Font("Marlboro", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(928, 99);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(185, 69);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "lblTime";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblAngemeldetals
            // 
            this.lblAngemeldetals.AutoSize = true;
            this.lblAngemeldetals.Font = new System.Drawing.Font("Marlboro", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAngemeldetals.Location = new System.Drawing.Point(926, 15);
            this.lblAngemeldetals.Name = "lblAngemeldetals";
            this.lblAngemeldetals.Size = new System.Drawing.Size(55, 23);
            this.lblAngemeldetals.TabIndex = 8;
            this.lblAngemeldetals.Text = "label1";
            this.lblAngemeldetals.Click += new System.EventHandler(this.lblAngemeldetals_Click);
            // 
            // lblAbm
            // 
            this.lblAbm.AutoSize = true;
            this.lblAbm.Font = new System.Drawing.Font("Marlboro", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAbm.Location = new System.Drawing.Point(925, 48);
            this.lblAbm.Name = "lblAbm";
            this.lblAbm.Size = new System.Drawing.Size(128, 38);
            this.lblAbm.TabIndex = 6;
            this.lblAbm.TabStop = true;
            this.lblAbm.Text = "Abmelden";
            this.lblAbm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAbm_LinkClicked);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.dateTimePicker1.Location = new System.Drawing.Point(928, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Controls.Add(this.btnÜbersicht);
            this.panel6.Location = new System.Drawing.Point(33, 241);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 66);
            this.panel6.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // btnÜbersicht
            // 
            this.btnÜbersicht.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnÜbersicht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnÜbersicht.Font = new System.Drawing.Font("Marlboro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnÜbersicht.Location = new System.Drawing.Point(0, 0);
            this.btnÜbersicht.Name = "btnÜbersicht";
            this.btnÜbersicht.Size = new System.Drawing.Size(215, 66);
            this.btnÜbersicht.TabIndex = 1;
            this.btnÜbersicht.Text = "Übersicht";
            this.btnÜbersicht.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnÜbersicht.UseVisualStyleBackColor = false;
            this.btnÜbersicht.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.btnKrankheit);
            this.panel4.Location = new System.Drawing.Point(33, 457);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 66);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // btnKrankheit
            // 
            this.btnKrankheit.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnKrankheit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKrankheit.Font = new System.Drawing.Font("Marlboro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKrankheit.Location = new System.Drawing.Point(0, 0);
            this.btnKrankheit.Name = "btnKrankheit";
            this.btnKrankheit.Size = new System.Drawing.Size(215, 66);
            this.btnKrankheit.TabIndex = 1;
            this.btnKrankheit.Text = "Krankheitstage verwalten";
            this.btnKrankheit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKrankheit.UseVisualStyleBackColor = false;
            this.btnKrankheit.Click += new System.EventHandler(this.btnKrankheit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnUrlaub);
            this.panel2.Location = new System.Drawing.Point(33, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 66);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnUrlaub
            // 
            this.btnUrlaub.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUrlaub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUrlaub.Font = new System.Drawing.Font("Marlboro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrlaub.Location = new System.Drawing.Point(0, 0);
            this.btnUrlaub.Name = "btnUrlaub";
            this.btnUrlaub.Size = new System.Drawing.Size(215, 66);
            this.btnUrlaub.TabIndex = 1;
            this.btnUrlaub.Text = "Urlaubstage verwalten";
            this.btnUrlaub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrlaub.UseVisualStyleBackColor = false;
            this.btnUrlaub.Click += new System.EventHandler(this.btnUrlaub_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.btnArbeitszeit);
            this.panel5.Location = new System.Drawing.Point(33, 313);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 66);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnArbeitszeit
            // 
            this.btnArbeitszeit.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnArbeitszeit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArbeitszeit.Font = new System.Drawing.Font("Marlboro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArbeitszeit.Location = new System.Drawing.Point(0, 0);
            this.btnArbeitszeit.Name = "btnArbeitszeit";
            this.btnArbeitszeit.Size = new System.Drawing.Size(215, 66);
            this.btnArbeitszeit.TabIndex = 1;
            this.btnArbeitszeit.Text = "Arbeitszeit verwalten";
            this.btnArbeitszeit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArbeitszeit.UseVisualStyleBackColor = false;
            this.btnArbeitszeit.Click += new System.EventHandler(this.btnArbeitszeit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(33, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 223);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel8.Controls.Add(this.groupArbeitstage);
            this.panel8.Location = new System.Drawing.Point(254, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(666, 511);
            this.panel8.TabIndex = 7;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // groupArbeitstage
            // 
            this.groupArbeitstage.Controls.Add(this.groupBox1);
            this.groupArbeitstage.Controls.Add(this.lblTitelArbeitszeit);
            this.groupArbeitstage.Controls.Add(this.btnArbeitstage);
            this.groupArbeitstage.Controls.Add(this.lblAnzahlStunden);
            this.groupArbeitstage.Controls.Add(this.lblJahr);
            this.groupArbeitstage.Controls.Add(this.lblMonat);
            this.groupArbeitstage.Controls.Add(this.lblTag);
            this.groupArbeitstage.Controls.Add(this.txtStunden);
            this.groupArbeitstage.Controls.Add(this.txtJahr);
            this.groupArbeitstage.Controls.Add(this.txtMonat);
            this.groupArbeitstage.Controls.Add(this.txtTag);
            this.groupArbeitstage.Location = new System.Drawing.Point(12, 10);
            this.groupArbeitstage.Name = "groupArbeitstage";
            this.groupArbeitstage.Size = new System.Drawing.Size(639, 488);
            this.groupArbeitstage.TabIndex = 0;
            this.groupArbeitstage.TabStop = false;
            this.groupArbeitstage.Visible = false;
            this.groupArbeitstage.Enter += new System.EventHandler(this.groupArbeitstage_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 474);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTitelArbeitszeit
            // 
            this.lblTitelArbeitszeit.AutoSize = true;
            this.lblTitelArbeitszeit.Font = new System.Drawing.Font("Marlboro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitelArbeitszeit.Location = new System.Drawing.Point(17, 26);
            this.lblTitelArbeitszeit.Name = "lblTitelArbeitszeit";
            this.lblTitelArbeitszeit.Size = new System.Drawing.Size(375, 52);
            this.lblTitelArbeitszeit.TabIndex = 9;
            this.lblTitelArbeitszeit.Text = "Arbeitstage verwalten";
            this.lblTitelArbeitszeit.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnArbeitstage
            // 
            this.btnArbeitstage.Font = new System.Drawing.Font("Marlboro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArbeitstage.Location = new System.Drawing.Point(180, 269);
            this.btnArbeitstage.Name = "btnArbeitstage";
            this.btnArbeitstage.Size = new System.Drawing.Size(181, 88);
            this.btnArbeitstage.TabIndex = 8;
            this.btnArbeitstage.Text = "Eingabe";
            this.btnArbeitstage.UseVisualStyleBackColor = true;
            this.btnArbeitstage.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAnzahlStunden
            // 
            this.lblAnzahlStunden.AutoSize = true;
            this.lblAnzahlStunden.Font = new System.Drawing.Font("Marlboro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnzahlStunden.Location = new System.Drawing.Point(323, 184);
            this.lblAnzahlStunden.Name = "lblAnzahlStunden";
            this.lblAnzahlStunden.Size = new System.Drawing.Size(90, 17);
            this.lblAnzahlStunden.TabIndex = 7;
            this.lblAnzahlStunden.Text = "Anzahl Stunden";
            // 
            // lblJahr
            // 
            this.lblJahr.AutoSize = true;
            this.lblJahr.Font = new System.Drawing.Font("Marlboro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJahr.Location = new System.Drawing.Point(250, 186);
            this.lblJahr.Name = "lblJahr";
            this.lblJahr.Size = new System.Drawing.Size(30, 17);
            this.lblJahr.TabIndex = 6;
            this.lblJahr.Text = "Jahr";
            // 
            // lblMonat
            // 
            this.lblMonat.AutoSize = true;
            this.lblMonat.Font = new System.Drawing.Font("Marlboro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonat.Location = new System.Drawing.Point(197, 186);
            this.lblMonat.Name = "lblMonat";
            this.lblMonat.Size = new System.Drawing.Size(39, 17);
            this.lblMonat.TabIndex = 5;
            this.lblMonat.Text = "Monat";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Marlboro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTag.Location = new System.Drawing.Point(142, 186);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(26, 17);
            this.lblTag.TabIndex = 4;
            this.lblTag.Text = "Tag";
            // 
            // txtStunden
            // 
            this.txtStunden.Location = new System.Drawing.Point(323, 219);
            this.txtStunden.Name = "txtStunden";
            this.txtStunden.Size = new System.Drawing.Size(56, 23);
            this.txtStunden.TabIndex = 3;
            // 
            // txtJahr
            // 
            this.txtJahr.Location = new System.Drawing.Point(250, 219);
            this.txtJahr.Name = "txtJahr";
            this.txtJahr.Size = new System.Drawing.Size(37, 23);
            this.txtJahr.TabIndex = 2;
            // 
            // txtMonat
            // 
            this.txtMonat.Location = new System.Drawing.Point(197, 219);
            this.txtMonat.Name = "txtMonat";
            this.txtMonat.Size = new System.Drawing.Size(37, 23);
            this.txtMonat.TabIndex = 1;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(142, 219);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(37, 23);
            this.txtTag.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1156, 546);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1156, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Startseite";
            this.Text = "Startseite";
            this.Load += new System.EventHandler(this.Startseite_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.groupArbeitstage.ResumeLayout(false);
            this.groupArbeitstage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnÜbersicht;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUrlaub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnArbeitszeit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnKrankheit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.LinkLabel lblAbm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label lblAngemeldetals;
        private System.Windows.Forms.GroupBox groupArbeitstage;
        private System.Windows.Forms.Label lblTitelArbeitszeit;
        private System.Windows.Forms.Button btnArbeitstage;
        private System.Windows.Forms.Label lblAnzahlStunden;
        private System.Windows.Forms.Label lblJahr;
        private System.Windows.Forms.Label lblMonat;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtStunden;
        private System.Windows.Forms.TextBox txtJahr;
        private System.Windows.Forms.TextBox txtMonat;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}