using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Coletar_itens.DAO
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-EBULI8S\SQLEXPRESS;Initial Catalog=Game;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
