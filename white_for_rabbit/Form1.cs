using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace white_for_rabbit
{



    public partial class Form1 : MetroForm
    {
                //Awesomium.Windows.Forms.WebControl Brow;
        MyBrow Brow;
        string Home = "http://devlog.amorce.org/#";
        string moteur = "https://www.google.fr/#q=";
        int type = 2;
        int i=0;
           

 #region fonction

       void uurl(int type)
        {
            if (type == 1)
            {

              /* 
                if (url.Text.StartsWith("http://") || url.Text.StartsWith("https://") || url.Text.EndsWith(".com") || url.Text.EndsWith(".fr") == true)
                {
                    if (url.Text.StartsWith("http://") || url.Text.StartsWith("https://") == true)
                    {
                        Browser.Source = new Uri(url.Text);
                        // si le texte tapé comence par http:// ou https:// on va a l'adresse tapée

                    }

                    if (url.Text.EndsWith(".com") == true)
                    {
                        Browser.Source = new Uri("https://" + url.Text);
                        // si le texte tapé fini par .com on va a l'adresse tapée

                    }

                    if (url.Text.EndsWith(".fr") == true)
                    {
                        Browser.Source = new Uri("http://" + url.Text);
                        // si le texte tapé fini par .fr on va a l'adresse tapée

                    }

                }
                else
                {
                    Browser.Source = new Uri(moteur + url.Text);

                    //Sinon on le recherche
                }
                */
            }
            if (type == 2)
            {
                if (url.Text.StartsWith("http://") || url.Text.StartsWith("https://") || url.Text.EndsWith(".com") || url.Text.EndsWith(".fr") == true)
                {
                    if (url.Text.StartsWith("http://") || url.Text.StartsWith("https://") == true)
                    {
                        ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Navigate(new Uri(url.Text));
                        // si le texte tapé comence par http:// ou https:// on va a l'adresse saisie
                    }
                    if (url.Text.EndsWith(".com") == true)
                    {
                        ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Navigate(new Uri("https://" + url.Text));
                        // si le texte tapé fini par .com on va a l'adresse saisie
                    }
                    if (url.Text.EndsWith(".fr") == true)
                    {
                        ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Navigate(new Uri("http://" + url.Text));
                        // si le texte tapé fini par .fr on va a l'adresse saisie
                    }
                }
                else
                {
                    ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Navigate(new Uri(moteur + url.Text));
                    //Sinon on le recherche
                }
            }
        }
        void back(int type)
        {
            if (type == 1)
            {
                /*
                if (Browser.CanGoBack() == true) // Si l'on peut revenir en arrière ...
                {
                    Browser.GoBack(); // ... on revient en arrière.
                }
                else
                {
                    MessageBox.Show("Impossible de revenir en arrière"); // Sinon on affiche un message d'erreur.
                }*/
            }
            if (type == 2)
            {
                
                    ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).GoBack(); // ... on revient en arrière.
             
                
            }
        }
        void nnext(int type)
        {
            if (type == 1)
            {
                /*
                if (Browser.CanGoForward() == true) // Si on peut revenir en avant ...
                {
                    Browser.GoForward(); // ... on revient en avant.
                }
                else
                {
                    MessageBox.Show("Impossible de revenir en avant"); // Sinon on affiche un message d'erreur.
                }*/
            }
            if (type == 2)
            {
                ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).GoForward();
            }
        }
        void aactu(int type)
        {
            if (type == 1)
            {
               // Browser.Reload(true);
            }
            if (type == 2)
            {
                ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Refresh();
            }
        }
        void sstop(int type)
        {
            if (type == 1)
            {
             //   Browser.Stop();
            }
            if (type == 2)
            {
                Brow.Stop();
            }
        }
        void hhome(int type)
        {

            if (type == 1)
            {
               // Browser.Source = new Uri(Home);
            }
            if (type == 2)
            {
                ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Navigate(Home);
            }
        }
        void rrecherche(int type)
        {
            if (type == 1)
            {

                //Browser.Source = new Uri(moteur + recherche.Text);

            }
            if (type == 2)
            {
                ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Navigate(new Uri(moteur + recherche.Text));
            }
        }
       private void addNewTab()
        {
           
        //Creation d'un nouvel objet TabPage
            TabPage tpage = new TabPage();

        //Ajoute l'onglet nouvellement créer à la collection de controle d'onglet
            metroTabControl1.TabPages.Insert(metroTabControl1.TabCount - 1, tpage);

        //Creation d'un objet navigateur
           Brow = new MyBrow(metroTabControl1,url,tpage);
          
        //Ajoute le navigateur a l'onglet précedement créer
            tpage.Controls.Add(Brow);
            Brow.Dock = DockStyle.Fill;
            Brow.ScriptErrorsSuppressed = true;
            metroTabControl1.SelectTab(tpage);

            Brow.Navigate(moteur);    
          
        //Suivre l'onglet new tab 
            i++;
  
        }




        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialisation du menu droit
            metroPanel1.Width = 100;
            metroPanel1.Dock = DockStyle.Right;
            metroPanel1.Visible = false;
            metroPanel1.BackColor = Color.Black;
           
            //Gestion des onglets, ancrage au 4 coins, onglet vide nommé "New Tab", incremente nombre onglet avec i
            metroTabControl1.TabPages.Add("New Tab");
            metroTabControl1.SelectTab(i);
            metroTabControl1.SelectedTab.Controls.Add(Brow);
            metroTabControl1.Dock = DockStyle.Fill;
     
            addNewTab();
  
             
            //Les boutons precedent, suivant et stop sont grisé au demarage
            // buttonBack.Enabled = false;
            // buttonForward.Enabled = false;
            // buttonStop.Enabled = false;
            
        }     


