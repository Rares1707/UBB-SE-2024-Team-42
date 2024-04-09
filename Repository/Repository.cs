using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UBB_SE_2024_Team_42.Repository
{
    public class Repository
    {
        private string sqlConnectionString;

        // no other fields required
        // when you need something, just create public functions which insert/update/retrieve data directly
        // from the database by calling functions/procedures DEFINED IN THE DB

        public Repository(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString;
        }
        
    }
}
