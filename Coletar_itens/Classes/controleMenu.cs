using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coletar_itens.Classes
{
    class controleMenu
    {
        public void VoltarGame(GroupBox menu, Timer time)
        {
            menu.Enabled = true;

            if(menu.Visible == true && time.Enabled == false)
            {
                menu.Visible = false;
                time.Enabled = true;
                menu.Enabled = true;
            }
            else
            {
                menu.Visible = true;
                time.Enabled = false;
                menu.Enabled = false;
            }


            if(menu.Visible == true)
            {
                menu.Enabled = true;
            }
            else
            {
                menu.Enabled = false;
            }
        }
    }
}
