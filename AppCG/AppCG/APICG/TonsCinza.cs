using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCG.APICG
{
    public class TonsCinza
    {
        private ImagemLoad _imagemLoad;
        public Bitmap TonsCinzaFullBitmap { get; set; }

        public TonsCinza(ImagemLoad imagemLoad)
        {
            _imagemLoad = imagemLoad; // carrego a imagem 
            TonsCinzaFullBitmap = new Bitmap(imagemLoad.BitmapPixels.Width, imagemLoad.BitmapPixels.Height); //crio um Bitmap da imagem com as mesma dimensões da imagem carregada
            Load();
        }

        public void Load()
        {
            for (int x = 0; x < _imagemLoad.BitmapPixels.Width; x++) //pecorro a imagem carregada
            {
                for (int y = 0; y < _imagemLoad.BitmapPixels.Height; y++)
                {
                    Color pixelColor = _imagemLoad.BitmapPixels.GetPixel(x, y); //adiquiro o pixel da posicao da imagem

                    int luminosidade = Convert.ToInt32(pixelColor.R*0.3 + pixelColor.G*0.59 + pixelColor.B*0.11); //calculo a luminosidade

                    TonsCinzaFullBitmap.SetPixel(x, y, Color.FromArgb(luminosidade, luminosidade, luminosidade)); // crio um pixel na posiçao da imagem com tom de cinza
                }
            }
        }
    }
}
