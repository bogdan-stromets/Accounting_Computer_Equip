using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Accounting_Computer_Equip.Misc
{
    public static class PlaceholderController
    {
        public static void AddPlaceholder(this TextBox tb, string placeholder_txt, Color placeholderColor, Color textColor)
        {
            tb.ForeColor = placeholderColor;
            tb.Text = placeholder_txt;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder_txt)
                {
                    tb.Text = string.Empty;
                    tb.ForeColor = textColor;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (tb.Text == string.Empty)
                {
                    tb.ForeColor = placeholderColor;
                    tb.Text = placeholder_txt;
                }
            };
        }

        public static void RotateImage(this PictureBox pb, PointF offset, float angle)
        {
            Image image = pb.Image;
            pb.Image = null;
            if (image == null)
                throw new ArgumentNullException("image");

            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmp);
            g.Clear(Color.Transparent);
            g.TranslateTransform(offset.X, offset.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));
            
            pb.Image = rotatedBmp;
        }
    }
}
