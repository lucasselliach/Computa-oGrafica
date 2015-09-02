using System.Windows.Forms;
using AppCG.APICG;

namespace AppCG
{
    public partial class FormTonsCinza : Form
    {
        private readonly TonsCinza _tonsCinza;

        public FormTonsCinza(TonsCinza tonsCinza)
        {
            _tonsCinza = tonsCinza;
            InitializeComponent();
            Load(); 
        }

        public new void Load()
        {
            pictureBox1.Image = _tonsCinza.TonsCinzaFullBitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
