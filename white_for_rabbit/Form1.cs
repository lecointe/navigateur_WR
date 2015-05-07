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
using System.Resources;

namespace white_for_rabbit
{

    //***********************************************************probleme visibilité boutton next suivant 

    public partial class Form1 : MetroForm
    {
                //Awesomium.Windows.Forms.WebControl Brow;
        MyTab Tab;
        int i = 0;
        List<MyTab> _list = new List<MyTab>();


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

            Tab = new MyTab(this,ref _list);
            _list.Add(Tab);
            Tab.LoadTab(ref i);
         //   i = Tab.compter();
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
            if (e.Y <= 150)
            {
                //le menu arrive 
                metroPanel1.Visible = true;
                this.timer2.Enabled = false;
                this.timer1.Enabled = true;
            }
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
        #endregion

#region boutton
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            Tab.Browser().stop();
        }
        private void metroTabControl1_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == i)
            {
               Tab = new MyTab(this, ref _list);
                _list.Add(Tab);
                Tab.addNewTab(ref i);

                /*   string a = i.ToString();
                MessageBox.Show(a);*/
            }
            else
            {
                Tab.Browser().Actualiser();
            }
            
        }
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            Tab.Browser().home();
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Tab.Browser().back();
        }
        private void url_KeyPress(object sender, KeyPressEventArgs e)
        {
               if (e.KeyChar == (char)13)
            {
                Tab.Browser().url();
            }
            
        }
        private void ButtonActu_Click(object sender, EventArgs e)
        {
            Tab.Browser().actu(); 
            
        }
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            Tab.Browser().next(); 
        }
        private void recherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Tab.Browser().recherche();
            }
        }
        private void ButtonTraducteur_Click(object sender, EventArgs e)
        {
            // ne fonctionne pas pour webbrowser mais pour awesonium
            // Brow.ExecuteJavascript("(function(){var s = document.createElement('script'); s.type = 'text/javascript'; s.src = 'http://labs.microsofttranslator.com/bookmarklet/default.aspx?f=js&to=fr'; document.body.insertBefore(s, document.body.firstChild);})()");
        }
#endregion

#region test
        private void button1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Navigate(new Uri("http://www.facebook.com"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Navigate(new Uri("http://www.youtube.fr"));
        }

        private void supOnglet_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.TabCount > 2)
            {   
                _list.RemoveAt(metroTabControl1.SelectedIndex);
                Tab.deletTab(ref i);   
            }
            else Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Navigate(new Uri("http://www.commentcamarche.net/"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).Navigate(new Uri("http://openclassrooms.com/"));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Tab = new MyTab(this, ref _list);
            _list.Add(Tab);

            Tab.addNewTab(ref i);
        }

        private void metroTabControl1_DoubleClick(object sender, EventArgs e)
        {
            if (metroTabControl1.TabCount > 2)
            {
                _list.RemoveAt(metroTabControl1.SelectedIndex);
                Tab.deletTab(ref i);
            }
            else Application.Exit();
        }
    }
        #endregion

#region fonction
    /*
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
               
                if (Browser.CanGoBack() == true) // Si l'on peut revenir en arrière ...
                {
                    Browser.GoBack(); // ... on revient en arrière.
                }
                else
                {
                    MessageBox.Show("Impossible de revenir en arrière"); // Sinon on affiche un message d'erreur.
                
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
               
                if (Browser.CanGoForward() == true) // Si on peut revenir en avant ...
                {
                    Browser.GoForward(); // ... on revient en avant.
                }
                else
                {
                    MessageBox.Show("Impossible de revenir en avant"); // Sinon on affiche un message d'erreur.
                }
            }
            if (type == 2)
            {
                ((WebBrowser)metroTabControl1.SelectedTab.Controls[0]).GoForward();
            }
        }
        void actu(int type)
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
        void stop(int type)
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
        void home(int type)
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
        void recherhe(int type)
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
            recherche.Text = "";

        //Creation d'un objet navigateur
           Brow = new MyBrow(metroTabControl1, url, tpage, recherche);
          
        //Ajoute le navigateur a l'onglet précedement créer
            tpage.Controls.Add(Brow);
            Brow.Dock = DockStyle.Fill;
            Brow.ScriptErrorsSuppressed = true;
            metroTabControl1.SelectTab(tpage);

            Brow.Navigate(moteur);    
          
        //Suivre l'onglet new tab 
            i++;
  
        }


*/
    #endregion
     
   
