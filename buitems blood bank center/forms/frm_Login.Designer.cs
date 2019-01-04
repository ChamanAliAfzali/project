using buitems_blood_bank_center.forms;
namespace buitems_blood_bank_center
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_register = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorProvider_user = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_pass = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_question = new System.Windows.Forms.Label();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.lbl_showPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 33);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::buitems_blood_bank_center.Properties.Resources.icons8_Minimize_Window_32;
            this.pictureBox2.Location = new System.Drawing.Point(261, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 30);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::buitems_blood_bank_center.Properties.Resources.icons8_Close_Window_32;
            this.pictureBox1.Location = new System.Drawing.Point(298, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_username
            // 
            this.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_username.ForeColor = System.Drawing.Color.White;
            this.tb_username.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_username.HintText = "Enter Username";
            this.tb_username.isPassword = false;
            this.tb_username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tb_username.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tb_username.LineThickness = 3;
            this.tb_username.Location = new System.Drawing.Point(36, 168);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(259, 37);
            this.tb_username.TabIndex = 0;
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_Password
            // 
            this.tb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_Password.ForeColor = System.Drawing.Color.White;
            this.tb_Password.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_Password.HintText = "";
            this.tb_Password.isPassword = true;
            this.tb_Password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tb_Password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tb_Password.LineThickness = 3;
            this.tb_Password.Location = new System.Drawing.Point(36, 225);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(259, 37);
            this.tb_Password.TabIndex = 1;
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Login
            // 
            this.btn_Login.ActiveBorderThickness = 1;
            this.btn_Login.ActiveCornerRadius = 20;
            this.btn_Login.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Login.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Login.BackgroundImage")));
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(138)))));
            this.btn_Login.IdleBorderThickness = 1;
            this.btn_Login.IdleCornerRadius = 20;
            this.btn_Login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(138)))));
            this.btn_Login.IdleForecolor = System.Drawing.Color.White;
            this.btn_Login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(138)))));
            this.btn_Login.Location = new System.Drawing.Point(36, 310);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(256, 41);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_register
            // 
            this.btn_register.ActiveBorderThickness = 1;
            this.btn_register.ActiveCornerRadius = 20;
            this.btn_register.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_register.ActiveForecolor = System.Drawing.Color.White;
            this.btn_register.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_register.BackgroundImage")));
            this.btn_register.ButtonText = "Register";
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_register.IdleBorderThickness = 1;
            this.btn_register.IdleCornerRadius = 20;
            this.btn_register.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.btn_register.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_register.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.btn_register.Location = new System.Drawing.Point(188, 366);
            this.btn_register.Margin = new System.Windows.Forms.Padding(5);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(104, 41);
            this.btn_register.TabIndex = 4;
            this.btn_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // errorProvider_user
            // 
            this.errorProvider_user.ContainerControl = this;
            // 
            // errorProvider_pass
            // 
            this.errorProvider_pass.ContainerControl = this;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_question.Location = new System.Drawing.Point(58, 383);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(122, 13);
            this.lbl_question.TabIndex = 14;
            this.lbl_question.Text = "Don\'t have an account?";
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(257, 282);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch1.TabIndex = 16;
            this.bunifuiOSSwitch1.Value = true;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // lbl_showPassword
            // 
            this.lbl_showPassword.AutoSize = true;
            this.lbl_showPassword.Font = new System.Drawing.Font("Arial Unicode MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_showPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_showPassword.Location = new System.Drawing.Point(132, 283);
            this.lbl_showPassword.Name = "lbl_showPassword";
            this.lbl_showPassword.Size = new System.Drawing.Size(119, 19);
            this.lbl_showPassword.TabIndex = 17;
            this.lbl_showPassword.Text = "show password ?";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(332, 421);
            this.Controls.Add(this.lbl_showPassword);
            this.Controls.Add(this.bunifuiOSSwitch1);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_Password;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Login;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_register;

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider_user;
        private System.Windows.Forms.ErrorProvider errorProvider_pass;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.Label lbl_showPassword;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
    }
}

