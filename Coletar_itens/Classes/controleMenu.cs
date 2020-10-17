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
            if(menu.Visible == true && time.Enabled == false && menu.Enabled == true)
            {
                menu.Visible = false;
                menu.Enabled = false;
                time.Enabled = true;
            }
            else
            {
                menu.Enabled = true;
                menu.Visible = true;
                time.Enabled = false;
            }
        }
    }
}
