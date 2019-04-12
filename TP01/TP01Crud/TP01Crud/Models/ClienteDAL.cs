using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP01Crud.Models
{
    public class ClienteDAL
    {
        public Object ExecutaOperacao(Cliente cliente, string operacao)
        {
            SqlConnection con = new SqlConnection(AcessoDAL.ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_manutencao_cliente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                /* Defino valores do cliente */
                cmd.Parameters.AddWithValue("@id", cliente.Id);
                cmd.Parameters.AddWithValue("@nome", cliente.NomeFantasia);
                cmd.Parameters.AddWithValue("@razao", cliente.RazaoSocial);
                cmd.Parameters.AddWithValue("@cnpj", cliente.CNPJ);
                cmd.Parameters.AddWithValue("@rua", cliente.Rua);
                cmd.Parameters.AddWithValue("@cep", cliente.CEP);
                cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@acao", operacao);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Cliente ct = new Cliente();
                    cliente.Id = int.Parse(dr["id"].ToString());
                    cliente.NomeFantasia = dr["nome"].ToString();
                    cliente.RazaoSocial = dr["razao"].ToString();
                    cliente.CNPJ = dr["cnpj"].ToString();
                    cliente.Rua = dr["rua"].ToString();
                    cliente.CEP = dr["cep"].ToString();
                    cliente.Bairro = dr["bairro"].ToString();
                    cliente.Cidade = dr["cidade"].ToString();
                    cliente.Estado = dr["estado"].ToString();                   

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

            return null;
        }
    }
}