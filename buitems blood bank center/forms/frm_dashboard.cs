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

namespace buitems_blood_bank_center.forms
{
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
            //            loadSettings();

            lblName.Text = Common.name;
            lblMotto.Text = Common.moto;

            PanelWidth = p_left.Width;
            isCollapsed = false;
            timerTime.Start();
            //   lblAdmin.Text = //Common.adminId;
        }
        public void loadSettings()
        {
            Settings s = new Settings();
            DataTable dt = s.getSettings();
            Common.name = dt.Rows[0][1].ToString();
            Common.moto = dt.Rows[0][2].ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(221, 80, 68);
            //                221, 80, 68
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Transparent;

        }

        private bool isCollapsed;
        int PanelWidth;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                p_left.Width += 10;
                if (p_left.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                p_left.Width = p_left.Width - 10;
                if (p_left.Width <= 55)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btn_donor_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            p_side.Top = btn.Top;
            p_side.Height = btn.Height;
        }
        private void addControls(Control control)
        {
            if (!panelControls.Controls.Contains(control))
            {

                panelControls.Controls.Clear();

                control.Dock = DockStyle.Fill;
                control.BringToFront();
                control.Focus();

                panelControls.Controls.Add(control);
                //lblAdmin.Text = panelControls.Controls.Count.ToString();

            }
            else control.BringToFront();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_home);
            UC_Home uc_home = new UC_Home();
            addControls(uc_home);
        }

        private void btn_donor_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btn_donor);
            UserControls.UC_DonorDetails uc_donor = new UserControls.UC_DonorDetails();
            addControls(uc_donor);
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_patient);
            // for user control
            s uc = new s();
            addControls(uc);

        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_request);
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_reports);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_settings);
        }

        private void btn_about_us_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_about_us);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_Time.Text = dt.ToString("hh:mm:ss");
        }

    }
}
