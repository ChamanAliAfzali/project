using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace buitems_blood_bank_center.classes
{
    class Login
    {
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string Pass_word { get; set; }
        public string Con_Password { get; set; }

        dbConnection connection = new dbConnection();

        public void insertNewUser()
        {
            try
            {
                SqlConnection c = new SqlConnection("Data Source=DESKTOP-5IEG8HG;Initial Catalog=db_BloodBank;Integrated Security=True");
                c.Open();
                string sql = "insert into tbl_Login_Registerr(User_Id, User_Name, User_Pwd, User_Con_Pwd) values(@UserID,@UserName,@Password,@ConPassword)";

//              string sql = "Insert into tbl_Login_Registerr(User_Id,User_Name,User_Pwd,User_ConPwd) values(@UserID,@UserName,@Password,@ConPassword)";
                SqlCommand cmd = new SqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@UserId", User_Id);
                cmd.Parameters.AddWithValue("@UserName", User_Name);
                cmd.Parameters.AddWithValue("@Password", Pass_word);
                cmd.Parameters.AddWithValue("@ConPassword", Con_Password);
                
                cmd.ExecuteNonQuery(); // for moving data from app to db

                c.Close();
            }
            catch (System.Exception ex)
            {
                throw new Exception("Error Inserting New User", ex);
            }
        }
        
        public bool checkUser()
        {
            try
            {
                SqlConnection c = connection.connect();

                SqlCommand cmd = new SqlCommand("select count(*) from tbl_Login_Registerr where User_Name='" + this.User_Name + "' and User_Pwd='" + this.Pass_word + "'", c);
                int val = Int32.Parse(cmd.ExecuteScalar().ToString());
                c.Close();
                if (val > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("User Is Not Available");
            }

        }
        public string getId()
        {

            try
            {
                dbConnection con = new dbConnection();
                //con.d();
                SqlConnection c = connection.connect();

                SqlCommand cmd = new SqlCommand("select USER_ID from tbl_Login_Registerr where User_Name='" + this.User_Name + "' and User_pwd='" + this.Pass_word + "'", c);
                string val = cmd.ExecuteScalar().ToString();
                c.Close();
                return val;
            }
            catch (Exception ex)
            {
                throw new Exception("User Is Not Available");
            }

        }


        // selecting user
        //public DataTable LoginUser()
        //{
        //    DataTable dt;
        //    SqlConnection c = connection.connect();
        //    string query = "select * from tbl_Login/Register where FullName='" + this.FullName + "' and UserName='" + this.userName+"' and Password='"+this.Password+ "'  and ConPassword='" + this.ConPassword + "'  ";
        //    using (SqlDataAdapter da = new SqlDataAdapter(query, c))
        //       {
        //            DataSet ds = new DataSet();
        //            da.Fill(ds);
        //            dt = ds.Tables[0];
        //            c.Close();
        //            return dt;
        //        }
        //}
    }
}
