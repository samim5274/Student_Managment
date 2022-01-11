using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLoginClick(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtuserName.Text) || string.IsNullOrEmpty(txtUserPassword.Text))
            {
                MessageBox.Show(@"Pls Enter user name and password...", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var context = new MISEntities())
                {
                    var q = from log in context.LoginInfoes
                            where log.UserName == txtuserName.Text && log.Password == txtUserPassword.Text
                            select log;
                    if (q.SingleOrDefault() != null)
                    {
                        MessageBox.Show(@"Login Successfully", @"Message", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        txtuserName.Text = txtUserPassword.Text = string.Empty;
                        var obj = new MotherForm();
                        obj.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show(@"Invalid user Name and Password pls try again", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //  throw new Exception(ex.Message);
            }



        }
    }
}
