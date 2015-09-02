using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AppCG.APICG
{
    public class ImagemLoad
    {
        public List<Color> PixelColorList { get; set; } // Lista de Pixel da imagem 
        public List<Histograma> Histograma { get; set; } // Histograma da imagem
        public Bitmap BitmapPixels { get; set; } // Bitmap da imagem gerado

        public ImagemLoad(Bitmap bitmap)
        {
            PixelColorList = new List<Color>(); 
            BitmapPixels = new Bitmap(bitmap.Width, bitmap.Height);
            Load(bitmap);
        }

        private void Load(Bitmap bitmap)// pecorro a imagem carregado
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);//pego o pixel dela

                    PixelColorList.Add(pixelColor);//crio uma lista de cores
                    BitmapPixels.SetPixel(x, y, pixelColor);//crio uma bitmap clone da imagem
                }
            }
            HistogramaLoad();
        }

        private void HistogramaLoad()
        {
                Histograma = PixelColorList
                .GroupBy(x => x)
                .Select(x => new Histograma(){ Color = x.Key, Repeats = x.Count() })
                .OrderByDescending(x => x.Repeats).ToList(); 
        }
    }
}

