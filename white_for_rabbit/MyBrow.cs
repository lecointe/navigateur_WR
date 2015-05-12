using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Resources;

namespace white_for_rabbit
{
    class MyBrow : WebBrowser
    {
        public string moteur = "https://www.google.fr/#q=";
        private string _nom;
        private TabPage _tpage;

        private List<MyTab> _list = new List<MyTab>();
        private Form1 _form;

        public MyBrow(Form1 form,TabPage tpage, ref List<MyTab> list)
        {
            
            _tpage = tpage;
            _form = form;
            //lier la fontion Brow_DocumentCompleted à l'objet 
            this.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Brow_DocumentCompleted);
            //lier la fonction Brow_ProgressChanged à l'objet
            this.ProgressChanged += new WebBrowserProgressChangedEventHandler(Brow_ProgressChanged);
            _list = list;
            this.Navigate("www.google.fr");
        }
        private void Brow_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (this == _list[_form.metroTabControl1.SelectedIndex].Browser())
            {
                _form.metroProgressBar.Minimum = 0;
                _form.metroProgressBar.Maximum = (int)e.MaximumProgress;
                if ((int)e.CurrentProgress >= 0)
                {
                    _form.metroProgressBar.Visible = true;
                    _form.metroProgressBar.Value = (int)e.CurrentProgress;
                }
                if ((int)e.CurrentProgress <= 0)
                {
                    _form.metroProgressBar.Visible = false;
                }
              
            }
            else _form.metroProgressBar.Visible = false;
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
          //  MessageBox.Show(_form.url.Text.ToString());

        }

        public void Actualiser()
        {         
            if (_list[_form.metroTabControl1.SelectedIndex].Browser() != null)
            {
            //verifier que le browser a charger 
           if (_list[_form.metroTabControl1.SelectedIndex].Browser().ReadyState == WebBrowserReadyState.Complete || _list[_form.metroTabControl1.SelectedIndex].Browser().ReadyState == WebBrowserReadyState.Interactive)
            {

                // afficher url de la page actuelle
                _form.url.Text = _list[_form.metroTabControl1.SelectedIndex].Browser().Url.ToString();
                           }
                //si il y a une page suivante active le bouton suivant 
                if (_list[_form.metroTabControl1.SelectedIndex].Browser().CanGoForward)
                {
                    _form.ButtonNext.Enabled = true;
                }
                else
                {
                    _form.ButtonNext.Enabled = false;
                }

                //Si il ya une page precedente alors on active le bouton precedent
                if (_list[_form.metroTabControl1.SelectedIndex].Browser().CanGoBack)
                {
                    _form.ButtonBack.Enabled = true;
                }
                else
                {
                    _form.ButtonBack.Enabled = false;
                }
            }
        }
        public void url()
        {
            if (_form.url.Text.StartsWith("http://") || _form.url.Text.StartsWith("https://") || _form.url.Text.EndsWith(".com") || _form.url.Text.EndsWith(".fr") == true)
            {
                if (_form.url.Text.StartsWith("http://") || _form.url.Text.StartsWith("https://") == true)
                {
                    _list[_form.metroTabControl1.SelectedIndex].Browser().Navigate(new Uri(_form.url.Text));
                    // si le texte tapé comence par http:// ou https:// on va a l'adresse saisie
                }
                if (_form.url.Text.EndsWith(".com") == true)
                {
                    _list[_form.metroTabControl1.SelectedIndex].Browser().Navigate(new Uri("https://" + _form.url.Text));
                    // si le texte tapé fini par .com on va a l'adresse saisie
                }
                if (_form.url.Text.EndsWith(".fr") == true)
                {
                    _list[_form.metroTabControl1.SelectedIndex].Browser().Navigate(new Uri("http://" + _form.url.Text));
                    // si le texte tapé fini par .fr on va a l'adresse saisie
                }
            }
            else
            {
                _list[_form.metroTabControl1.SelectedIndex].Browser().Navigate(new Uri(moteur + _form.url.Text));
                //Sinon on le recherche
            }
        }
        public void back()
        {
            _list[_form.metroTabControl1.SelectedIndex].Browser().GoBack(); // ... on revient en arrière sur l'onglet actuel 
        }
        public void next()
        {
            _list[_form.metroTabControl1.SelectedIndex].Browser().GoForward();// ... on repart en avant sur l'onglet actuel
        }
        public void actu()
        {
            _list[_form.metroTabControl1.SelectedIndex].Browser().Refresh();// ... on actualise la page actuel
        }
        public void stop()
        {
            _list[_form.metroTabControl1.SelectedIndex].Browser().Stop();// on stop le chargement de la page actuel
        }
        public void home()
        {
            _list[_form.metroTabControl1.SelectedIndex].Browser().Navigate("www.google.com"); // aller a la page www.google.fr
        }
        public void recherche()
        {
            _list[_form.metroTabControl1.SelectedIndex].Browser().Navigate(new Uri(moteur + _form.recherche.Text));
        }
    }
}
