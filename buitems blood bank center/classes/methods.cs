using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace buitems_blood_bank_center.classes
{
    class methods
    {
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
              //  SqlConnection;
            }
            catch(Exception)
            {

            }
        }
    }
}
