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
    internal class Vender
    {
        int id_Venda;
        int id_Cliente;
        float valorTotalVenda;

        int id_Produto;
        float valorUnitario;
        int quantidade;
        float valorTotalItem;

        
        public Vender()
        {
        }

        public Vender(int id_Cliente, float valorTotalVenda, int id_Produto, float valorUnitario, int quantidade, float valorTotalItem)
        {
            //this.id_Venda = id_Venda;
            this.id_Cliente = id_Cliente;
            this.valorTotalVenda = valorTotalVenda;
            this.id_Produto = id_Produto;
            this.valorUnitario = valorUnitario;
            this.quantidade = quantidade;
            this.valorTotalItem = valorTotalItem;
        }

        public bool gravarVenda(int id_ClienteSelecionado, float valorVenda)
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand(); 

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into Venda values (@id_Cliente, @ValorTotal);";

            command.Parameters.Add("@id_cliente", SqlDbType.Int);
            command.Parameters.Add("@ValorTotal", SqlDbType.Float);
            command.Parameters[0].Value = id_ClienteSelecionado;
            command.Parameters[1].Value = valorVenda;

          
            try
            {
                command.ExecuteNonQuery();
                tran.Commit();

                //não funcionou - colaboradores Alan Capelari/Leonardo Bertinatti
                //this.Id_Venda = int.Parse(command.ExecuteScalar().ToString());
                //this.Id_Venda = (int)command.ExecuteScalar();

                return true;
            }
            catch (Exception erro)
            {
                //testes
                MessageBox.Show("erro gravarVenda: " + erro);
                tran.Rollback();
                return false;

            }

            finally
            {
                banco.fecharConexao();
            }

        }

        public void buscarIdVenda()
        {

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "select max(Id_Venda) as Id_Venda from Venda;";

            try
            {
                SqlDataReader leitor = command.ExecuteReader();
                leitor.Read();

                //guarda o id da venda para gravar os itens de venda
                this.Id_Venda = int.Parse(leitor["Id_Venda"].ToString());

            }
            catch (Exception erro)
            {
                //throw;
                MessageBox.Show("erro buscar id_venda: " + erro);

            }

            finally
            {
                banco.fecharConexao();
            }
        }


        public bool gravarItensVenda(List<Vender> listaItensVenda)
        {

            foreach (Vender i in listaItensVenda)
            {

                Banco banco = new Banco();
                SqlConnection cn = banco.abrirConexao();

                SqlTransaction tran = cn.BeginTransaction();
                SqlCommand command = new SqlCommand();

                command.Connection = cn;
                command.Transaction = tran;
                command.CommandType = CommandType.Text;

                //novo jeito de fazer insert - redução de código - ver com professor solução mais enxuta de código
                //command.CommandText = $"Insert into ItemVenda values ({this.Id_Venda}, {i.Id_Produto}, {i.ValorUnitario}, {i.Quantidade}, {i.valorTotalItem});";

                command.CommandText = "Insert into ItemVenda values (@id_Venda, @Id_Produto, @ValorUnitario, @Quantidade, @ValorTotal);";

                command.Parameters.Add("@id_Venda", SqlDbType.Int);
                command.Parameters.Add("@id_Produto", SqlDbType.Int);
                command.Parameters.Add("@ValorUnitario", SqlDbType.Float);
                command.Parameters.Add("@Quantidade", SqlDbType.Int);
                command.Parameters.Add("@ValorTotal", SqlDbType.Float);

                //command.Parameters[0].Value = i.id_Venda;
                command.Parameters[0].Value = this.Id_Venda;
                command.Parameters[1].Value = i.Id_Produto;
                command.Parameters[2].Value = i.ValorUnitario;
                command.Parameters[3].Value = i.Quantidade;
                command.Parameters[4].Value = i.ValorTotalItem;

                try
                {
                    command.ExecuteNonQuery();

                    tran.Commit();
                }
                catch (Exception erro)
                {
                    tran.Rollback();

                    //verificação de erros
                    MessageBox.Show("Id_venda= " + this.Id_Venda.ToString());
                    MessageBox.Show("erro gravarItensVenda: " + erro);

                }

                finally
                {
                    banco.fecharConexao();
                }

            }
            alterarEstoque(listaItensVenda);
            return true;

        }
        public bool alterarEstoque(List<Vender> listaItensVenda)
        {

            foreach (Vender i in listaItensVenda)
            {

                Banco banco = new Banco();
                SqlConnection cn = banco.abrirConexao();

                SqlTransaction tran = cn.BeginTransaction();
                SqlCommand command = new SqlCommand();

                command.Connection = cn;
                command.Transaction = tran;
                command.CommandType = CommandType.Text;

                command.CommandText =$"update produto set estoque = estoque - {i.Quantidade} where id_produto = {i.Id_Produto};";

                //para deletar
                //command.CommandText = "Delete from usuario where idUsuario=@idUsuario;";
                //command.Parameters.AddWithValue("@idUsuario", idUsuario);

                try
                {
                    command.ExecuteNonQuery();

                    tran.Commit();
                }
                catch (Exception erro)
                {
                    tran.Rollback();

                    //verificação de erros
                    MessageBox.Show("erro alterar Estoque: " + erro);

                }

                finally
                {
                    banco.fecharConexao();
                }

            }
            return true;

        }


        public int Id_Venda { get => id_Venda; set => id_Venda = value; }
        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public float ValorTotalVenda { get => valorTotalVenda; set => valorTotalVenda = value; }
        public int Id_Produto { get => id_Produto; set => id_Produto = value; }
        public float ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public float ValorTotalItem { get => valorTotalItem; set => valorTotalItem = value; }
    }
}
