using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coletar_itens.Classes
{
    class gameOver
    {
        public int tempo = 20;

        public gameOver(PictureBox player, PictureBox gameOver, Button rec, string tempo)
        {
            player.Visible = false;
            gameOver.Visible = true;
            rec.Visible = true;
            tempo = "20";
        }
    }
}
