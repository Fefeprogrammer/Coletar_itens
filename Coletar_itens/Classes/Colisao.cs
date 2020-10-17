using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace Coletar_itens.Classes
{
    class Colisao
    {
        Score score = new Score();
        public int x = 0;

        public void Coll(PictureBox obj1, PictureBox obj2, SoundPlayer audio)
        {
            if(obj1.Location.X >= obj2.Location.X - obj2.Size.Width + 5
                &&
                obj1.Location.X <= obj2.Location.X + obj2.Size.Width - 5
                &&
                obj1.Location.Y >= obj2.Location.Y - obj2.Size.Height + 5
                &&
                obj1.Location.Y <= obj2.Location.Y + obj2.Size.Height - 5
                &&
                obj2.Visible == true
                )
            {
                obj2.Visible = false;
                audio.Play();
                x++;
            }
        }
    }
}
