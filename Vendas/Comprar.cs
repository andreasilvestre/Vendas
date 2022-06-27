using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    internal class Comprar
    {
        int id_Produto;
        int quantidade;

        public int Id_Produto { get => id_Produto; set => id_Produto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public Comprar()
        {

        }
        public Comprar(int id_Produto, int quantidade)
        {
            Id_Produto = id_Produto;
            Quantidade = quantidade;
        }

        public bool alterarEstoque(int id_Produto, int quantidade)
        {


            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = $"update produto set estoque = estoque + {quantidade} where id_produto = {id_Produto};";

            try
            {
                command.ExecuteNonQuery();

                tran.Commit();
                return true;    
            }
            catch (Exception erro)
            {
                tran.Rollback();

                //verificação de erros
                MessageBox.Show("erro Fazendo Compras: " + erro);
                return false;
            }

            finally
            {
                banco.fecharConexao();
            }
        }
    }
}
