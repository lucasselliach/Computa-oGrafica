using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCG.APICG;

namespace AppCG
{
    public partial class FormFiltro : Form
    {
        private ImagemLoad _imagemLoad;
        private int[,] _kernel;

        public FormFiltro(ImagemLoad imagemLoad)
        {
            _imagemLoad = imagemLoad;
            InitializeComponent();
        }

        private void Load()
        {
            if (_kernel != null)
            {
                progressBar1.Maximum = _imagemLoad.BitmapPixels.Height * _imagemLoad.BitmapPixels.Width;
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                Filtro filtro = new Filtro(_imagemLoad, _kernel, progressBar1);
                pictureBox1.Image = filtro.FiltroFullBitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_imagemLoad != null)
            {
                int um = Convert.ToInt32(textBox1.Text);
                int dois = Convert.ToInt32(textBox2.Text);
                int tres = Convert.ToInt32(textBox3.Text);
                int quatro = Convert.ToInt32(textBox4.Text);
                int cinco = Convert.ToInt32(textBox5.Text);
                int seis = Convert.ToInt32(textBox6.Text);
                int sete = Convert.ToInt32(textBox7.Text);
                int oito = Convert.ToInt32(textBox8.Text);
                int nove = Convert.ToInt32(textBox9.Text);

                _kernel = new int[,] { { um, dois, tres }, { quatro, cinco, seis }, { sete, oito, nove } };

                Load();
            }
        }

        private void buttonPA_Click(object sender, EventArgs e)
        {
            _kernel = new int[,] {{-1,-1,-1}, {-1,8,-1}, {-1,-1,-1}};
            Load();
        }

        private void buttonPB_Click(object sender, EventArgs e)
        {
            _kernel = new int[,] {{1,2,1}, {2,5,2}, {1,2,1}};
            Load();
        }

    }
}
