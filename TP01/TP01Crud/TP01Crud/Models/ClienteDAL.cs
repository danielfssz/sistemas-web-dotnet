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

                if (operacao == "SEL" && cliente == null)
                {
                    cliente = new Cliente(0);
                }

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


                List<Cliente> listCliente = new List<Cliente>();

                while (dr.Read())
                {
                    Cliente ct = new Cliente();
                    ct.Id = int.Parse(dr["id"].ToString());
                    ct.NomeFantasia = dr["Nome_Fantasia"].ToString();
                    ct.RazaoSocial = dr["Razao_Social"].ToString();
                    ct.CNPJ = dr["Cnpj"].ToString();
                    ct.Rua = dr["Rua"].ToString();
                    ct.CEP = dr["Cep"].ToString();
                    ct.Bairro = dr["Bairro"].ToString();
                    ct.Cidade = dr["Cidade"].ToString();
                    ct.Estado = dr["Estado"].ToString();

                    listCliente.Add(ct);                    
                }

                if (operacao == "SEL" && cliente.Id == 0) // List
                {
                    return listCliente;
                }
                else if (operacao == "SEL" && cliente != null) // Get cliente
                {
                    Cliente c = listCliente[0];
                    return c;
                }
                else if (operacao == "UPD" || operacao == "DEL")
                {   
                    return null;
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

            return null;
        }
    }
}