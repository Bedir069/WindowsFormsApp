
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startseite));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblAbm = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
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
            this.button4 = new System.Windows.Forms.Button();
            this.lblAngemeldetals = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
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
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lblAngemeldetals);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.lblAbm);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 546);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel8.Location = new System.Drawing.Point(254, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(666, 511);
            this.panel8.TabIndex = 7;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // lblAbm
            // 
            this.lblAbm.AutoSize = true;
            this.lblAbm.Font = new System.Drawing.Font("Marlboro", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAbm.Location = new System.Drawing.Point(926, 36);
            this.lblAbm.Name = "lblAbm";
            this.lblAbm.Size = new System.Drawing.Size(128, 38);
            this.lblAbm.TabIndex = 6;
            this.lblAbm.TabStop = true;
            this.lblAbm.Text = "Abmelden";
            this.lblAbm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAbm_LinkClicked);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(926, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel7.Controls.Add(this.monthCalendar1);
            this.panel7.Location = new System.Drawing.Point(926, 106);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 201);
            this.panel7.TabIndex = 4;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(23, 20);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
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
            this.btnÜbersicht.BackColor = System.Drawing.Color.Transparent;
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
            this.btnKrankheit.BackColor = System.Drawing.Color.Transparent;
            this.btnKrankheit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKrankheit.Font = new System.Drawing.Font("Marlboro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKrankheit.Location = new System.Drawing.Point(0, 0);
            this.btnKrankheit.Name = "btnKrankheit";
            this.btnKrankheit.Size = new System.Drawing.Size(215, 66);
            this.btnKrankheit.TabIndex = 1;
            this.btnKrankheit.Text = "Krankheitstage verwalten";
            this.btnKrankheit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKrankheit.UseVisualStyleBackColor = false;
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
            this.btnUrlaub.BackColor = System.Drawing.Color.Transparent;
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
            this.btnArbeitszeit.BackColor = System.Drawing.Color.Transparent;
            this.btnArbeitszeit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArbeitszeit.Font = new System.Drawing.Font("Marlboro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArbeitszeit.Location = new System.Drawing.Point(0, 0);
            this.btnArbeitszeit.Name = "btnArbeitszeit";
            this.btnArbeitszeit.Size = new System.Drawing.Size(215, 66);
            this.btnArbeitszeit.TabIndex = 1;
            this.btnArbeitszeit.Text = "Arbeitszeit verwalten";
            this.btnArbeitszeit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArbeitszeit.UseVisualStyleBackColor = true;
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
            this.pictureBox1.Location = new System.Drawing.Point(16, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 201);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            // lblAngemeldetals
            // 
            this.lblAngemeldetals.AutoSize = true;
            this.lblAngemeldetals.Font = new System.Drawing.Font("Marlboro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAngemeldetals.Location = new System.Drawing.Point(935, 14);
            this.lblAngemeldetals.Name = "lblAngemeldetals";
            this.lblAngemeldetals.Size = new System.Drawing.Size(53, 22);
            this.lblAngemeldetals.TabIndex = 8;
            this.lblAngemeldetals.Text = "label1";
            this.lblAngemeldetals.Click += new System.EventHandler(this.lblAngemeldetals_Click);
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
    }
}