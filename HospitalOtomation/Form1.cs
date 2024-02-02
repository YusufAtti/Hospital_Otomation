using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalOtomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            aLoginPatient pr = new aLoginPatient();
            pr.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Login_Doctor dr = new Login_Doctor();
            dr.Show();
        }

        private void btnSecretary_Click(object sender, EventArgs e)
        {
            cLogin_Secretary sr = new cLogin_Secretary();
            sr.Show();
        }
    }
}
