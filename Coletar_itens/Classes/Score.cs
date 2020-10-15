using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coletar_itens.Classes
{
    class Score
    {
        public int pontos = 0;

        public void Scored(Label lb)
        {
            lb.Text = this.pontos.ToString();
        }
    }
}
