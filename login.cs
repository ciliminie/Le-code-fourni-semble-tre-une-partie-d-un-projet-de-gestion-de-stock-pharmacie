using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            if (textBox3.Text=="ABBASS" && textBox4.Text=="123")
            {
                new Client().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("the User name ghalt !");
                textBox3.Clear();
                textBox4.Clear();
                textBox3.Focus();

            }
        }
    }
}
