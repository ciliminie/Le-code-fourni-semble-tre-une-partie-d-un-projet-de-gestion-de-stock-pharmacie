using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace Pharmacie_Project
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        //SQlserver
        string connectionstring = ConfigurationManager.ConnectionStrings["SQlserver"].ConnectionString;

        private void bTN_LIST_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionstring;

            string Quiry = "SELECT * FROM Client ";
            SqlCommand cmd = new SqlCommand(Quiry,cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            
            if (rd.HasRows)
            {
                this.dataGridView1.Rows.Clear();
                while (rd.Read())
                {
                    this.dataGridView1.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);

                }
                cnx.Close();
            }
            else
                MessageBox.Show("La table est vide ");

        }

        private void bTN_ADD_Click(object sender, EventArgs e)
        {
            //insert into Client values (,'','','','','');
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
                string QuiryADD = "insert into Client values ("+this.ID_textBox1.Text.ToString().Trim()+",'"+this.Nom_textBox2.Text.ToUpper().Trim()+"','"+this.Pre_textBox3.Text.ToUpper().Trim()+"','"+this.Cine_textBox4.Text.ToUpper()+"','"+this.dateTimePicker1.Value.ToString("yyyy'/'MM'/'dd")+"','"+this.comboBox1.Text+"')";
                SqlCommand cmd = new SqlCommand(QuiryADD, cnx);
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();
                int a = cmd.ExecuteNonQuery();
                bTN_LIST_Click(sender,e);
               // this.dataGridView1.Rows.Add(this.ID_textBox1.Text.ToString().Trim(), this.Nom_textBox2.Text.ToUpper().Trim(), this.Pre_textBox3.Text.ToUpper().Trim, this.Cine_textBox4.Text, this.DATE_textBox5.Text, this.ville_textBox6.Text);
                MessageBox.Show(a +"Has been Affected !");
                cnx.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // bTN_LIST_Click(sender,e);
            this.dataGridView1.ReadOnly = true;
            this.ID_textBox1.Focus();
        }

        private bool CheckADD ()
        {
            if (this.ID_textBox1.Text.ToString().Trim().Equals(string.Empty) ||
                this.Nom_textBox2.Text.Trim().Equals(string.Empty) ||
                this.Pre_textBox3.Text.Trim().Equals(string.Empty) ||
                this.Cine_textBox4.Text.Trim().Equals(string.Empty) ||
                this.dateTimePicker1.Text.Trim().Equals(string.Empty) ||
                this.comboBox1.Text.Trim().Equals(string.Empty))
                return false;
            return true;
        }
        int id_Client;
        int position = -1;
        bool chekid = false;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
             position = this.dataGridView1.CurrentRow.Index;
             id_Client = int.Parse(this.dataGridView1.Rows[position].Cells[0].Value.ToString());

            this.ID_textBox1.Text = this.dataGridView1.Rows[position].Cells[0].Value.ToString();
            this.Nom_textBox2.Text = this.dataGridView1.Rows[position].Cells[1].Value.ToString();
            this.Pre_textBox3.Text = this.dataGridView1.Rows[position].Cells[2].Value.ToString();
            this.Cine_textBox4.Text = this.dataGridView1.Rows[position].Cells[3].Value.ToString();
            this.dateTimePicker1.Text = this.dataGridView1.Rows[position].Cells[4].Value.ToString();
            this.comboBox1.Text = this.dataGridView1.Rows[position].Cells[5].Value.ToString();

            this.ID_textBox1.Enabled = false;
            chekid = true;



        }

        private void Btn_Delete_Click(object sender, EventArgs e) // DELETE FROM Client WHERE ID_client = 
        {

            if(position == -1)
            {
                MessageBox.Show("please choose an ligne !");
                return;
            }
            using (SqlConnection cnx = new SqlConnection(connectionstring))
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete this ligne ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "DELETE FROM Client WHERE ID_client = @id_Client";
                cmd.Parameters.AddWithValue("id_Client", id_Client);
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.dataGridView1.Rows.RemoveAt(position);
                MessageBox.Show("The row has been DELETED !");
                cnx.Close();
            }

        }

        private void Btn_NEW_Click(object sender, EventArgs e)
        {
            chekid = false;
            this.ID_textBox1.Text = (string.Empty);
            this.Nom_textBox2.Text = (string.Empty);
            this.Pre_textBox3.Text = (string.Empty);
            this.Cine_textBox4.Text = (string.Empty);
            this.dateTimePicker1.Text=(string.Empty);
            this.comboBox1.Text= (string.Empty);

            this.ID_textBox1.Enabled = true;

        }

        private void BTN_modyfy_Click(object sender, EventArgs e)
        {
            string UPquiry = "UPDATE Client SET Nom_Client = @p1 , Prenom_Client = @p2 , Cine = @p3, date_Reservation = @p4, ville = @p5 WHERE ID_client = @p6";

            using ( SqlConnection cnx = new SqlConnection(connectionstring))
            {
               SqlCommand cmd = new SqlCommand(UPquiry,cnx);
                cmd.Parameters.AddWithValue("@p1", this.Nom_textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@p2",this.Pre_textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@p3", this.Cine_textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@p4", this.dateTimePicker1.Value.ToString("yyyy'/'MM'/'dd").Trim());
                cmd.Parameters.AddWithValue("@p5", this.comboBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@p6", this.ID_textBox1.Text.Trim());

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                bTN_LIST_Click(sender, e);
                MessageBox.Show("the ligne has been moDify !");


            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            //select * from Client WHERE Nom_Client = ''
            string Quiry = "select * from Client WHERE Nom_Client = @p7";
            using (SqlConnection cnx = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand(Quiry, cnx);
                cmd.Parameters.AddWithValue("@p7", this.search_textBox7.Text);
                cnx.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    this.dataGridView1.Rows.Clear();
                    rd.Read();

                    this.dataGridView1.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);


                }
                else
                MessageBox.Show("le nom n'éxist de pas !");
                cnx.Close();

            }
        }

        private void BTN_FIRST_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.ClearSelection();
                this.dataGridView1.Rows[0].Selected = true;
                navi = 0;
            }

        }
        int navi;
        private void bTN_next_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.ClearSelection();
                int pos = navi + 1;
                if(pos== this.dataGridView1.Rows.Count)
                {
                    return;
                }
                this.dataGridView1.Rows[pos].Selected = true;
                navi = pos;
            }

        }

        private void Btn_Privously_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.ClearSelection();
                int pos = navi - 1;
                if (pos == this.dataGridView1.Rows.Count)
                {
                    return;
                }
                
                this.dataGridView1.Rows[pos].Selected = true;
                navi = pos;

            }

        }

        private void Btn_Last_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.Rows.Count > 0)
            {
                this.dataGridView1.ClearSelection();
                int pos = this.dataGridView1.Rows.Count - 1;
                this.dataGridView1.Rows[pos].Selected = true;
                navi = pos;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void search_textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ville_textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void DATE_textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cine_textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pre_textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nom_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult p = MessageBox.Show("Are you sure you want to exit from this ?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (p == (DialogResult.No))
            {
                return;

            }
                this.Close();
        }
    }
}
