using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAnBDS.Log
{
    public partial class RegisterObj : Form
    {
        public RegisterObj()
        {
            InitializeComponent();
        }


        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.Checked = false;
            else
            {
                checkBox2.Checked = false;
                checkBox1.Checked = true;
            }

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                checkBox2.Checked = false;
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
            }

        }
    }
}
