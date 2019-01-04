using buitems_blood_bank_center.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buitems_blood_bank_center.UserControls
{
    public partial class UC_DonorDetails : UserControl
    {
        public UC_DonorDetails()
        {
            InitializeComponent();
        }

        private void btn_AddDonor_Click(object sender, EventArgs e)
        {
            using (frm_donor donor = new frm_donor())
            {
                donor.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_request re = new frm_request();
            re.ShowDialog();
        }
    }
}
