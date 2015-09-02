using System;
using System.Windows.Forms;
using AppCG.APICG;

namespace AppCG
{
    public partial class FormReducaoCores : Form
    {
        public Palette Palette { get; set; }
        private ImagemLoad _imagemLoad;

        public FormReducaoCores(ImagemLoad imagemLoad)
        {
            _imagemLoad = imagemLoad;
            InitializeComponent();
        }

        private void Load()
        {
            progressBar1.Maximum = _imagemLoad.BitmapPixels.Height * _imagemLoad.BitmapPixels.Width;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            Palette palette = new Palette(_imagemLoad, progressBar1, Convert.ToInt32(textBox1.Text));
            pictureBoxPallete.Image = palette.PaletteFullBitmap;
            pictureBoxPallete.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load();
        }
    }
}