#region menu droit
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.metroPanel1.Size.Width >= 209) this.timer1.Enabled = false;
            else this.metroPanel1.Width += 15;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.metroPanel1.Size.Width <= 10) this.timer2.Enabled = false;
            else this.metroPanel1.Width -= 15;
            if (metroPanel1.Width <= 10) metroPanel1.Visible = false;
        }
        private void metroPanel1_MouseLeave(object sender, EventArgs e)
        {
 
        }
        private void metroTile1_MouseMove(object sender, MouseEventArgs e)
        {
            //le menu arrive 
            metroPanel1.Visible = true;
            this.timer2.Enabled = false;
            this.timer1.Enabled = true;
        }
        private void metroPanel1_MouseHover(object sender, EventArgs e)
        {

        }
        private void metroPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X <=5)//le menu part [e.X est la pos du curseur par rapport au menu]
            {
                this.timer2.Enabled = true;
                this.timer1.Enabled = false;
            }
            if (e.X > 10)// le menu revient
            {
                this.timer2.Enabled = false;
                this.timer1.Enabled = true;
            }
            
        }
        private void metroTile1_MouseEnter(object sender, EventArgs e)
        {

        }
        #endregion


#region boutton
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            sstop(type);
        }
        private void metroTabControl1_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == i)
            {
                addNewTab();
            }
        }
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            hhome(type);
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Brow.back();
        }
        private void url_KeyPress(object sender, KeyPressEventArgs e)
        {
               if (e.KeyChar == (char)13)
            {
                Brow.url();
            }
            
        }
        private void ButtonActu_Click(object sender, EventArgs e)
        {
            aactu(type); 
            
        }
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            nnext(type); 
        }
        private void recherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                rrecherche(type);
            }
           
        }
        private void ButtonTraducteur_Click(object sender, EventArgs e)
        {
            // ne fonctionne pas pour webbrowser mais pour awesonium
            // Brow.ExecuteJavascript("(function(){var s = document.createElement('script'); s.type = 'text/javascript'; s.src = 'http://labs.microsofttranslator.com/bookmarklet/default.aspx?f=js&to=fr'; document.body.insertBefore(s, document.body.firstChild);})()");
        }
#endregion
    }

#region MyBrow
    class MyBrow : WebBrowser
    {
        public string moteur = "https://www.google.fr/#q=";
        private string _nom;
        private TabPage _tpage;
        private MetroFramework.Controls.MetroTabControl _metroTabControl;
        private System.Windows.Forms.ComboBox _combo;
        public MyBrow(MetroFramework.Controls.MetroTabControl metroTabControl, System.Windows.Forms.ComboBox combo, TabPage tpage)
        {
            _metroTabControl=metroTabControl;
            _combo=combo;
            _tpage = tpage;
         //lier la fontion Brow_DocumentCompleted a l'objet 
            this.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Brow_DocumentCompleted);
         //   this.DocumentCompleted += new WebBrowserDocumentCompletedEventHandle(r);
          
        }
        private void Brow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string result;
            int L;
     
            this._nom = this.DocumentTitle;
            L = _nom.Length;
            result = "";
            if (L > 30)                                              //si nom > a la longueur -> mettre la longueur voulu dans L + ... 
            {
                L = 30;
                result = "...";
            }
            result = _nom.Substring(0, L) + result;                 // couper la chaine apres la longueur L                      
            _tpage.Text=result;
           // si l'onglet de l'objet est l'onglet actuel afficher l'url 
              if (_metroTabControl.SelectedTab ==  _tpage)_combo.Text =this.Url.ToString();
              
            }
        public void url()
        {
                if ( _combo.Text.StartsWith("http://") ||  _combo.Text.StartsWith("https://") ||  _combo.Text.EndsWith(".com") ||  _combo.Text.EndsWith(".fr") == true)
                {
                    if ( _combo.Text.StartsWith("http://") || _combo.Text.StartsWith("https://") == true)
                    {
                        this.Navigate(new Uri( _combo.Text));
                        // si le texte tapé comence par http:// ou https:// on va a l'adresse saisie
                    }
                    if ( _combo.Text.EndsWith(".com") == true)
                    {
                        this.Navigate(new Uri("https://" + _combo.Text));
                        // si le texte tapé fini par .com on va a l'adresse saisie
                    }
                    if ( _combo.Text.EndsWith(".fr") == true)
                    {
                        this.Navigate(new Uri("http://" +  _combo.Text));
                        // si le texte tapé fini par .fr on va a l'adresse saisie
                    }
                }
                else
                {
                    this.Navigate(new Uri(moteur +  _combo.Text));
                    //Sinon on le recherche
                }
        }
        public void back()
        {
                this.GoBack(); // ... on revient en arrière.
        }

     }

    #endregion

}