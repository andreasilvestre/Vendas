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
    internal class Produto
    {
        string nome;
        int codEAN;
        float preco;
        int estoque;

        public Produto(string nome, int codEAN, float preco, int estoque)
        {
            Nome = nome;
            CodEAN = codEAN;
            Preco = preco;
            Estoque = estoque;
        }


        public bool gravarProduto()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into produto values (@codEAN, @nome, @preco, @estoque);";
            command.Parameters.Add("@codEAN", SqlDbType.Int);
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Float);
            command.Parameters.Add("@estoque", SqlDbType.Int);
            command.Parameters[0].Value = this.CodEAN;
            command.Parameters[1].Value = this.Nome;
            command.Parameters[2].Value = this.Preco;
            command.Parameters[3].Value = this.Estoque;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception erro)
            {
                tran.Rollback();
                MessageBox.Show(this.Nome + this.Preco + erro);
                return false;

            }
            finally
            {
                banco.fecharConexao();
            }
        }

        public string Nome { get => nome; set => nome = value; }
        public int CodEAN { get => codEAN; set => codEAN = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Estoque { get => estoque; set => estoque = value; }
    }
}
