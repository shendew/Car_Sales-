using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class signin : Form
    {
        DBAccess dBAccess=new DBAccess();
        public signin()
        {
            InitializeComponent();
        }

        

        

        private void signin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            TextBox name = regTName;
            TextBox age = regTAge;
            TextBox pass = regTPass;

            if(name.Text =="")
            {
                MessageBox.Show("Please enter your name");
            }else if(age.Text == "")
            {
                MessageBox.Show("Please enter your age");
            }else if (pass.Text =="")
            {
                MessageBox.Show("Please enter your password");
            }
            else
            {
                SqlCommand insertQ = new SqlCommand("insert into login_table(user_name,user_age,user_pass) values(@name,@age,@pass)");
                insertQ.Parameters.Add("@name", name.Text);
                insertQ.Parameters.Add("@age",age.Text);
                insertQ.Parameters.Add("@pass", pass.Text);

                
                int row=dBAccess.executeQuery(insertQ);
                if (row == 1)
                {
                    MessageBox.Show("User Registered Succesfull");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                dBAccess.closeConn();
            }

        }

        private void regLoginBtn_Click(object sender, EventArgs e)
        {   
            login l=new login();
            this.Hide();
            l.Show();
            
        }
    }
}
