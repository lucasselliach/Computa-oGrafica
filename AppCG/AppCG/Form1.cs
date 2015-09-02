using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AppCG.APICG;

namespace AppCG
{
    public partial class Form1 : Form
    {
        
        private ImagemLoad imagemLoad;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //Utilizado para abrir o arquivo
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)//se o arquivo for aberto
            {
                string file = openFileDialog.FileName; //adiquiro o nome do arquivo
                try
                {
                    textBoxOpenFile.Text = file;
                    Bitmap bitmap = new Bitmap(file);
                    imagemLoad = new ImagemLoad(bitmap);
                    pictureBoxVisualizaImagem.Image = imagemLoad.BitmapPixels;
                    pictureBoxVisualizaImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (IOException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        private void buttonPalette_Click(object sender, EventArgs e)
        {
            try
            {
                if (imagemLoad != null)
                {
                    FormReducaoCores formPalette = new FormReducaoCores(imagemLoad);
                    formPalette.Show();
                }
                else
                {
                    throw new FileLoadException();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonTonsCinza_Click(object sender, EventArgs e)
        {
            try
            {
                if (imagemLoad != null)
                {
                    TonsCinza tonsCinza = new TonsCinza(imagemLoad);
                    FormTonsCinza formTonsCinza = new FormTonsCinza(tonsCinza);
                    formTonsCinza.Show();
                }
                else
                {
                    throw new FileLoadException();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonKhromaKey_Click(object sender, EventArgs e)
        {
            try
            {
                    FormChromaKey formChromaKey = new FormChromaKey();
                    formChromaKey.Show();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void buttonFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                FormFiltro formFiltro = new FormFiltro(imagemLoad);
                formFiltro.Show();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

       
    }
}
