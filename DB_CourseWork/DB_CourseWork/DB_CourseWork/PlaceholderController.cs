using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DB_CourseWork
{
    public static class PlaceholderController
    {
        public static void AddPlaceholder(this TextBox tb, string placeholder_txt)
        {
            tb.ForeColor = Color.Gray;
            tb.Text = placeholder_txt;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder_txt)
                {
                    tb.Text = String.Empty;
                    tb.ForeColor = Color.Black;
                }
            };

            tb.Leave += (s, e) => 
            {
                if (tb.Text == String.Empty)
                {
                    tb.ForeColor = Color.Gray; 
                    tb.Text = placeholder_txt;
                }
            };
        }
    }
}
