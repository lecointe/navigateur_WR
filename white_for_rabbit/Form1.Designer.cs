namespace white_for_rabbit
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.recherche = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonTraducteur = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.ButtonBack = new MetroFramework.Controls.MetroButton();
            this.ButtonNext = new MetroFramework.Controls.MetroButton();
            this.ButtonActu = new MetroFramework.Controls.MetroButton();
            this.ButtonStop = new MetroFramework.Controls.MetroButton();
            this.ButtonHome = new MetroFramework.Controls.MetroButton();
            this.url = new System.Windows.Forms.ComboBox();
            this.supOnglet = new System.Windows.Forms.Button();
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(1111, 524);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Click += new System.EventHandler(this.metroTabControl1_Click);
            this.metroTabControl1.DoubleClick += new System.EventHandler(this.metroTabControl1_DoubleClick);
            // 
            // recherche
            // 
            this.recherche.Lines = new string[0];
            this.recherche.Location = new System.Drawing.Point(17, 3);
            this.recherche.MaxLength = 32767;
            this.recherche.Name = "recherche";
            this.recherche.PasswordChar = '\0';
            this.recherche.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.recherche.SelectedText = "";
            this.recherche.Size = new System.Drawing.Size(158, 23);
            this.recherche.TabIndex = 3;
            this.recherche.UseSelectable = true;
            this.recherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recherche_KeyPress);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Lime;
            this.metroPanel1.Controls.Add(this.button4);
            this.metroPanel1.Controls.Add(this.button3);
            this.metroPanel1.Controls.Add(this.button2);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.ButtonTraducteur);
            this.metroPanel1.Controls.Add(this.recherche);
            this.metroPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(953, 5);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 600);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.MouseLeave += new System.EventHandler(this.metroPanel1_MouseLeave);
            this.metroPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroPanel1_MouseMove);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(88, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonTraducteur
            // 
            this.ButtonTraducteur.ActiveControl = null;
            this.ButtonTraducteur.Location = new System.Drawing.Point(41, 35);
            this.ButtonTraducteur.Name = "ButtonTraducteur";
            this.ButtonTraducteur.Size = new System.Drawing.Size(75, 23);
            this.ButtonTraducteur.TabIndex = 4;
            this.ButtonTraducteur.Text = "traduire";
            this.ButtonTraducteur.UseSelectable = true;
            this.ButtonTraducteur.Click += new System.EventHandler(this.ButtonTraducteur_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(1143, 40);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(10, 544);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroTile1_MouseMove);
            // 
            // ButtonBack
            // 
            this.ButtonBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ButtonBack.Location = new System.Drawing.Point(0, 40);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.Text = "back";
            this.ButtonBack.UseSelectable = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(81, 40);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 23);
            this.ButtonNext.TabIndex = 5;
            this.ButtonNext.Text = "next";
            this.ButtonNext.UseSelectable = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonActu
            // 
            this.ButtonActu.Location = new System.Drawing.Point(162, 40);
            this.ButtonActu.Name = "ButtonActu";
            this.ButtonActu.Size = new System.Drawing.Size(80, 23);
            this.ButtonActu.TabIndex = 6;
            this.ButtonActu.Text = "Actu";
            this.ButtonActu.UseSelectable = true;
            this.ButtonActu.Click += new System.EventHandler(this.ButtonActu_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(248, 40);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 7;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseSelectable = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.Color.White;
            this.ButtonHome.Location = new System.Drawing.Point(329, 40);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(75, 23);
            this.ButtonHome.TabIndex = 8;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseSelectable = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // url
            // 
            this.url.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url.DropDownHeight = 50;
            this.url.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.url.FormattingEnabled = true;
            this.url.IntegralHeight = false;
            this.url.ItemHeight = 16;
            this.url.Location = new System.Drawing.Point(0, 10);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(564, 24);
            this.url.TabIndex = 9;
            this.url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.url_KeyPress);
            // 
            // supOnglet
            // 
            this.supOnglet.Location = new System.Drawing.Point(668, 40);
            this.supOnglet.Name = "supOnglet";
            this.supOnglet.Size = new System.Drawing.Size(75, 23);
            this.supOnglet.TabIndex = 10;
            this.supOnglet.Text = "- tab";
            this.supOnglet.UseVisualStyleBackColor = true;
            this.supOnglet.Click += new System.EventHandler(this.supOnglet_Click);
            // 
            // metroProgressBar
            // 
            this.metroProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroProgressBar.Location = new System.Drawing.Point(0, 590);
            this.metroProgressBar.Name = "metroProgressBar";
            this.metroProgressBar.Size = new System.Drawing.Size(141, 15);
            this.metroProgressBar.TabIndex = 11;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(568, 40);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 604);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroProgressBar);
            this.Controls.Add(this.supOnglet);
            this.Controls.Add(this.url);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonActu);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTextBox recherche;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile ButtonTraducteur;
        private MetroFramework.Controls.MetroButton ButtonBack;
        private MetroFramework.Controls.MetroButton ButtonNext;
        private MetroFramework.Controls.MetroButton ButtonActu;
        private MetroFramework.Controls.MetroButton ButtonStop;
        private MetroFramework.Controls.MetroButton ButtonHome;
        private System.Windows.Forms.ComboBox url;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button supOnglet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

