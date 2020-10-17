using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coletar_itens.Classes
{
    class Pausar
    {
        public Pausar(GroupBox menu, Timer time)
        {
            if(menu.Visible == false && time.Enabled == true)
            {
                menu.Visible = true;
                time.Enabled = false;
            }
            else
            {
                menu.Visible = false;
                time.Enabled = true;
            }
        }
    }
}
