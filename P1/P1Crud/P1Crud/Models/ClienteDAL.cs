using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace P1Crud.Models
{
    public class ClienteDAL
    {
        //INSERIR_CLIENTE
        public void insereCliente(Cliente cliente)
        {
            SqlConnection con = new SqlConnection(AcessoDAL.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERIR_CLIENTE", con);
                cmd.CommandType = CommandType.StoredProcedure;

                /* Defino valores do cliente */                
                cmd.Parameters.AddWithValue("@NOME", cliente.Nome);
                cmd.Parameters.AddWithValue("@EMAIL", cliente.Email);
                cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);
                cmd.Parameters.AddWithValue("@RG", cliente.Rg);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@LOGRADOURO", cliente.Logradouro);
                cmd.Parameters.AddWithValue("@CEP", cliente.Cep);
                cmd.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
                cmd.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);

                SqlDataReader dr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }            
        }

        //ATUALIZAR_CLIENTE
        public void atualizaCliente (Cliente cliente)
        {
            SqlConnection con = new SqlConnection(AcessoDAL.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ATUALIZAR_CLIENTE", con);
                cmd.CommandType = CommandType.StoredProcedure;

                /* Defino valores do cliente */
                cmd.Parameters.AddWithValue("@ID", cliente.Id);
                cmd.Parameters.AddWithValue("@NOME", cliente.Nome);
                cmd.Parameters.AddWithValue("@EMAIL", cliente.Email);
                cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);
                cmd.Parameters.AddWithValue("@RG", cliente.Rg);
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@LOGRADOURO", cliente.Logradouro);
                cmd.Parameters.AddWithValue("@CEP", cliente.Cep);
                cmd.Parameters.AddWithValue("@CIDADE", cliente.Cidade);
                cmd.Parameters.AddWithValue("@BAIRRO", cliente.Bairro);

                SqlDataReader dr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        //EXCLUIR_CLIENTE
        public void excluiCliente(Cliente cliente)
        {
            SqlConnection con = new SqlConnection(AcessoDAL.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("EXCLUIR_CLIENTE", con);
                cmd.CommandType = CommandType.StoredProcedure;

                /* Defino valores do cliente */
                cmd.Parameters.AddWithValue("@ID", cliente.Id);
                
                SqlDataReader dr = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        //SELECIONAR_CLIENTE
        public Cliente selecionarCliente(int id)
        {
            SqlConnection con = new SqlConnection(AcessoDAL.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECIONAR_CLIENTE", con);
                cmd.CommandType = CommandType.StoredProcedure;

                /* Defino valores do cliente */
                cmd.Parameters.AddWithValue("@ID", id);

                SqlDataReader dr = cmd.ExecuteReader();

                Cliente cliente = new Cliente();
                while (dr.Read())
                {                    
                    cliente.Id = int.Parse(dr["ID"].ToString());
                    cliente.Nome = dr["NOME"].ToString();
                    cliente.Email= dr["EMAIL"].ToString();
                    cliente.Cpf = dr["CPF"].ToString();
                    cliente.Rg = dr["RG"].ToString();
                    cliente.DataNascimento= Convert.ToDateTime(dr["DATA_NASCIMENTO"].ToString());
                    cliente.Logradouro= dr["LOGRADOURO"].ToString();
                    cliente.Cep= dr["CEP"].ToString();
                    cliente.Cidade= dr["CIDADE"].ToString();
                    cliente.Bairro = dr["BAIRRO"].ToString();
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        //SELECIONAR_CLIENTES
        public List<Cliente> selecionarClientes()
        {
            SqlConnection con = new SqlConnection(AcessoDAL.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECIONAR_CLIENTES", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                List<Cliente> listCliente = new List<Cliente>();
                while (dr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = int.Parse(dr["ID"].ToString());
                    cliente.Nome = dr["NOME"].ToString();
                    cliente.Email = dr["EMAIL"].ToString();
                    cliente.Cpf = dr["CPF"].ToString();
                    cliente.Rg = dr["RG"].ToString();
                    cliente.DataNascimento = Convert.ToDateTime(dr["DATA_NASCIMENTO"].ToString());
                    cliente.Logradouro = dr["LOGRADOURO"].ToString();
                    cliente.Cep = dr["CEP"].ToString();
                    cliente.Cidade = dr["CIDADE"].ToString();
                    cliente.Bairro = dr["BAIRRO"].ToString();
                    listCliente.Add(cliente);
                }
                return listCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}