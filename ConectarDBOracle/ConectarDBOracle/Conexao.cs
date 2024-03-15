using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConectarDBOracle
{
    internal class Conexao
    {
        //declarar atributos..
        //protected -> somente pode ser acessado por herança
        //protected OleDbCommand Cmd;       //executar comandos SQL
        //protected OleDbDataReader Dr;     //Ler dados de consultas 
        //protected OleDbTransaction Tr;    //Transações em banco de dados (commit/rollback)

        //declarar os metodos..
        /*public void AbrirConexao() //conexão...
        {
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;Data Source=ODA_TESTE;USer ID=co_tortuga;Password=coteste*9)");
            Con.Open(); //conexão aberta!
        }

        public void FecharConexao() //desconectar...
        {
            Con.Close(); //conexão fechada!
        }*/
    }
}
