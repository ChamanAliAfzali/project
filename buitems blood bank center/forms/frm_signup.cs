using buitems_blood_bank_center.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace buitems_blood_bank_center.forms
{
    public partial class frm_signup : Form
    {
      //string passpattern = @"(>=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        public frm_signup()
        {
            InitializeComponent();
            
        }

        private void tb_pass_Leave(object sender, EventArgs e)
        {
        //    if (Regex.IsMatch(tb_pass.Text, passpattern) == false)
        //    {
        //        tb_pass.Focus();
        //        errorProvider_pass.SetError(tb_pass, "Uppercase,lowercase, symbols,numbers");
        //    }
        //    else
        //    {
        //        errorProvider_pass.Clear();
        //    }
        }

        private void tb_Cpass_Leave(object sender, EventArgs e)
        {
            if (tb_pwd.Text != tb_conpwd.Text)
            {
                tb_conpwd.Focus();
                errorProvider_Cpass.SetError(tb_conpwd, "passwords do not match");
            }
            else
            {
                errorProvider_Cpass.Clear();
            }
        } 
  
        private void btn_Register_Click(object sender, EventArgs e)
        {
           
        }
        public void resetData()
        {
            tb_fullname.Text = "";
            tb_username.Text = "";
            tb_pwd.Text = "";
            tb_conpwd.Text = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Close();
        }

        private void btn_registered_Click(object sender, EventArgs e)
        {
            // check existing username

            //            if(tb_username.Text.)
            if (string.IsNullOrEmpty(tb_username.Text) == true)
            {
                tb_username.Focus();
                errorProvider_user.SetError(tb_username, "Please fill the field");
            }
            else if (string.IsNullOrEmpty(tb_pwd.Text) == true)
            {
                tb_pwd.Focus();
                errorProvider_user.SetError(tb_pwd, "Please fill the field");
            }
            else if (string.IsNullOrEmpty(tb_conpwd.Text) == true)
            {
                tb_conpwd.Focus();
                errorProvider_user.SetError(tb_conpwd, "Please fill the field");
            }
            else
            {

                try
                {
                    int User_Id = int.Parse(tb_fullname.Text);
                    string UserName = (string.IsNullOrWhiteSpace(tb_username.Text)) ? "-" : tb_username.Text;
                    string Password = (string.IsNullOrWhiteSpace(tb_pwd.Text)) ? "-" : tb_pwd.Text;
                    string ConPassword = (string.IsNullOrWhiteSpace(tb_conpwd.Text)) ? "-" : tb_conpwd.Text;

                    Login login = new Login();
                    login.User_Id = User_Id;
                    login.User_Name = UserName;
                    login.Pass_word = Password;
                    login.Con_Password = ConPassword;

                    login.insertNewUser();

                    resetData();
                    MessageBox.Show("Done and Thank You");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}
