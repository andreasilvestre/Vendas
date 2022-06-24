using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms; //testes

namespace Vendas
{
    internal class Cliente
    {
        //ID(PK)
        string nome;
        string cpf;
        string telefone;
        string email;

        public Cliente(string nome, string cpf, string telefone, string email)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.Email = email;
        }

        public bool gravarCliente()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into cliente values (@nome, @cpf, @telefone, @email);";
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = this.Nome;
            command.Parameters[1].Value = this.Cpf;
            command.Parameters[2].Value = this.Telefone;
            command.Parameters[3].Value = this.Email;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception erro)
            {
                tran.Rollback();
                MessageBox.Show(this.Nome + this.Cpf + erro);
                return false;

            }
            finally
            {
                banco.fecharConexao();
            }
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
    }
}
