using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace buitems_blood_bank_center.classes
{
    class dbConnection
    {
        SqlConnection connection;
        public dbConnection()
        {
            connection = new SqlConnection("Data Source=DESKTOP-5IEG8HG;Initial Catalog=db_BloodBank;Integrated Security=True");
        }
        public SqlConnection connect()
        {
            connection.Open();
            return connection;
        }
    }
}
