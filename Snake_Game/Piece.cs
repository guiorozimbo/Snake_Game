using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    class Piece: System.Windows.Forms.Label
    {
        public Piece(int x,int y)
        {

            Location = new System.Drawing.Point(x, y);
            Size = new System.Drawing.Size(21, 21);
            BackColor = System.Drawing.Color.Orange;
            Enabled = false;
        }
    }
}
