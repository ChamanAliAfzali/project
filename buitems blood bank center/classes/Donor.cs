using System;
using System.Data;
using System.Data.SqlClient;
namespace buitems_blood_bank_center.classes
{
    class Donor
    {
    //  public int DonorId { get; set; }
        public string donorName { get; set; }
        public int donorAge { get; set; }
        public string donorAddress { get; set; }
        public string donorPhone { get; set; }
        public string donorGender { get; set; }
        public string donorBloodType { get; set; }
        public bool donorRhType { get; set; } // bool: either + or -
  
        public string donorEmail { get; set; }
      
        public byte[] image { get; set; }

        dbConnection connection = new dbConnection();

        public void insertFreshDonor()
        {
            try
            {
                SqlConnection c = connection.connect();
                string sql = "Insert into tbl_Donor_details(DonorName,DonorAddress,DonorPhone,DonorAge,DonorEmail,DonorBloodType,DonorGender,DonorImage) values(@DonorName,@DonorAddress,@DonorPhone,@DonorAge,@DonorEmail,@DonorBloodType,@DonorGender,@image)";
                SqlCommand cmd = new SqlCommand(sql, c);
                cmd.Parameters.AddWithValue("@DonorName", this.donorName);
                cmd.Parameters.AddWithValue("@DonorAddress", this.donorAddress);
                cmd.Parameters.AddWithValue("@DonorPhone", this.donorPhone);
                cmd.Parameters.AddWithValue("@DonorAge", this.donorAge);
                cmd.Parameters.AddWithValue("@DonorEmail", this.donorEmail);
                cmd.Parameters.AddWithValue("@DonorBloodType", this.donorBloodType);
                cmd.Parameters.AddWithValue("@DonorGender", this.donorGender);
                cmd.Parameters.AddWithValue("@image", this.image);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw new Exception("Error Inserting New Donor",ex);
            }
        }

        public void updateDonor()
        {
            try
            {
                SqlConnection c = connection.connect();
              //  string sql = "update donor set DonorName=@DonorName,DonorAddress=@DonorAddress,DonorPhone=@DonorPhone,DonorImage=@image where DonorId='" + this.DonorId + "'";
                //SqlCommand cmd = new SqlCommand(sql, c);
                //cmd.Parameters.AddWithValue("@DonorName", this.donorName);
                //cmd.Parameters.AddWithValue("@DonorAddress", this.donorAddress);
                //cmd.Parameters.AddWithValue("@DonorPhone", this.donorPhone);
                //cmd.Parameters.AddWithValue("@image", this.image);
                //cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw new Exception("Error Inserting New Donor");
            }
        }
        public void deleteDonor()
        {
            try
            {
                SqlConnection c = connection.connect();
                string sql = "delete from donor where DonorId=@donorId";
                SqlCommand cmd = new SqlCommand(sql, c);
              //  cmd.Parameters.AddWithValue("@DonorId", this.DonorId);
                cmd.ExecuteNonQuery();
                c.Close();
            }
            catch (System.Exception ex)
            {
                throw new Exception("Error Deleting Donor");
            }
        }
        public DataTable getAllDonors()
        {
            DataTable dt;
            SqlConnection c = connection.connect();
            using (SqlDataAdapter da = new SqlDataAdapter("Select * from donor", c))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                c.Close();
                return dt;
            }
        }
        public DataTable getSpecificDonor()
        {
            DataTable dt;
            SqlConnection c = connection.connect();
           // using (SqlDataAdapter da = new SqlDataAdapter("Select * from donor where DonorId='" + this.DonorId + "'", c))
            {
                DataSet ds = new DataSet();
                //da.Fill(ds);
                dt = ds.Tables[0];
                c.Close();
                return dt;
            }
        }
        public DataTable searchByBGroup()
        {
            DataTable dt;
            SqlConnection c = connection.connect();
            //using (SqlDataAdapter da = new SqlDataAdapter("Select * from donor where DonorBloodType='" + this.donorBloodType + "'", c))
            {
                DataSet ds = new DataSet();
               // da.Fill(ds);
                dt = ds.Tables[0];
                c.Close();
                return dt;
            }
        }
        public DataTable searchDonor(string str)
        {
            DataTable dt;
            SqlConnection c = connection.connect();
            using (SqlDataAdapter da = new SqlDataAdapter("Select * from donor where DonorPhone like '%" + str + "%' OR DonorName like '%" + str + "%'", c))
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
