using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCG.APICG;

namespace AppCG
{
    public partial class FormChromaKey : Form
    {

        private Bitmap bitmap1;
        private Bitmap bitmap2;

        public FormChromaKey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //Utilizado para abrir o arquivo
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)//se o arquivo for aberto
            {
                string file = openFileDialog.FileName; //adiquiro o nome do arquivo
                try
                {
                    textBox1.Text = file;
                    bitmap1 = new Bitmap(file);
                }
                catch (IOException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //Utilizado para abrir o arquivo
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)//se o arquivo for aberto
            {
                string file = openFileDialog.FileName; //adiquiro o nome do arquivo
                try
                {
                    textBox2.Text = file;
                    bitmap2 = new Bitmap(file);
                }
                catch (IOException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(bitmap1 != null && bitmap2 != null)
            {
                Chromakey chromaKey = new Chromakey(bitmap1,bitmap2);
                pictureBox1.Image = chromaKey.ChromaKeyFullBitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
