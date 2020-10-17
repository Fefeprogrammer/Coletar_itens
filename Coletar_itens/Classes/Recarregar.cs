using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Coletar_itens.Classes
{
    class Recarregar
    {
        public void Reload(PictureBox obj1, PictureBox obj2, PictureBox obj3, PictureBox obj4, PictureBox obj5, PictureBox obj6,
        PictureBox obj7, PictureBox obj8, PictureBox obj9, PictureBox obj10, PictureBox obj11, PictureBox player, PictureBox over, Button reload)
        {
            Random randX = new Random();
            Random randY = new Random();
            int minY = 0;
            int minX = 0;
            int maxY = 1;
            int maxX = 1;

            player.Visible = true;
            over.Visible = false;
            reload.Visible = false;
            PictureBox[] obj = new PictureBox[11] { obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11 };

            for(int x=0; x<obj.Length; x++)
            {
                obj[x].Location = new Point(obj[x].Location.X + randX.Next(minX, maxX), obj[x].Location.Y + randY.Next(minY, maxY));
            }

            for(int x=0; x<obj.Length; x++)
            {
                obj[x].Visible = true;
            }
        }
    }
}
