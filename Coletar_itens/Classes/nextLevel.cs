using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Coletar_itens.Classes
{
    class nextLevel
    {
        private bool passou;
        public int level = 1;
        public int tempo = 20;

        public void ChegarGanhos(PictureBox obj1, PictureBox obj2, PictureBox obj3, PictureBox obj4, PictureBox obj5, PictureBox obj6,
            PictureBox obj7, PictureBox obj8, PictureBox obj9, PictureBox obj10, PictureBox obj11, Label temporizador, Label nivel)
        {
            if(obj1.Visible == false && obj2.Visible == false && obj3.Visible == false && obj4.Visible == false && obj5.Visible == false &&
                obj6.Visible == false && obj7.Visible == false && obj8.Visible == false && obj9.Visible == false && obj10.Visible == false &&
                obj11.Visible == false)
            {
               
                setPassou(true);

                nivel.Text = $"Level: {this.level.ToString()}";

                if (getPassou() == true)
                {
                    obj1.Visible = true;
                    obj2.Visible = true;
                    obj3.Visible = true;
                    obj4.Visible = true;
                    obj5.Visible = true;
                    obj6.Visible = true;
                    obj7.Visible = true;
                    obj8.Visible = true;
                    obj9.Visible = true;
                    obj10.Visible = true;
                    obj11.Visible = true;

                    level++;
                    tempo = 20;

                    GerarNivel(obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11);
                }
            }
        }

        public bool getPassou()
        {
            return this.passou;
        }

        public void setPassou(bool passou)
        {
            this.passou = passou;
        }

        private void GerarNivel(PictureBox obj1, PictureBox obj2, PictureBox obj3, PictureBox obj4, PictureBox obj5, PictureBox obj6,
            PictureBox obj7, PictureBox obj8, PictureBox obj9, PictureBox obj10, PictureBox obj11)
        {
            if(getPassou() == true)
            {
                Random randX = new Random();
                Random randY = new Random();
                int minY = 0;
                int minX = 0;
                int maxY = 10;
                int maxX = 10;

                obj1.Location = new Point(obj1.Location.X + randX.Next(minX, maxX), obj1.Location.Y + randY.Next(minY, maxY));
                obj2.Location = new Point(obj2.Location.X + randX.Next(minX, maxX), obj2.Location.Y + randY.Next(minY, maxY));
                obj3.Location = new Point(obj3.Location.X + randX.Next(minX, maxX), obj3.Location.Y + randY.Next(minY, maxY));
                obj4.Location = new Point(obj4.Location.X + randX.Next(minX, maxX), obj4.Location.Y + randY.Next(minY, maxY));
                obj5.Location = new Point(obj5.Location.X + randX.Next(minX, maxX), obj5.Location.Y + randY.Next(minY, maxY));
                obj6.Location = new Point(obj6.Location.X + randX.Next(minX, maxX), obj6.Location.Y + randY.Next(minY, maxY));
                obj7.Location = new Point(obj7.Location.X + randX.Next(minX, maxX), obj7.Location.Y + randY.Next(minY, maxY));
                obj8.Location = new Point(obj8.Location.X + randX.Next(minX, maxX), obj8.Location.Y + randY.Next(minY, maxY));
                obj9.Location = new Point(obj9.Location.X + randX.Next(minX, maxX), obj9.Location.Y + randY.Next(minY, maxY));
                obj10.Location = new Point(obj10.Location.X + randX.Next(minX, maxX), obj10.Location.Y + randY.Next(minY, maxY));
                obj11.Location = new Point(obj11.Location.X + randX.Next(minX, maxX), obj11.Location.Y + randY.Next(minY, maxY));
            }
        }
    }
}
