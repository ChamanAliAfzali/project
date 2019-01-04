using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace buitems_blood_bank_center.classes
{
    class Settings
    {
        dbConnection connection = new dbConnection();
        public int id { get; set; }
        public string name { get; set; }
        public string moto { get; set; }


        public void update()
        {
            try
            {
                SqlConnection c = connection.connect();
                string query = "update settings set appliationName=@name, applicationMotto=@moto where Id = '1'";
                SqlCommand cmd = new SqlCommand(query, c);
                cmd.Parameters.AddWithValue("@name", this.name);
                cmd.Parameters.AddWithValue("@moto", this.moto);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Error in updating settings");
            }
        }
        public DataTable getSettings()
        {
            DataTable dt;
            SqlConnection c = new SqlConnection();
            using (SqlDataAdapter da = new SqlDataAdapter("Select * from settings", c))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                c.Close();
                return dt;
            }
        }

    }
}
