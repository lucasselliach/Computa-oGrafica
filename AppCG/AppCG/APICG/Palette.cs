using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCG.APICG
{
    public class Palette
    {
        public Bitmap PaletteFullBitmap { get; set; }
        public int Value = 10;

        private ProgressBar _progressBar;
        private readonly ImagemLoad _imagemLoad;

        public Palette(ImagemLoad imagemLoad, ProgressBar bar, int Value)
        {
            this.Value = Value;
            _imagemLoad = imagemLoad; //carrega a imagem carregada
            _progressBar = bar;
            PaletteFullBitmap = new Bitmap(imagemLoad.BitmapPixels.Width, imagemLoad.BitmapPixels.Height); //cria uma imagem nova com as dimensoes da imagem carregada
            PaletteLoad();
        }

        public void PaletteLoad()
        {
            Double dist; //variavel para definir o tamanho
            Double distAnt = 0; // para armazenas valor anterior
            Boolean flag = true;

            for (int x = 0; x < _imagemLoad.BitmapPixels.Width; x++) //pecorre o bitmap da imagem carregada para analisar os pixel e verificar qual a cor do palette vai substituir ele.
            {
                for (int y = 0; y < _imagemLoad.BitmapPixels.Height; y++)
                {
                    dist = 0;
                    flag = true;
                    Color pixelColor = _imagemLoad.BitmapPixels.GetPixel(x, y);

                    foreach (var histograma in _imagemLoad.Histograma.Take(Value)) // Aqui será feito um foreach para pecorre a lista de pixel que aparece mais vezes no histograma
                    {
                        dist = Math.Sqrt(Math.Pow((pixelColor.R - histograma.Color.R),2) + // Aqui será realizado o calculo da distancia
                                         Math.Pow((pixelColor.G - histograma.Color.G),2) +
                                         Math.Pow((pixelColor.B - histograma.Color.B),2));

                        if ((dist <= distAnt)||(flag)) //Se a distancia for menor ou igual q a anterior
                        {
                            flag = false;
                            distAnt = dist; // ela vira nova distancia
                            PaletteFullBitmap.SetPixel(x, y, histograma.Color);
                                // e a cor é definida no pixel para forma a nova imagem com base nos palettes
                        }
                    }
                    _progressBar.PerformStep();
                }

            }
        }
    }
}
