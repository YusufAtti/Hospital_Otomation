using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalOtomation
{
    public partial class aLoginPatient : Form
    {
        public aLoginPatient()
        {
            InitializeComponent();
        }

        SqlConnectionshortcut sss = new SqlConnectionshortcut();

        private void linkLabelptsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Patience_Sign_up pc = new Patience_Sign_up();
            pc.Show();
        }

        private void btnptclogin_Click(object sender, EventArgs e)
        {
            
            SqlCommand com = new SqlCommand("Select * from  TBL_Sick Where SickTC=@p1 and SickPassword=@p2", sss.connect());
            com.Parameters.AddWithValue("p1", msktxtptnumber.Text);
            com.Parameters.AddWithValue("p2", textBoxptpassw.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                Patience_menu fr = new Patience_menu();
                fr.snumber = msktxtptnumber.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password or serial number is incorrect");
            }

            sss.connect().Close();
        }
    }
}
