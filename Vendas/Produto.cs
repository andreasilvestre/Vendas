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
        int id_Produto;

        public Produto(string nome, int codEAN, float preco, int estoque)
        {
            Nome = nome;
            CodEAN = codEAN;
            Preco = preco;
            Estoque = estoque;
        }

        /// <summary>
        /// Este construtor (polimorfismo) foi necessário criar para buscar do banco de dados todos os valores, inclusive o id_Produto
        /// a diferença do construtor acima é o id_Produto
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="codEAN"></param>
        /// <param name="preco"></param>
        /// <param name="estoque"></param>
        /// <param name="id_Produto"></param>
        public Produto(string nome, int codEAN, float preco, int estoque, int id_Produto)
        {
            Nome = nome;
            CodEAN = codEAN;
            Preco = preco;
            Estoque = estoque;
            Id_Produto = id_Produto;
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

        public static List<Produto> gerarListaProdutos()
        {

            List<Produto> listaProdutos = new List<Produto>();

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from produto where estoque > 0 order by nome;";

            try
            {
                SqlDataReader leitor = command.ExecuteReader();

                //MessageBox.Show("Conexão ok");

                while (leitor.Read())
                {
                    // sem o id_Produto por enquanto - pendencia - na fila
                    listaProdutos.Add(new Produto(leitor["nome"].ToString(), int.Parse(leitor["codEAN"].ToString()), float.Parse(leitor["preco"].ToString()), int.Parse(leitor["estoque"].ToString()), int.Parse(leitor["id_Produto"].ToString())));
                }
            }
            catch (Exception erro)
            {
                //throw;
                MessageBox.Show("Erro: " + erro);
            }

            finally
            {
                banco.fecharConexao();
            }
            return listaProdutos;
        }

        public string Nome { get => nome; set => nome = value; }
        public int CodEAN { get => codEAN; set => codEAN = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Estoque { get => estoque; set => estoque = value; }
        public int Id_Produto { get => id_Produto; set => id_Produto = value; }
    }
}
