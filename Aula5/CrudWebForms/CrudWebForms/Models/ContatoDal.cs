using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CrudWebForms.Models
{
    public class ContatoDAL
    {
        public static DataSet GetContatos()
        {
            SqlConnection con = new SqlConnection(AcessoDal.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("CarregarDados", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds, "contatos");
            return ds;
        }

        public static Contato GetContato(int codigo)
        {
            SqlConnection con = new SqlConnection(AcessoDal.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("getContato", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", codigo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Contato ct = new Contato();
                    ct.Nome = dr["nome"].ToString();
                    ct.Email = dr["email"].ToString();
                    ct.Idade = Int32.Parse(dr["idade"].ToString());
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

        public void incluirContato(Contato contato)
        {
            SqlConnection con = new SqlConnection(AcessoDal.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InserirDados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", contato.Nome);
                cmd.Parameters.AddWithValue("@email", contato.Email);
                cmd.Parameters.AddWithValue("@idade", contato.Idade);
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

        public static string deletarContato(int codigo)
        {
            SqlConnection con = new SqlConnection(AcessoDal.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DeletarDados", con);
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

        public static string atualizarContato(Contato contato)
        {
            SqlConnection con = new SqlConnection(AcessoDal.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("AtualizarDados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", contato.Codigo);
                cmd.Parameters.AddWithValue("@nome", contato.Nome);
                cmd.Parameters.AddWithValue("@email", contato.Email);
                cmd.Parameters.AddWithValue("@idade", contato.Idade);
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