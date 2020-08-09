using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Projeto
{
    class DataBase
    {
        // Esta é a classe que realiza a conexão com o banco de dados
        /* 
            Aqui estão contidos os métodos para realizar ações no banco,
            Insert, Delete, Uptade e Select
        */  

        private string ConnectionString = "server=localhost;database=projeto;uid=root;pwd=''";
        private MySqlConnection conexao;


        public DataBase()
        {

            conexao = new MySqlConnection(ConnectionString);
            conexao.Open();
            
        }

        private void ExecuteNonQuery(String sql)
        {

            var cmd = new MySqlCommand(sql, conexao);
            cmd.ExecuteNonQuery();

        }

        private DataTable ExecuteDataAdapter(String sql)
        {
            var cmd = new MySqlCommand(sql, conexao);

            var dataTable = new DataTable();

            using (var adapter = new MySqlDataAdapter(cmd))
            {
                
                var dataSet = new DataSet();
                adapter.Fill(dataSet);

                dataTable = dataSet.Tables[0];

            }


            return dataTable;
        }

        private MySqlDataReader ExecuteReader(String sql)
        {
            var cmd = new MySqlCommand(sql, conexao);
            
            var leitor = cmd.ExecuteReader();

            return leitor;
        }

        public void ExecutarInsert(String sql)
            => ExecuteNonQuery(sql);

        public void ExecutarDelete(String sql)
            => ExecuteNonQuery(sql);

        public void ExecutarUpdate(String sql)
            => ExecuteNonQuery(sql);

        public DataTable ExecutarSelect(String sql)
            => ExecuteDataAdapter(sql);

        public MySqlDataReader ExecutarReader(String sql)
            => ExecuteReader(sql);

        public void Open()
        {
            conexao.Open();
        }

        public void Close()
        {
            conexao.Close();
        }
    }
}
