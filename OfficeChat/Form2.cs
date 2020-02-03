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
    public partial class Form2 : Form
    {
        private string strUserName;
        private string strUserPass;
        private bool boolUserConfirmed = false;
        private bool boolPassConfirmed = false;

        public string StrUserName { get => strUserName; set => strUserName = value; }
        public string StrUserPass { get => strUserPass; set => strUserPass = value; }
        public bool BoolUserConfirmed { get => boolUserConfirmed; set => boolUserConfirmed = value; }
        public bool BoolPassConfirmed { get => boolPassConfirmed; set => boolPassConfirmed = value; }

        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
           
        }

        


        public void Button1_Click(object sender, EventArgs e)
        {

            //check the username
            using (var db = new Office_ChatEntities())
            {
                var query = from b in db.users
                            orderby b.userName
                            select b;

                foreach (var item in query)
                {
                   bool result;
                    
                    string strinput =  txtUserName.Text;
                    strinput = strinput.Replace(" ", String.Empty);
                    string strCheck = item.userName;
                    strCheck = strCheck.Replace(" ", String.Empty);

                    result = String.Equals(strinput, strCheck, StringComparison.Ordinal);
                                                                                           
                        //MessageBox.Show(strinput);
                        //MessageBox.Show(strCheck);
                        //MessageBox.Show(result.ToString());
                    if (result)
                    {
                       // MessageBox.Show("username confirmed");
                        strUserName = txtUserName.Text;
                        BoolUserConfirmed = true;
                    }
                }

            }
            // check the password
            using (var db = new Office_ChatEntities())
            {
                var query = from b in db.users
                            orderby b.userPassword
                            select b;

                foreach (var item in query)
                {
                    bool result; 
                    string strinput = txtPassWord.Text;
                    strinput = strinput.Replace(" ", String.Empty);
                    string strCheck = item.userPassword;
                    strCheck = strCheck.Replace(" ", String.Empty);

                    result = String.Equals(strinput, strCheck, StringComparison.Ordinal);

                    if (result)
                    {
                      //  MessageBox.Show("Password Confirmed");
                        strUserPass = txtPassWord.Text;
                        BoolPassConfirmed = true;
                    }
                }

            }

            //todo: add a counter to tell them to contact helpdesk after 3 attempts;

            if (BoolPassConfirmed && BoolUserConfirmed)
            {
                Form1 frm = new Form1();
             //  MessageBox.Show("Login Successfull");
              
                LoginHelper.User = txtUserName.Text;
                LoginHelper.IsLoggedIn = true;
                Close();
            }
            else
            {
                MessageBox.Show("invalid username and or password");
                // MessageBox.Show(BoolPassConfirmed.ToString());
               // this.Controls.Clear();
               // this.InitializeComponent();
            }
            

        }
    }
}
