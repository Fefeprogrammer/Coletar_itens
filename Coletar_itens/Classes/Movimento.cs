using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Coletar_itens.Classes
{
    class Movimento
    {
        public void Up(PictureBox obj, int speed)
        {
            obj.Location = new Point(obj.Location.X, obj.Location.Y - speed);
        }

        public void Down(PictureBox obj, int speed)
        {
            obj.Location = new Point(obj.Location.X, obj.Location.Y + speed);
        }

        public void Rigth(PictureBox obj, int speed)
        {
            obj.Location = new Point(obj.Location.X + speed, obj.Location.Y);
        }

        public void Left(PictureBox obj, int speed)
        {
            obj.Location = new Point(obj.Location.X - speed, obj.Location.Y);
        }
    }
}
