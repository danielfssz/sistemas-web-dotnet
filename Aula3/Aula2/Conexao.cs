using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Aula2
{
    class Conexao
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=aula2;Integrated Security=SSPI");
        SqlCommand cmd = null;
        SqlDataAdapter da = new SqlDataAdapter();

         
        public void Abrir() {
            conn.Open();
        }

        public void Fechar() {
            conn.Close();
        }


        public SqlDataReader retornaDataReader(String sql) {

            try
            {
                SqlDataReader dr; //Objeto que receberá os dados do banco de dados
                SqlCommand cmd = new SqlCommand(); //Comando sql
                cmd.Connection = conn;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();

                return dr;
            }
            catch (Exception ex) {
                throw ex;
            }
 
        }

        public DataSet retornaDataset (String sql)
        {

            try
            {
                DataSet ds=new DataSet(); //Objeto que receberá os dados do banco de dados
                SqlCommand cmd = new SqlCommand(); //Comando sql
                cmd.Connection = conn;
                cmd.CommandText = sql;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(ds,"MinhaTabela");

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}

