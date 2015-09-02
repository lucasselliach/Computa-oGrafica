using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCG.APICG
{
    class Chromakey
    {
        public Bitmap ChromaKeyFullBitmap { get; set; }

        private readonly Bitmap _imagemLoadFrente;
        private readonly Bitmap _imagemLoadFundo;

        public Chromakey(Bitmap imagemLoad1,Bitmap imagemLoad2)
        {
            _imagemLoadFrente = imagemLoad1; //carrega a imagem carregada
            _imagemLoadFundo = imagemLoad2; //carrega a imagem carregada
            ChromaKeyFullBitmap = new Bitmap(imagemLoad2.Width, imagemLoad2.Height); //cria uma imagem nova com as dimensoes da imagem de fundo carregada carregada
            ChromaKeyLoad();
        }

        public void ChromaKeyLoad()
        {
            for (int x = 0; x < _imagemLoadFrente.Width; x++)
            {
                for (int y = 0; y < _imagemLoadFrente.Height; y++)
                {
                    Color pixelColor = _imagemLoadFrente.GetPixel(x, y);//pego o pixel dela
                    if (pixelColor.R < 60 && pixelColor.G > 200 && pixelColor.B < 60)
                    {
                        pixelColor = _imagemLoadFundo.GetPixel(x, y);
                        ChromaKeyFullBitmap.SetPixel(x, y, pixelColor);//crio uma bitmap clone da imagem
                    }else
                    {
                        ChromaKeyFullBitmap.SetPixel(x, y, pixelColor);
                    }
                }
            }
        }
    }
}
