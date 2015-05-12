using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Resources;



namespace white_for_rabbit
{
    class MyAwe : Awesomium.Windows.Forms.WebControl
    {

            public string moteur = "https://www.google.fr/#q=";
            private Form1 _form;
            private TabPage _tpage;
            private List<MyTab> _list = new List<MyTab>();
            private string _nom;
            public MyAwe(Form1 form, TabPage tpage, ref List<MyTab> list)
            {


                _tpage = tpage;
                _form = form;
                //lier la fontion Awe_DocumentCompleted à l'objet 
                this.DocumentReady += new Awesomium.Core.DocumentReadyEventHandler(Awe_DocumentCompleted);
                //lier la fonction Awe_ProgressChanged à l'objet
               // this.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(Awe_ProgressChanged);
                this.
                   _list = list;

                this.Source = new Uri("http://www.google.fr");

            }

            public void Awe_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
            {
                if (_tpage == _form.metroTabControl1.SelectedTab)
                {
                    _form.metroProgressBar.Minimum = 0;
                    _form.metroProgressBar.Maximum = (int)e.ProgressPercentage;
                    if ((int)e.ProgressPercentage >= 0)
                    {
                        _form.metroProgressBar.Visible = true;
                        _form.metroProgressBar.Value = (int)e.ProgressPercentage;
                    }
                    if ((int)e.ProgressPercentage <= 0)
                    {
                        _form.metroProgressBar.Visible = false;
                    }
                }
                else _form.metroProgressBar.Visible = false;

            }

            private void Awe_DocumentCompleted(object sender, Awesomium.Core.DocumentReadyEventArgs e)
            {

                string result;
                int L;
                this._nom = this.Title;
                L = _nom.Length;
                result = "*";
                if (L > 25)                                              //si nom > a la longueur -> mettre la longueur voulu dans L + ... 
                {
                    L = 25;
                    result = "...";
                }
                result = "*" + _nom.Substring(0, L) + result;                 // couper la chaine apres la longueur L                      
                _tpage.Text = result;

                Actualiser();                                            // afficher si possibilité page suivante ou précédente 
                //  MessageBox.Show(_form.url.Text.ToString());

            }
            public void Actualiser()
            {
                if (_list[_form.metroTabControl1.SelectedIndex].Awe() != null)
                {
                    //verifier que le browser a charger 
                    //          if (_list[_form.metroTabControl1.SelectedIndex].Awe().OnProcessCreated == WebControlReadyState.Complete || _list[_form.metroTabControl1.SelectedIndex].Awe().ReadyState == WebBrowserReadyState.Interactive)
                    //          {
                    // afficher url de la page actuelle

                    _form.url.Text = _list[_form.metroTabControl1.SelectedIndex].Awe().Source.ToString();
                    //          }
                    //si il y a une page suivante active le bouton suivant 
                    if (_list[_form.metroTabControl1.SelectedIndex].Awe().CanGoForward() == true)
                    {
                        _form.ButtonNext.Enabled = true;
                    }
                    else
                    {
                        _form.ButtonNext.Enabled = false;
                    }

                    //Si il ya une page precedente alors on active le bouton precedent
                    if (_list[_form.metroTabControl1.SelectedIndex].Awe().CanGoBack() == true)
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
                        _list[_form.metroTabControl1.SelectedIndex].Awe().Source = new Uri(_form.url.Text);
                        // si le texte tapé comence par http:// ou https:// on va a l'adresse saisie
                    }
                    if (_form.url.Text.EndsWith(".com") == true)
                    {
                        _list[_form.metroTabControl1.SelectedIndex].Awe().Source = new Uri("https://" + _form.url.Text);
                        // si le texte tapé fini par .com on va a l'adresse saisie
                    }
                    if (_form.url.Text.EndsWith(".fr") == true)
                    {
                        _list[_form.metroTabControl1.SelectedIndex].Awe().Source = new Uri("http://" + _form.url.Text);
                        // si le texte tapé fini par .fr on va a l'adresse saisie
                    }
                }
                else
                {
                    _list[_form.metroTabControl1.SelectedIndex].Awe().Source = new Uri(moteur + _form.url.Text);
                    //Sinon on le recherche
                }
            }
            public void back()
            {
                _list[_form.metroTabControl1.SelectedIndex].Awe().GoBack(); // ... on revient en arrière sur l'onglet actuel 
            }
            public void next()
            {
                _list[_form.metroTabControl1.SelectedIndex].Awe().GoForward();// ... on repart en avant sur l'onglet actuel
            }
            public void actu()
            {
                _list[_form.metroTabControl1.SelectedIndex].Awe().Refresh();// ... on actualise la page actuel
            }
            public void stop()
            {
                _list[_form.metroTabControl1.SelectedIndex].Awe().Stop();// on stop le chargement de la page actuel
            }
            public void home()
            {
                _list[_form.metroTabControl1.SelectedIndex].Awe().Source = new Uri("http://www.google.com"); // aller a la page www.google.fr
            }
            public void recherche()
            {
                _list[_form.metroTabControl1.SelectedIndex].Awe().Source = new Uri(moteur + _form.recherche.Text);
            }

        }
    
}
