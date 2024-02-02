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
    public partial class Patience_Sign_up : Form
    {
        public Patience_Sign_up()
        {
            InitializeComponent();
        }
        SqlConnectionshortcut sql = new SqlConnectionshortcut();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand(" insert into TBL_Sick (SickName,SickSurname,SickTC,SickPhoneNumber,SickPassword,SickGender) values(@p1,@p2,@p3,@p4,@p5,@p6)", sql.connect());
            com.Parameters.AddWithValue("@p1", textname.Text);
            com.Parameters.AddWithValue("@p2",textsurname.Text);
            com.Parameters.AddWithValue("@p3", msktxtnumber.Text);
            com.Parameters.AddWithValue("@p4", msktxtphone.Text);
            com.Parameters.AddWithValue("@p5", textpassw.Text);
            com.Parameters.AddWithValue("@p6", cmbgender.Text);
            com.ExecuteNonQuery();
            sql.connect().Close();
            MessageBox.Show("The record was created");
            // eğer kayıt olma durumu başarılı olursa bu panel kapanacak olmadıysa panel açık duracak. bu duruma uygun bir "if" komutu ekle


        }
    }
}
