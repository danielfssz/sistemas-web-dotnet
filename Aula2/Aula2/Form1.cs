using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Instancia a conexão(objeto SqlConnection)
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=aula2;Integrated Security=SSPI");
            //
                 
            // define um SqlDataReader nulo
            SqlDataReader dr =null;

            try
            {
                // 2. Abre a conexão
                conn.Open();
                // 3. Passa conexão para o objeto command
                SqlCommand cmd = new SqlCommand(); //("select * from login", conn);
                cmd.Connection = conn;
                cmd.CommandText = "select * from login";

                
                //
                // 4. Usa conexão
                // obtêm o resultado da consulta
                dr = cmd.ExecuteReader();
                // imprime o codigo do cliente para cada registro
                while (dr.Read())
                {
                    Console.WriteLine(dr["login"].ToString() + dr["Nome"].ToString());
                }
            }
            finally
            {
                // fecha o reader
                if (dr != null)
                {
                    dr.Close();
                }
                // 5. Fecha a conexão
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
