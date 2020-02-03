using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficeChat
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            using (var db = new Office_ChatEntities())
            {
                string strTargetUser = txtUserName.Text;
                strTargetUser = strTargetUser.Replace(" ", String.Empty);
                var user = new user { userName = strTargetUser , userPassword = txtPassword.Text };
                db.users.Add(user);
                db.SaveChanges();
            }
            MessageBox.Show("User Created Sucessfully!");
            Close();
        }
    }
}
