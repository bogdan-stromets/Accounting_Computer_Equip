﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CourseWork.Misc
{
    class DoubleBufferedDataGridView : DataGridView
    {
        protected override bool DoubleBuffered { get => true; }
    }
}