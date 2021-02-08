using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Globals;

namespace Gestore_Cartelle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public int num = 0;
        Globals.Elemento[] eleCartelle = new Globals.Elemento[50];


        private void avvio(object sender, EventArgs e)
        {
            Class1.CaricaArchivio(eleCartelle, ref num); //prende dati da archivio

            //aggiorna listbox
            listbox1.BeginUpdate();
            listbox1.Items.Clear();
            for (int x = 0; x < num; x++)
            {
                listbox1.Items.Add(eleCartelle[x].nome);
            }
            listbox1.EndUpdate();
        }

        

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            txt_nome.Show();
            txt_indirizzo.Show();
            btn_crea.Show();
            btn_annulla.Show();
            webBrowser.Navigate("about:blank");
            webBrowser.Hide();
            

            //stile elementi
            txt_nome.ForeColor = Color.Gainsboro;
            txt_nome.Text = "nome";

            txt_indirizzo.ForeColor = Color.Gainsboro;
            txt_indirizzo.Text = "directory";


        }

        private void btn_crea_Click(object sender, EventArgs e)
        {
            if(txt_nome.Text=="nome" || txt_indirizzo.Text=="directory" || string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_indirizzo.Text))
            {
                MessageBox.Show("Inserisci tutti i campi");
                return;
            }
            else
            {
                eleCartelle[num].nome = txt_nome.Text;
                eleCartelle[num].directory = txt_indirizzo.Text;
                num++;
                Class1.SalvaArchivio(eleCartelle, num); //salva l'elemento sul disco

                //aggiorna la listbox
                listbox1.BeginUpdate();
                listbox1.Items.Clear();
                for (int x = 0; x < num; x++)
                {
                    listbox1.Items.Add(eleCartelle[x].nome);
                }
                listbox1.EndUpdate();

                //nasconde gli elementi necessari per creare il nuovo elemento
                txt_nome.Hide();
                txt_indirizzo.Hide();
                btn_crea.Hide();
                btn_annulla.Hide();
            }
        }

        private void listbox1_DoubleClick(object sender, EventArgs e)
        {
            int k = listbox1.SelectedIndex;
            if (k == -1)
            {
                return;
            }
            webBrowser.Show();
            webBrowser.Url = new Uri(eleCartelle[k].directory);
            listbox1.Hide();
            txt_path.Text = eleCartelle[k].directory;
            btn_elimina_elemento.Hide();
        }

        private void btn_annulla_Click(object sender, EventArgs e)
        {
            txt_nome.ResetText();
            txt_indirizzo.ResetText();

            txt_nome.Hide();
            txt_indirizzo.Hide();
            btn_annulla.Hide();
            btn_crea.Hide();
            
        }

        private void txt_nome_Enter(object sender, EventArgs e)
        {
            txt_nome.ResetText();
            txt_nome.ForeColor = Color.Black;
        }

        
        private void txt_indirizzo_Enter(object sender, EventArgs e)
        {
            txt_indirizzo.ResetText();
            txt_indirizzo.ForeColor = Color.Black;
        }

        
        private void btn_home_Click(object sender, EventArgs e)
        {
            txt_nome.ResetText();
            txt_nome.Hide();

            txt_indirizzo.ResetText();
            txt_indirizzo.Hide();

            btn_crea.Hide();
            btn_annulla.Hide();

            webBrowser.Navigate("about:blank");
            webBrowser.Hide();

            listbox1.Show();

            txt_path.ResetText();


        }

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = listbox1.SelectedIndex;
            if (k == -1)
            {
                return;
            }
            btn_elimina_elemento.Show();

        }

        private void btn_elimina_elemento_Click(object sender, EventArgs e)
        {
            int k = listbox1.SelectedIndex;
            if (k == -1)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show($"Eliminare l'elemento {eleCartelle[k].nome}? ", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                eleCartelle[k] = eleCartelle[num - 1];
                num = num - 1;

                //aggiorna la listbox
                listbox1.BeginUpdate();
                listbox1.Items.Clear();
                for (int x = 0; x < num; x++)
                {
                    listbox1.Items.Add(eleCartelle[x].nome);
                }
                listbox1.EndUpdate();

                //aggiorna l'archivio su disco
                Class1.SalvaArchivio(eleCartelle, num);


            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            btn_elimina_elemento.Hide();
        }
        

        
    }
}