#region MyBrow
   /*  class MyBrow : WebBrowser
    {
        public string moteur = "https://www.google.fr/#q=";
        private string _nom;
        private TabPage _tpage;
        private MetroFramework.Controls.MetroTabControl _metroTabControl;
        private System.Windows.Forms.ComboBox _combo;
        private MetroFramework.Controls.MetroTextBox _recherche;
        private MetroFramework.Controls.MetroButton _Forward;
        private MetroFramework.Controls.MetroButton _Back;
        private List<MyTab> _list = new List<MyTab>();
        private MetroFramework.Controls.MetroProgressBar _BarreProgression;

        public MyBrow(MetroFramework.Controls.MetroTabControl metroTabControl, System.Windows.Forms.ComboBox combo, TabPage tpage, MetroFramework.Controls.MetroTextBox recherche, 
                        MetroFramework.Controls.MetroButton Back, MetroFramework.Controls.MetroButton Forward,MetroFramework.Controls.MetroProgressBar metroProgressBar, 
                             ref List<MyTab> list)
        {
            _BarreProgression = metroProgressBar;
            _recherche = recherche;
            _metroTabControl=metroTabControl;
            _combo=combo;
            _tpage = tpage;
            _Forward = Forward;
            _Back = Back;
         //lier la fontion Brow_DocumentCompleted à l'objet 
            this.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Brow_DocumentCompleted);
         //lier la fonction Brow_ProgressChanged à l'objet
            this.ProgressChanged += new WebBrowserProgressChangedEventHandler(Brow_ProgressChanged);
            _list = list;
        }
        private void Brow_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (_tpage == _metroTabControl.SelectedTab)
            {
                _BarreProgression.Minimum = 0;
                _BarreProgression.Maximum = (int)e.MaximumProgress;
                if ((int)e.CurrentProgress >= 0)
                {
                    _BarreProgression.Visible = true;
                    _BarreProgression.Value = (int)e.CurrentProgress;
                }
                if ((int)e.CurrentProgress <= 0)
                {
                    _BarreProgression.Visible = false;
                }
            }
            else _BarreProgression.Visible = false;
        }
        private void Brow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

               string result;
                int L;
                this._nom = this.DocumentTitle;
                L = _nom.Length;
                result = "";
                if (L > 25)                                              //si nom > a la longueur -> mettre la longueur voulu dans L + ... 
                {
                    L = 25;
                    result = "...";
                }
                result = _nom.Substring(0, L) + result;                 // couper la chaine apres la longueur L                      
                _tpage.Text = result;

                Actualiser();                                            // afficher si possibilité page suivante ou précédente 
                
            }

        public void Actualiser()
        {
            //verifier que le browser a charger 
            if (_list[_metroTabControl.SelectedIndex].Browser().ReadyState == WebBrowserReadyState.Complete || _list[_metroTabControl.SelectedIndex].Browser().ReadyState == WebBrowserReadyState.Interactive) 
            {
                // afficher url de la page actuelle
                _combo.Text = _list[_metroTabControl.SelectedIndex].Browser().Url.ToString();
            }
                    //si il y a une page suivante active le bouton suivant 
                    if (_list[_metroTabControl.SelectedIndex].Browser().CanGoForward)
                    {
                        _Forward.Enabled = true;
                    }
                    else
                    {
                        _Forward.Enabled = false;
                    }

                    //Si il ya une page precedente alors on active le bouton precedent
                    if (_list[_metroTabControl.SelectedIndex].Browser().CanGoBack)
                    {
                        _Back.Enabled = true;
                    }
                    else
                    {
                        _Back.Enabled = false;
                    }
        }
        public void url()
        {
                if ( _combo.Text.StartsWith("http://") ||  _combo.Text.StartsWith("https://") ||  _combo.Text.EndsWith(".com") ||  _combo.Text.EndsWith(".fr") == true)
                {
                    if ( _combo.Text.StartsWith("http://") || _combo.Text.StartsWith("https://") == true)
                    {
                        _list[_metroTabControl.SelectedIndex].Browser().Navigate(new Uri(_combo.Text));
                        // si le texte tapé comence par http:// ou https:// on va a l'adresse saisie
                    }
                    if ( _combo.Text.EndsWith(".com") == true)
                    {
                        _list[_metroTabControl.SelectedIndex].Browser().Navigate(new Uri("https://" + _combo.Text));
                        // si le texte tapé fini par .com on va a l'adresse saisie
                    }
                    if ( _combo.Text.EndsWith(".fr") == true)
                    {
                        _list[_metroTabControl.SelectedIndex].Browser().Navigate(new Uri("http://" + _combo.Text));
                        // si le texte tapé fini par .fr on va a l'adresse saisie
                    }
                }
                else
                {
                    _list[_metroTabControl.SelectedIndex].Browser().Navigate(new Uri(moteur + _combo.Text));
                    //Sinon on le recherche
                }
        }
        public void back()
        {
            _list[_metroTabControl.SelectedIndex].Browser().GoBack(); // ... on revient en arrière sur l'onglet actuel 
        }
        public void next()
        {
            _list[_metroTabControl.SelectedIndex].Browser().GoForward();// ... on repart en avant sur l'onglet actuel
        }
        public void actu()
        {
            _list[_metroTabControl.SelectedIndex].Browser().Refresh();// ... on actualise la page actuel
        }
        public void stop()
        {
            _list[_metroTabControl.SelectedIndex].Browser().Stop();// on stop le chargement de la page actuel
        }
        public void home()
        {
            _list[_metroTabControl.SelectedIndex].Browser().Navigate("www.google.com"); // aller a la page www.google.fr
        }
        public void recherche()
        {
            _list[_metroTabControl.SelectedIndex].Browser().Navigate(new Uri(moteur + _recherche.Text));
        }
     }
 */
