using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArtista_Click(object sender, EventArgs e)
        {
            string Artista = txtArtista.Text;
            try
            {
               
                StringBuilder queryartista =new StringBuilder();
                queryartista.Append("https://ws.spotify.com/search/1/Artist?q=");
                if (Artista != string.Empty)
                {
                    queryartista.Append(Artista+" ,"+"+");
                }
                webBrowser1.Navigate(queryartista.ToString());
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString(),"Error");
            }





        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            string Artista = txtArtista.Text;
            string Album = txtAlbum.Text;
            try
            {

                StringBuilder queryartista = new StringBuilder();
                queryartista.Append("https://ws.spotify.com/search/1/Album?q=");
                if (Artista != string.Empty)
                {
                    queryartista.Append(Artista + " ," + "+");
                }
                webBrowser1.Navigate(queryartista.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error");
            }

            
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {

            string Artista = txtArtista.Text;
            string Track = txtTrack.Text;
            try
            {

                StringBuilder queryartista = new StringBuilder();
                queryartista.Append("https://ws.spotify.com/search/1/Track?q=");
                if (Artista != string.Empty)
                {
                    queryartista.Append(Artista + " ," + "+");
                }
                webBrowser1.Navigate(queryartista.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }



    }
}
