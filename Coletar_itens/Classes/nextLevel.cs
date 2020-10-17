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

                PictureBox[] obj = new PictureBox[11] { obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11 };

                if (getPassou() == true)
                {
                    GerarNivel(obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11);

                    for(int x=0; x<obj.Length; x++)
                    {
                        obj[x].Visible = true;
                    }

                    level++;
                    tempo = 20;

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

                PictureBox[] obj = new PictureBox[11] {obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11 };

                for(int x=0; x<obj.Length; x++)
                {
                    obj[x].Location = new Point(obj[x].Location.X + randX.Next(minX, maxX), obj[x].Location.Y + randX.Next(minY, maxY));
                }
            }
        }
    }
}
