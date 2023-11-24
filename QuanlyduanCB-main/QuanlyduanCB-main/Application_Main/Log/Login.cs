using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDuAnBDS.DB;

namespace Application
{
    public partial class Login : Form
    {
        ConectionSQL conectionSQL = new();

        public Login(string text)
        {
            InitializeComponent();
            this.txt_TenDn.Text = text;
            conectionSQL.Ketnoi();
        }

        public Login()
        {
            InitializeComponent();
            conectionSQL.Ketnoi();
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {

            if (conectionSQL.getDataTk(txt_TenDn.Text, txt_Mk.Text) == "DT")
            {
                this.Hide();
                HomeDT home = new HomeDT();
                home.ShowDialog();
                this.Close();
            }
            else
            {
                lb_TB.Show();
            }
        }

        private void btn_DK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register rg = new Register(txt_TenDn.Text);
            rg.ShowDialog();
            this.Close();
        }
    }
}
