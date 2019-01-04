namespace buitems_blood_bank_center.forms
{
    partial class frm_signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_signup));
            this.tb_pwd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tb_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.tb_conpwd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProvider_Cpass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_pass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_user = new System.Windows.Forms.ErrorProvider(this.components);
            this.tb_fullname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_question = new System.Windows.Forms.Label();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_registered = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Cpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_user)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_pwd
            // 
            this.tb_pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_pwd.ForeColor = System.Drawing.Color.White;
            this.tb_pwd.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_pwd.HintText = "";
            this.tb_pwd.isPassword = true;
            this.tb_pwd.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tb_pwd.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_pwd.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tb_pwd.LineThickness = 3;
            this.tb_pwd.Location = new System.Drawing.Point(31, 199);
            this.tb_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(259, 37);
            this.tb_pwd.TabIndex = 3;
            this.tb_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_pwd.Leave += new System.EventHandler(this.tb_pass_Leave);
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
            this.tb_username.Location = new System.Drawing.Point(31, 154);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(259, 37);
            this.tb_username.TabIndex = 2;
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 33);
            this.panel1.TabIndex = 6;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Image = global::buitems_blood_bank_center.Properties.Resources.icons8_Minimize_Window_32;
            this.btn_minimize.Location = new System.Drawing.Point(242, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Image = global::buitems_blood_bank_center.Properties.Resources.icons8_Close_Window_32;
            this.btn_close.Location = new System.Drawing.Point(279, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 2;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tb_conpwd
            // 
            this.tb_conpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_conpwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_conpwd.ForeColor = System.Drawing.Color.White;
            this.tb_conpwd.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_conpwd.HintText = "";
            this.tb_conpwd.isPassword = true;
            this.tb_conpwd.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tb_conpwd.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_conpwd.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tb_conpwd.LineThickness = 3;
            this.tb_conpwd.Location = new System.Drawing.Point(31, 244);
            this.tb_conpwd.Margin = new System.Windows.Forms.Padding(4);
            this.tb_conpwd.Name = "tb_conpwd";
            this.tb_conpwd.Size = new System.Drawing.Size(259, 37);
            this.tb_conpwd.TabIndex = 4;
            this.tb_conpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_conpwd.Leave += new System.EventHandler(this.tb_Cpass_Leave);
            // 
            // errorProvider_Cpass
            // 
            this.errorProvider_Cpass.ContainerControl = this;
            // 
            // errorProvider_pass
            // 
            this.errorProvider_pass.ContainerControl = this;
            // 
            // errorProvider_user
            // 
            this.errorProvider_user.ContainerControl = this;
            // 
            // tb_fullname
            // 
            this.tb_fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_fullname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_fullname.ForeColor = System.Drawing.Color.White;
            this.tb_fullname.HintForeColor = System.Drawing.Color.DimGray;
            this.tb_fullname.HintText = "Enter FullName";
            this.tb_fullname.isPassword = false;
            this.tb_fullname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tb_fullname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb_fullname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tb_fullname.LineThickness = 3;
            this.tb_fullname.Location = new System.Drawing.Point(31, 109);
            this.tb_fullname.Margin = new System.Windows.Forms.Padding(4);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(259, 37);
            this.tb_fullname.TabIndex = 1;
            this.tb_fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_question.Location = new System.Drawing.Point(46, 421);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(132, 13);
            this.lbl_question.TabIndex = 7;
            this.lbl_question.Text = "Already have an account?";
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 20;
            this.btn_login.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 20;
            this.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.btn_login.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.btn_login.Location = new System.Drawing.Point(186, 402);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(104, 41);
            this.btn_login.TabIndex = 8;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_registered
            // 
            this.btn_registered.ActiveBorderThickness = 1;
            this.btn_registered.ActiveCornerRadius = 20;
            this.btn_registered.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registered.ActiveForecolor = System.Drawing.Color.White;
            this.btn_registered.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_registered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_registered.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registered.BackgroundImage")));
            this.btn_registered.ButtonText = "Register";
            this.btn_registered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registered.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(138)))));
            this.btn_registered.IdleBorderThickness = 1;
            this.btn_registered.IdleCornerRadius = 20;
            this.btn_registered.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(138)))));
            this.btn_registered.IdleForecolor = System.Drawing.Color.White;
            this.btn_registered.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(43)))), ((int)(((byte)(138)))));
            this.btn_registered.Location = new System.Drawing.Point(31, 338);
            this.btn_registered.Margin = new System.Windows.Forms.Padding(5);
            this.btn_registered.Name = "btn_registered";
            this.btn_registered.Size = new System.Drawing.Size(259, 41);
            this.btn_registered.TabIndex = 13;
            this.btn_registered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_registered.Click += new System.EventHandler(this.btn_registered_Click);
            // 
            // frm_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(321, 477);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_registered);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.tb_fullname);
            this.Controls.Add(this.tb_conpwd);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_signup";
            this.Text = "frm_signup";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Cpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_pwd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_username;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_conpwd;
        private System.Windows.Forms.ErrorProvider errorProvider_Cpass;
        private System.Windows.Forms.ErrorProvider errorProvider_pass;
        private System.Windows.Forms.ErrorProvider errorProvider_user;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tb_fullname;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Label lbl_question;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_registered;
    }
}