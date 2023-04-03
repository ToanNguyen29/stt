using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02.tool
{
    internal interface IDocument
    {
        void Print(DataGridView dataGridView);
    }
}
