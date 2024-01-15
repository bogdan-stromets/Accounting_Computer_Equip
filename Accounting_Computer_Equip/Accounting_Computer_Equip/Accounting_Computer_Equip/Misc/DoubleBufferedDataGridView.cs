using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Computer_Equip.Misc
{
    class DoubleBufferedDataGridView : DataGridView
    {
        protected override bool DoubleBuffered { get => true; }
    }
}
