using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureProcessor
{
    class PicturePropertyExtractor
    {
        public void imagedisp(object sender, PaintEventArgs e)
        {
            Image img = Image.FromFile("D:/THEWEBSITE/ImageInventory/IMG_7412.jpg");
            Point ulc = new Point(100, 100);
            e.Graphics.DrawImage(img, ulc);
        }

        public void imagemetadata()
        {
            
        }
    }
}
