//Leonardo Notarnicola 4 inf A 
//Roulette Russa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto
{
    public partial class Form1 : Form
    {

        int[] vettore = new int[6];
        int conta = 0;
        bool controllo = false;
        bool giocatore = true;  //true = giocatore 1, false = giocatore 2
        int restanti = 6;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void spara_Click(object sender, EventArgs e)//bottone SPARA
        {

            
            
            
            
            if (controllo && conta<6)
            {
                restanti--;
                res.Text = "Proiettili restanti : " + restanti;




                if (vettore[conta] == 1)//se vettore[conta] == 1    -->    verrà sparato il proiettile 
                {
                    ris.Text = "1";//aggiorno il testo
                    if (giocatore)
                    {
                        MessageBox.Show("Giocatore 1 hai perso !!");//messaggio di fine partita 
                    }
                    else
                    {
                        MessageBox.Show("Giocatore 2 hai perso !!");//messaggio di fine partita 
                    }

                    spara.Enabled = false;//disattivo tasto spara
                    carica.Enabled = true;//attivo tasto ricarica


                }
                else
                {
                    ris.Text = "0";//non e' stato sparato il proiettile

                    conta++;
                    giocatore = !giocatore;

                    if (giocatore)//true = giocatore 1, false = giocatore 2
                    {
                        turno.Text = "Turno giocatore 1";//aggiorna turno
                    }
                    else
                    {
                        turno.Text = "Turno giocatore 2";//aggiorn turno

                    }

                }





            }
            else
            {
                MessageBox.Show("Attenzione devi prima caricare la pistola", "WARNING");
            }

            

           

        }

        private void carica_Click(object sender, EventArgs e)//bottone CARICA
        {

            ris.Text = " ";
            restanti = 6;
            res.Text = "Proiettili restanti : " + restanti;


            conta = 0;
            
            for(int i = 0; i < 5; i++)
            {
                vettore[i] = 0;
            }
            
            
            Random ran = new Random();
            int c = ran.Next(0, 6);//generazione numero casuale da 0 a 6
            vettore[c] = 1;// " carico il proiettile " nella posizione c generata casualmente

            controllo = true;
            carica.Enabled = false;
            spara.Enabled = true;


            
        }

        private void creatore_Click(object sender, EventArgs e)//creatore
        {
            MessageBox.Show("Leonardo Notarnicola\n4 inf A", "INFO");
        }

        private void eSCIToolStripMenuItem_Click(object sender, EventArgs e)//uscita
        {
            Application.Exit();
        }

       
    }
}
