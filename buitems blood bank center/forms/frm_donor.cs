using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buitems_blood_bank_center.forms
{
    public partial class frm_donor : Form
    {
        public frm_donor()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            tb_byBloodType.Text = "";
            tb_byName.Text = "";
            by_date.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
