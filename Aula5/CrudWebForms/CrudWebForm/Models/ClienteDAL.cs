using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CrudWebForm.Models
{
    public class ClienteDAL
    {
        public static DataSet GetContatos()
        {
            SqlConnection con = new SqlConnection(AcessoDB.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("carregarClientes", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            return ds;
        }

        public static Cliente GetCliente(int codigo)
        {
            SqlConnection con = new SqlConnection(AcessoDB.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("getCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", codigo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Cliente ct = new Cliente();
                    ct.Nome = dr["nome"].ToString();
                    ct.Codigo = dr["codigo"].ToString();
                    ct.DataCriacao = DateTime.Parse(dr["dataCadastro"].ToString());
                    return ct;
                }
                else
                    return null;
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

        public void incluirCliente(Cliente cliente)
        {
            SqlConnection con = new SqlConnection(AcessoDB.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("inserirCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", cliente.Codigo);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@dataCadastro", cliente.DataCriacao);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;  // retorna mensagem de erro
            }
            finally
            {
                con.Close();
            }
        }
        public static string deletarCliente(int codigo)
        {
            SqlConnection con = new SqlConnection(AcessoDB.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("deletarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
                return null; // success 
            }
            catch (Exception ex)
            {
                throw ex;  // retorna mensagem de erro
            }
            finally
            {
                con.Close();
            }
        }
        public static string atualizarCliente(Cliente cliente)
        {
            SqlConnection con = new SqlConnection(AcessoDB.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("atualizarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", cliente.Codigo);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@dataCadastro", cliente.DataCriacao);                
                cmd.ExecuteNonQuery();
                return null; // success 
            }
            catch (Exception ex)
            {
                throw ex;  // retorna mensagem de erro
            }
            finally
            {
                con.Close();
            }
        }
    }
}