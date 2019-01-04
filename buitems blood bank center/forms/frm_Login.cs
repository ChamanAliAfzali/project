using buitems_blood_bank_center.classes;
using buitems_blood_bank_center.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace buitems_blood_bank_center
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_signup register = new frm_signup();
            register.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
         if(string.IsNullOrWhiteSpace(tb_username.Text)==true)
            {
                tb_username.Focus();
                errorProvider_user.SetError(tb_username, "please fill the field");
            }
         else if(string.IsNullOrWhiteSpace(tb_Password.Text)==true)
            {
                tb_Password.Focus();
                errorProvider_pass.SetError(tb_Password, "please fill the field");
            }
         else
            {
                try
                {
                    string UserName = tb_username.Text;
                    string Password = tb_Password.Text;

                    Login login = new Login();
                    login.User_Name = UserName;
                    login.Pass_word = Password;

                    bool check = login.checkUser();

                    if (check)
                    {
                        Common.adminId = login.getId();
                        this.Hide();
                        frm_dashboard obj = new frm_dashboard();
                        obj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sorry You Are Not Allowed");
                    }
                    resetData();
                     MessageBox.Show("Done and Thank You");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }

        }
        public void resetData()
        {
            tb_username.Text = "";
            tb_Password.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if(tb_Password.isPassword==true)
            {tb_Password.isPassword = false;}
            else { tb_Password.isPassword = true; }
        }
    }
}
