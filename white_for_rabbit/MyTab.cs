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
    class MyTab : TabPage
    {
        private MyAwe _awe=null;
        private MyBrow _brow=null;
        private List<MyTab> _list = new List<MyTab>();
        private Form1 _form;
        public MyTab(Form1 form, ref List<MyTab> list)
        {
            
            _form = form;
            _list = list;
        }

        public MyAwe Awe()
        {
            return _awe;
        }
        public MyBrow Browser()
        {
            return _brow;
        }
        public void LoadTab(ref int index)
        {
  
            // Gestion des onglets, ancrage au 4 coins, onglet vide nommé "New Tab", incremente nombre onglet avec i
            _form.metroTabControl1.TabPages.Add("   +");
            _form.metroTabControl1.SelectedTab.Controls.Add(_brow);
            _form.metroTabControl1.Dock = DockStyle.Fill;

            addNewTab(ref index);
        }
        public void addNewTab(ref int index)
        {
            //Ajoute l'onglet nouvellement créer à la collection de controle d'onglet
            _form.metroTabControl1.TabPages.Insert(_form.metroTabControl1.TabCount - 1, this);
            if (_form.ToggleMyAwe.Checked == true)
            {
                //Creation d'un objet navigateur
                _awe = new MyAwe(_form, this, ref _list);

                //Ajoute le navigateur a l'onglet précedement créer
                this.Controls.Add(_awe);

                _awe.Dock = DockStyle.Fill;
                _form.metroTabControl1.SelectTab(this);
                
            }
            if(_form.ToggleMyBrow.Checked==true)
            {
                //Creation d'un objet navigateur
                _brow = new MyBrow(_form, this, ref _list);

                //Ajoute le navigateur a l'onglet précedement créer
                this.Controls.Add(_brow);

                _brow.Dock = DockStyle.Fill;
                _brow.ScriptErrorsSuppressed = true;
                _form.metroTabControl1.SelectTab(this);

            }


            //Suivre l'onglet newtab 
            index++;

        }
        public void deletTab(ref int index)
        {
            int tab = _form.metroTabControl1.SelectedIndex;

            _form.metroTabControl1.TabPages.Remove(_form.metroTabControl1.SelectedTab);       // supprime l'onget selectionner 
            if (index - 1 == tab) _form.metroTabControl1.SelectTab(tab - 1);                 // si l'onglet est le dernier selection celui avant le newtab 
            else _form.metroTabControl1.SelectTab(tab);                                  //sinon selectioner l'onglet juste après 
            if (_list[_form.metroTabControl1.SelectedIndex].Browser() != null)
            {
                _list[_form.metroTabControl1.SelectedIndex].Browser().Actualiser();
            }
            if (_list[_form.metroTabControl1.SelectedIndex].Awe() != null)
            {
               _list[_form.metroTabControl1.SelectedIndex].Awe().Actualiser();
            }
            index--;                                                               // suivre l'onglet newtab 

        }

    }
}
