using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BD
{
    internal class bd
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-31KS4TM;Initial Catalog=puzzle game;Integrated Security=true");

        public void openconected()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void Closeconected()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getbd() {  return sqlConnection; }

    }
}
