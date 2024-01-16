using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

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
    }
}
