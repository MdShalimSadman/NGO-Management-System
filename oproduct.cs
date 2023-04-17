using ClassLibrary1.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.operations
{
    public class Oproduct
    {
        public void insert(Eproduct eproduct)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=USER-PC;Initial Catalog=ProductDB_K;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into product(name) values('"+eproduct.name+"')",connection);
            command.ExecuteNonQuery();
        }
    }
}
