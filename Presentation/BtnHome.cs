using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class BtnHome : UserControl
    {
        public BtnHome()
        {
            InitializeComponent();
        }

        public Color color;

        [Category("Custom Props")]
        public Color GetColor
        {
            get { return color; }
            set { color = value; }
        }

        private void BtnHome_Load(object sender, System.EventArgs e)
        {
            BackColor = color;
        }
    }
}
