using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coletar_itens.Classes
{
    class controleVida
    {
        public int vida = 10;

        public void Morrer(PictureBox player)
        {
            if(vida <= 0)
            {
                player.Visible = false;
            }
        }
    }
}
