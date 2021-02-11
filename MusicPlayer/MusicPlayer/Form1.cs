using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] paths, files;
        private void btnSceglimusica_Click(object sender, EventArgs e)
        {
            OpenFileDialog Sceglimusica = new OpenFileDialog();
            //selezioni piu files
            Sceglimusica.Multiselect = true;
            if (Sceglimusica.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = Sceglimusica.SafeFileNames;//Salva nome del file nell array
                paths = Sceglimusica.FileNames;//Salva la path per il file musica nel array
                //Visualizza ora in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxMusica.Items.Add(files[i]); //visualizza musica nella list 
                }
            }
        }

        private void listBoxMusica_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Codice per avviare musica
            axWindowsMediaPlayer1.URL = paths[listBoxMusica.SelectedIndex];//click per avviare musica nel windows media player
        }

    }
}
