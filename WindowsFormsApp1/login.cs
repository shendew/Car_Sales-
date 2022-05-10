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
    public partial class login : Form
    {   DataTable dataTable=new DataTable();
        public login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            TextBox name = logTName;
            TextBox pass=logTPass;
            if (name.Text == "")
            {
                MessageBox.Show("Enter the name");
            }else if (pass.Text == "")
            {
                MessageBox.Show("Enter the name");
            }
            else
            {
                DBAccess dBAccess = new DBAccess();

                string checkQ = "select * from login_table where user_name='"+name.Text+"' AND user_pass='"+pass.Text+"'";

                dBAccess.readDatathroughAdapter(checkQ,dataTable);
                if(dataTable.Rows.Count == 1)
                {
                    MessageBox.Show("Login Success");
                    homePage home=new homePage();
                    this.Hide();
                    home.Show();
                    
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
                dBAccess.closeConn();

            }
        }
    }
}