#endregion
   
    
    
#region MyTab

   /* class MyTab : TabPage 
    {
        private MetroFramework.Controls.MetroTabControl _metroTabControl;
        private System.Windows.Forms.ComboBox _combo;
        private MetroFramework.Controls.MetroTextBox _recherche;
        private MetroFramework.Controls.MetroButton _Forward;
        private MetroFramework.Controls.MetroButton _Back;
        private MyBrow _brow;
        private List<MyTab> _list = new List<MyTab>();
        private MetroFramework.Controls.MetroProgressBar _ProgressBar;
   
        public MyTab(MetroFramework.Controls.MetroTabControl metroTabControl, System.Windows.Forms.ComboBox combo, MetroFramework.Controls.MetroTextBox recherche, 
                            ref int i, MetroFramework.Controls.MetroButton Back, MetroFramework.Controls.MetroButton Forward, ref List<MyTab> list, 
                                MetroFramework.Controls.MetroProgressBar metroProgressBar)
        {
            _metroTabControl = metroTabControl;
            _combo = combo;
            _recherche = recherche;
            _Forward = Forward;
            _Back = Back;
             _list=list ;
             _ProgressBar = metroProgressBar;
        }

  
        public MyBrow Browser()
        {
            return _brow;
        }
        public void LoadTab(ref int index)
        {

           // Gestion des onglets, ancrage au 4 coins, onglet vide nommé "New Tab", incremente nombre onglet avec i
            _form.metroTabControl1.TabPages.Add("   +");
            _metroTabControl.SelectedTab.Controls.Add(_brow);
            _metroTabControl.Dock = DockStyle.Fill;
            
            addNewTab(ref index);
        }
        public void addNewTab(ref int index)
        {
            //Ajoute l'onglet nouvellement créer à la collection de controle d'onglet
            _metroTabControl.TabPages.Insert(_metroTabControl.TabCount - 1, this);

            //Creation d'un objet navigateur
            _brow = new MyBrow(_metroTabControl, _combo, this, _recherche, _Back, _Forward,_ProgressBar,ref _list);
   
            //Ajoute le navigateur a l'onglet précedement créer
            this.Controls.Add(_brow);
            _brow.Dock = DockStyle.Fill;
            _brow.ScriptErrorsSuppressed = true;
            _metroTabControl.SelectTab(this);

            _brow.Navigate("www.google.fr");

            //Suivre l'onglet newtab 
            index++;

        }
        public void deletTab(ref int index)
        {
           int tab = _metroTabControl.SelectedIndex;

            _metroTabControl.TabPages.Remove(_metroTabControl.SelectedTab);       // supprime l'onget selectionner 
            if (index-1 == tab) _metroTabControl.SelectTab(tab-1);                 // si l'onglet est le dernier selection celui avant le newtab 
            else _metroTabControl.SelectTab(tab);                                  //sinon selectioner l'onglet juste après 
            _brow.Actualiser();
            index--;                                                               // suivre l'onglet newtab 
            
        }
  
    } */
#endregion
   
}