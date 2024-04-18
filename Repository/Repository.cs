using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UBB_SE_2024_Team_42.Repository
{
    public class Repository
    {
        private string sqlConnectionString = "Data Source=CamFrigLaCluj;Initial Catalog=Team42DB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        // no other fields required
        // when you need something, just create public functions which insert/update/retrieve data directly
        // from the database by calling functions/procedures DEFINED IN THE DB

        public Repository(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }

        public void getAllUsers()
        {
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("select * from dbo.getAllUsers()\r\n", connection);
            //command.CommandType = System.Data.CommandType.Func
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            dataAdapter.Fill(data);

            //now make a list of Users and return it
            //string str = data.Rows[0][0].ToString();
            //Console.WriteLine(str);
        }
        
    }
}
