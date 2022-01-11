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
    public partial class CreateUserform : Form
    {
        public CreateUserform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new MISEntities();
            var l = new LoginInfo
                        {
                            UserName = textBox1.Text.Trim(),
                            Password = textBox2.Text.Trim()
                        };

            m.AddToLoginInfoes(l);
            m.SaveChanges();

            MessageBox.Show(@"its work");
        }
    }
}
