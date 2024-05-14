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
using System.Configuration;

namespace Pharmacie_Project
{
    public partial class statistique2 : Form
    {
        public statistique2()
        {
            InitializeComponent();
        }
        string connectionstring = ConfigurationManager.ConnectionStrings["SQlserver"].ConnectionString;

        private void Btn_List_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionstring;

            string Quiry = "SELECT * FROM statistique  ";
            SqlCommand cmd = new SqlCommand(Quiry, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                this.dataGridView1.Rows.Clear();
                while (rd.Read())
                {
                    this.dataGridView1.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5] , rd[6]);

                }
                cnx.Close();
            }
            else
                MessageBox.Show("La table est vide ");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!CheckADD())
            {
                MessageBox.Show("SVP INSEREZ TOUT LES INFORMATION !!");
                return;

            }

            if (chekid == true)
            {
                return;
            }
            using (SqlConnection cnx = new SqlConnection(connectionstring))
            {
                string QuiryADD = "insert into statistique  values (" + this.matri_textBox1.Text.ToString().Trim() + ",'" + this.nomprod_textBox2.Text.ToUpper().Trim() + "','" + this.dateTimePicker1.Value.ToString("yyyy'/'MM'/'dd") + "',"+this.capitale_textBox.Text.ToString()+" ," + this.gains_textBox5.Text.ToUpper() + "," + this.perte_textBox4.Text.ToString() + "," + this.total_textBox3.Text.ToString() + ")";
                SqlCommand cmd = new SqlCommand(QuiryADD, cnx);
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
                int a = cmd.ExecuteNonQuery();
                Btn_List_Click(sender, e);
                // this.dataGridView1.Rows.Add(this.ID_textBox1.Text.ToString().Trim(), this.Nom_textBox2.Text.ToUpper().Trim(), this.Pre_textBox3.Text.ToUpper().Trim, this.Cine_textBox4.Text, this.DATE_textBox5.Text, this.ville_textBox6.Text);
                MessageBox.Show(a + "Has been Affected !");
                cnx.Close();
            }
        }

        private void statistique2_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ReadOnly = true;
            this.matri_textBox1.Focus();
        }
        private bool CheckADD()
        {
            if (this.matri_textBox1.Text.ToString().Trim().Equals(string.Empty) ||
                this.nomprod_textBox2.Text.Trim().Equals(string.Empty) ||
                this.dateTimePicker1.Text.Trim().Equals(string.Empty)||
                this.capitale_textBox.Text.Trim().Equals(string.Empty)||
                this.gains_textBox5.Text.Trim().Equals(string.Empty) ||
                this.perte_textBox4.Text.Trim().Equals(string.Empty) ||
                this.total_textBox3.Text.Trim().Equals(string.Empty))
                return false;
            return true;
        }
      
        int position = -1 ,Matricule;
        bool chekid = false;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dataGridView1.CurrentRow.Index;
            Matricule = int.Parse(this.dataGridView1.Rows[position].Cells[0].Value.ToString()); 

            this.matri_textBox1.Text = this.dataGridView1.Rows[position].Cells[0].Value.ToString();
            this.nomprod_textBox2.Text = this.dataGridView1.Rows[position].Cells[1].Value.ToString();
            this.dateTimePicker1.Text = this.dataGridView1.Rows[position].Cells[2].Value.ToString();
            this.capitale_textBox.Text = this.dataGridView1.Rows[position].Cells[3].Value.ToString();
            this.gains_textBox5.Text = this.dataGridView1.Rows[position].Cells[4].Value.ToString();
            this.perte_textBox4.Text = this.dataGridView1.Rows[position].Cells[5].Value.ToString();
            this.total_textBox3.Text = this.dataGridView1.Rows[position].Cells[6].Value.ToString();
        }

        private void btn_Modyfy_Click(object sender, EventArgs e)
        {

            string UPquiry = "UPDATE statistique SET  Nom_prod = @p1 ,  date_reservation = @p2,capitale = @p3,  gains = @p4, perte = @p5, total = @p6 WHERE  Matricule = @p7";

            using (SqlConnection cnx = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand(UPquiry, cnx);
                cmd.Parameters.AddWithValue("@p1", this.nomprod_textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@p2", this.dateTimePicker1.Value.ToString("yyyy'/'MM'/'dd").Trim());
                cmd.Parameters.AddWithValue("@p3", this.capitale_textBox.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@p4", this.gains_textBox5.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@p5", this.perte_textBox4.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@p6", this.total_textBox3.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@p7", this.matri_textBox1.Text.Trim());

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                Btn_List_Click(sender, e);
                MessageBox.Show("the ligne has been moDify !");

            }



        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            this.matri_textBox1.Text = (string.Empty);
            this.nomprod_textBox2.Text = (string.Empty);
            this.dateTimePicker1.Text = (string.Empty);
            this.capitale_textBox.Text = (string.Empty);
            this.gains_textBox5.Text = (string.Empty);
            this.perte_textBox4.Text = (string.Empty);
            this.total_textBox3.Text = (string.Empty);
        }

        private void btn_SAERCH_Click(object sender, EventArgs e)
        {
            string Quiry = "select * from statistique WHERE Nom_prod = @p7";
            using (SqlConnection cnx = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand(Quiry, cnx);
                cmd.Parameters.AddWithValue("@p7", this.saerch_textBox6.Text);
                cnx.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    this.dataGridView1.Rows.Clear();
                    rd.Read();

                    this.dataGridView1.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);


                }

                else
                    MessageBox.Show("le nom de produit  n'éxist de pas !");
                cnx.Close();

            }
        }

        private void BTN_CALCUER_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(gains_textBox5.Text.ToString());
            double x2 = Convert.ToDouble(perte_textBox4.Text);
            double total = x1 - x2;
          //  total = Convert.ToDouble(total_textBox3.Text.ToString());
            MessageBox.Show("Total est :" + total);
        }

        private void bTN_delete_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("please choose an ligne !");
                return;
            }
            using (SqlConnection cnx = new SqlConnection(connectionstring))
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete this ligne ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "DELETE FROM statistique  WHERE Matricule = @Matricule";
                cmd.Parameters.AddWithValue("Matricule", Matricule);
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.dataGridView1.Rows.RemoveAt(position);
                MessageBox.Show("The row has been DELETED !");
                cnx.Close();
            }
        }
    }
}
