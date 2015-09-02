using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCG.APICG
{
    public class Filtro
    {
        private ImagemLoad _imagemLoad;
        private int[,] _kernel;
        private int divisor = 0;
        private int r, g, b;
        private ProgressBar _progressBar;

        public Bitmap FiltroFullBitmap { get; set; }

        public Filtro(ImagemLoad imagemLoad, int[,] kernel, ProgressBar bar)
        {
            _imagemLoad = imagemLoad;
            _kernel = kernel;
            _progressBar = bar;
            FiltroFullBitmap = new Bitmap(imagemLoad.BitmapPixels.Width, imagemLoad.BitmapPixels.Height); //crio um Bitmap da imagem com as mesma dimensões da imagem carregada
            Load();
        }

        private void Load()
        {
            DivisorKernel();
            int width = _imagemLoad.BitmapPixels.Width;
            int height = _imagemLoad.BitmapPixels.Height;

            for (int x = 0; x < width; x++) //pecorro a imagem carregada
            {
                for (int y = 0; y < height; y++)
                {
                    r = 0; //zero valores rgb para n acumular
                    g = 0; 
                    b = 0; 

                    for (int xk = 0; xk < 3; xk++)
                    {
                        for (int yk = 0; yk < 3; yk++) //realizo a verificaçao do kernel
                        {
                            int valorx = 0 , valory = 0; // aqui calculo a posiçao do pixel x e y sendo que vai pega o pixel vizinho do pixel selecionado pelo primeiro laço

                            valorx = x - xk;
                            if (x - xk < 0) valorx = 1; //caso não tenha pixel do lado da posicao 0 retorno o proprio pixel
                            if (x - xk >= width) valorx = width - 1; //caso não tenha pixel do lado da posicao final retorno o proprio pixel

                            valory = y - yk;
                            if (y - yk < 0) valory = 1; //caso não tenha pixel de cima da posicao 0 retorno o proprio pixel
                            if (y - yk >= height) valory = height - 1; //caso não tenha pixel de baixo da posicao final retorno o proprio pixel


                            r += _imagemLoad.BitmapPixels.GetPixel(valorx, valory).R * _kernel[xk, yk]; //pego a posiçao da imagem e faço ver o valor xy do kernel 
                            g += _imagemLoad.BitmapPixels.GetPixel(valorx, valory).G * _kernel[xk, yk];
                            b += _imagemLoad.BitmapPixels.GetPixel(valorx, valory).B * _kernel[xk, yk];
                        }
                    }
                    _progressBar.PerformStep();

                    int valor1, valor2, valor3;

                    valor1 = r/divisor;
                    valor2 = g/divisor;
                    valor3 = b/divisor;

                    if (valor1 < 0) valor1 = 0;
                    if (valor1 > 255) valor1 = 255;
                    if (valor2 < 0) valor2 = 0;
                    if (valor2 > 255) valor2 = 255;
                    if (valor3 < 0) valor3 = 0;
                    if (valor3 > 255) valor3 = 255;

                    Color color = Color.FromArgb(valor1,valor2,valor3);
                    FiltroFullBitmap.SetPixel(x, y, color);   
                }
            }
        }

        private void DivisorKernel()
        {
            foreach (var i in _kernel)
            {
                divisor += i;
            }
           if (divisor == 0) divisor = 1;
        }
    }
}
