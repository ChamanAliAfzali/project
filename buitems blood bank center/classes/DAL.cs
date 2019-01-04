using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace buitems_blood_bank_center.classes
{
    class DAL
    {
        public DAL()
        {

        }
        public DataSet ds;
        public DataTable dt;

        public SqlConnection con;
        public SqlCommand cmdSQL;
        public SqlDataAdapter da;
        public SqlDataReader dr;

        //SQL Server
        public string conStringSQL = @"Data Source=DESKTOP-5IEG8HG;Initial Catalog=db_BloodBank;Integrated Security=True";

        //CRUD OPERATIONS
        public void CRUDsql(string cmd)
        {
            con = new SqlConnection(conStringSQL);
            con.Open();

            cmdSQL = con.CreateCommand();
            cmdSQL.CommandText = cmd;
            cmdSQL.ExecuteNonQuery();
            con.Close();
        }

        //SELECT record using SQL DB Dataset
        public DataSet GetDataSetSQL(string cmd, string table)
        {
            con = new SqlConnection(conStringSQL);
            da = new SqlDataAdapter(cmd, con);

            ds = new DataSet();

            //refreshes rows in the dataset
            da.Fill(ds, table);
            con.Close();
            return ds;
        }

        //SELECT record using SQL DataTable
        public DataTable GetDataTableSQL(string cmd, string table)
        {
            con = new SqlConnection(conStringSQL);

            da = new SqlDataAdapter(cmd, con);
            ds = new DataSet();

            // refreshes rows in dataset
            da.Fill(ds, table);
            con.Close();

            dt = ds.Tables[0];
            return dt;
        }
    }
}
