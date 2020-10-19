using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Coletar_itens.DAO
{
    class Restaurar
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        public SqlDataReader dados;

        public void Buscar(int score, int nivel)
        {
            con.Conectar();
            cmd.CommandText = "SELECT * FROM Progresso WHERE score = @Score and nivel = @Nivel";

            cmd.Parameters.AddWithValue("@Score", score);
            cmd.Parameters.AddWithValue("@Nivel", nivel);

            try
            {
                cmd.Connection = con.Conectar();
                dados = cmd.ExecuteReader();
            }catch(SqlException e)
            {
                this.mensagem = "Erro: " + e;
            }
        }
    }
}
