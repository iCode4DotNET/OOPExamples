using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndPoint_Part05.CustomControl
{
    public class SuccessButton : Button
    {
        public SuccessButton()
        {
            BackColor = Color.Green;
            Cursor = Cursors.Hand;
        }
    }
}
