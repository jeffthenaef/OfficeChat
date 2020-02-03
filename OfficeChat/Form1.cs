using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//public delegate void delUserName(TextBox text);



namespace OfficeChat
{
   

    public partial class Form1 : Form
    {

        public void UpdateMessages()
        {
            txtMessageDialoge.Clear();
            txtMessageDialoge.Text = " your conversation with " + lstUserSelection.SelectedItem;

            using (var db = new Office_ChatEntities())
            {
                var query = from b in db.message3
                            orderby b.date
                            select b;

                foreach (var item in query)
                {
                    //adds other users messages to you 
                    bool result;
                    bool isRelevant;

                    //compares the target user of the message in context to the loged in user
                    string strTargetUser = item.targetUser;
                    strTargetUser = strTargetUser.Replace(" ", String.Empty);

                    string strUserSelection = lblCurrentUser.Text;
                    strUserSelection = strUserSelection.Replace(" ", String.Empty);

                    result = String.Equals(strTargetUser, strUserSelection, StringComparison.Ordinal);


                    // compares the orgin of the message in context to the selected "Friend"
                    string usrCheck = item.userName;
                    usrCheck = usrCheck.Replace(" ", String.Empty);


                    string strCurrentUser = LoginHelper.SelectedUser;
                    strCurrentUser = strCurrentUser.Replace(" ", String.Empty);


                    isRelevant = String.Equals(usrCheck, strCurrentUser, StringComparison.Ordinal);

                    if (result && isRelevant)
                    {

                        txtMessageDialoge.Text += " \n" + item.date + " " + item.userName + " : " + item.message;
                        //MessageBox.Show(item.message);
                    }

                    //adds your messages into the list

                    // compares the target user of the message to the item selected in the lst box
                    strTargetUser = item.targetUser;
                    strTargetUser = strTargetUser.Replace(" ", String.Empty);

                    strUserSelection = LoginHelper.SelectedUser;
                    strUserSelection = strUserSelection.Replace(" ", String.Empty);

                    result = String.Equals(strTargetUser, strUserSelection, StringComparison.Ordinal);


                    // comapres username of message to the current user loged in
                    usrCheck = item.userName;
                    usrCheck = usrCheck.Replace(" ", String.Empty);

                    strCurrentUser = lblCurrentUser.Text;
                    strCurrentUser = strCurrentUser.Replace(" ", String.Empty);


                    isRelevant = String.Equals(usrCheck, strCurrentUser, StringComparison.Ordinal);

                    if (result && isRelevant)
                    {

                        txtMessageDialoge.Text += "\n" + item.date + " " + item.userName + " : " + item.message;
                        //MessageBox.Show(item.message);
                    }


                }


            }
        }
        
        public Form1()
        {
            InitializeComponent();


        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginHelper.IsLoggedIn)
            {
               

                using (var db = new Office_ChatEntities())
                {
                    
                    var query = from b in db.message3
                                orderby b.postID
                                select b;

                    long lngPostID = 0;
                    foreach (var item in query)
                    {
                        lngPostID = item.postID;
                    }
                    lngPostID++;
                    string msg = txtUsrInput.Text;
                    string strUserSelected = "" + lstUserSelection.SelectedItem;

                    //todo Check to validate a user has been selected
                    //todo after adding the login pannel we need to change the username from static to var


                    var message = new message3 { userName = lblCurrentUser.Text, message = msg, date = System.DateTime.Now, postID = lngPostID, send_recieved = true, targetUser = strUserSelected };
                    db.message3.Add(message);
                    db.SaveChanges();
                }
                UpdateMessages();
                txtUsrInput.Text = "";
            } else
                MessageBox.Show("Please Login");


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (LoginHelper.IsLoggedIn)
            {
                LoginHelper.HasSelected = true;
                LoginHelper.SelectedUser = lstUserSelection.SelectedItem.ToString();

                UpdateMessages();
           
            }
            else
                MessageBox.Show("Please Login");
        }
               
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LoginHelper.IsLoggedIn && LoginHelper.HasSelected)
                UpdateMessages();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstUserSelection.Items.Clear();
            lblCurrentUser.Text = "";
            Form2 form2 = new Form2();
            while (!LoginHelper.IsLoggedIn)
            {
                form2.ShowDialog();
            }
            lblCurrentUser.Text = LoginHelper.User;
            
            // cleans the user field of spaces and then checks to see if the admin has logged in to provide the admin panel. 
            string strCheckAdmin = LoginHelper.User;
            strCheckAdmin = strCheckAdmin.Replace(" ", String.Empty);
            bool isAdmin = String.Equals(strCheckAdmin, "admin", StringComparison.Ordinal);
            if (isAdmin)
            {
                cmbAdminPanel.Visible = true;
                LoginHelper.IsAdmin = true;
            }

            //populate the "friends" section
            lstUserSelection.Items.Clear();
            using (var db = new Office_ChatEntities())
            {
                var query = from b in db.users
                            orderby b.userName
                            select b;

                foreach (var item in query)
                {

                    //MessageBox.Show(strinput);
                    //MessageBox.Show(strCheck);
                    //MessageBox.Show(result.ToString());
                    lstUserSelection.Items.Add(item.userName);
                }

            }



        }

        private void cmbAdminPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            bool v = cmbAdminPanel.SelectedItem == "Add User";
           
            if (v)
            {
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
                frm3.Dispose();
              
            }

        }
    }
}
