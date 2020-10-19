using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Coletar_itens.DAO
{
    class Atualizar
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        string mensagem = "";

        public void Checar(int score, int nivel)
        {
            con.Conectar();
            cmd.CommandText = "UPDATE SET ";
        }

    }
}
