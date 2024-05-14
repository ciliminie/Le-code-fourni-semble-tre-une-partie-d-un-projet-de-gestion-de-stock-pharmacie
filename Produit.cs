using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Pharmacie_Project
{
    public partial class Produit : Form
    {
        public Produit()
        {
            InitializeComponent();
        }
        string connectionstringProd = ConfigurationManager.ConnectionStrings["SQlserver"].ConnectionString;
        


        private void bTN_LIST_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionstringProd;

            string Quiry = "SELECT * FROM Produit ";
            SqlCommand cmd = new SqlCommand(Quiry, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                this.dataGridView1pRODUIT.Rows.Clear();
                while (rd.Read())
                {
                    this.dataGridView1pRODUIT.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);

                }
                cnx.Close();
            }
            else
                MessageBox.Show("La table est vide ");
        }

        private void bTN_ADD_Click(object sender, EventArgs e)
        {
            //insert into Client values (,'','','','','');

            using (SqlConnection cnx = new SqlConnection(connectionstringProd))
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


                string QuiryADD = "insert into Produit values (" + this.ID_textBox1.Text.ToString().Trim() + ",'" + this.Nom_textBox2.Text.ToUpper().Trim() + "'," + this.Prix_textBox3.Text.ToString().Trim() + "," + this.Nserie_textBox4.Text.ToString() + ",'" + this.dateTimePicker1pro.Value.ToString("yyyy'/'MM'/'dd") + "','" + this.dateTimePicker2pro.Value.ToString("yyyy'/'MM'/'dd") + "')";
                SqlCommand cmd = new SqlCommand(QuiryADD, cnx);
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();

                
                int a = cmd.ExecuteNonQuery();
                bTN_LIST_Click(sender, e);

                // this.dataGridView1pRODUIT.Rows.Add(this.ID_textBox1.Text.ToString().Trim(), this.Nom_textBox2.Text.ToUpper().Trim(), this.Prix_textBox3.Text.ToString().Trim(), this.Nserie_textBox4.Text, this.DATEPRO_textBox5.Text, this.daTEEXP_textBox6.Text);
                MessageBox.Show(a + "Has been Affected !");
                cnx.Close();
            }
        }

        private void Produit_Load(object sender, EventArgs e)
        {
           // bTN_LIST_Click(sender, e);
            this.dataGridView1pRODUIT.ReadOnly = true;
            this.ID_textBox1.Focus();
        }

        int ID_Produit;
        int position = -1;
         private bool chekid = false;

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            if (position == -1)
            {
                MessageBox.Show("please choose an ligne !");
                return;
            }
            using (SqlConnection cnx = new SqlConnection(connectionstringProd))
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete this ligne ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "DELETE FROM Produit WHERE ID_Produit= @ID_Produit";
                cmd.Parameters.AddWithValue("ID_Produit", ID_Produit);
                cnx.Open();
                cmd.ExecuteNonQuery();
                this.dataGridView1pRODUIT.Rows.RemoveAt(position);
                MessageBox.Show("The row has been DELETED !");
                cnx.Close();
            }




        }

        private bool CheckADD()
        {
            if (this.ID_textBox1.Text.ToString().Trim().Equals(string.Empty) ||
                this.Nom_textBox2.Text.Trim().Equals(string.Empty) ||
                this.Prix_textBox3.Text.Trim().Equals(string.Empty) ||
                this.Nserie_textBox4.Text.Trim().Equals(string.Empty) ||
                this.dateTimePicker1pro.Text.Trim().Equals(string.Empty) ||
                this.dateTimePicker2pro.Text.Trim().Equals(string.Empty))
                return false;
            return true;
        }

        private void dataGridView1pRODUIT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.dataGridView1pRODUIT.CurrentRow.Index;
            ID_Produit = int.Parse(this.dataGridView1pRODUIT.Rows[position].Cells[0].Value.ToString());

            this.ID_textBox1.Text = this.dataGridView1pRODUIT.Rows[position].Cells[0].Value.ToString();
            this.Nom_textBox2.Text = this.dataGridView1pRODUIT.Rows[position].Cells[1].Value.ToString();
            this.Prix_textBox3.Text = this.dataGridView1pRODUIT.Rows[position].Cells[2].Value.ToString();
            this.Nserie_textBox4.Text = this.dataGridView1pRODUIT.Rows[position].Cells[3].Value.ToString();
            this.dateTimePicker1pro.Text = this.dataGridView1pRODUIT.Rows[position].Cells[4].Value.ToString();
            this.dateTimePicker2pro.Text= this.dataGridView1pRODUIT.Rows[position].Cells[5].Value.ToString();

            this.ID_textBox1.Enabled = false;
            chekid = true;
        }

        private void BTN_modyfy_Click(object sender, EventArgs e)
        {
            string UPquiry = "UPDATE Produit  SET  Nom_Produit = @p1 , Prix_Produit = @p2,  N_Serie  = @p3, Date_Production = @p4, Date_Expiration = @p5 WHERE  ID_Produit = @p6";

            using (SqlConnection cnx = new SqlConnection(connectionstringProd))
            {
                SqlCommand cmd = new SqlCommand(UPquiry, cnx);
                cmd.Parameters.AddWithValue("@p1", this.Nom_textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@p2", this.Prix_textBox3.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@p3", this.Nserie_textBox4.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@p4", this.dateTimePicker1pro.Value.ToString("yyyy'/'MM'/'dd").ToString().Trim());
                cmd.Parameters.AddWithValue("@p5", this.dateTimePicker2pro.Value.ToString("yyyy'/'MM'/'dd").Trim());
                cmd.Parameters.AddWithValue("@p6", this.ID_textBox1.Text.Trim());

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                bTN_LIST_Click(sender, e);
                MessageBox.Show("the ligne has been moDify !");

            }
        }

        private void Btn_NEW_Click(object sender, EventArgs e)
        {
            chekid = false;
            this.ID_textBox1.Text = (string.Empty);
            this.Nom_textBox2.Text = (string.Empty);
            this.Prix_textBox3.Text = (string.Empty);
            this.Nserie_textBox4.Text = (string.Empty);
            this.dateTimePicker1pro.Text = (string.Empty);
            this.dateTimePicker2pro.Text = (string.Empty);

            this.ID_textBox1.Enabled = true;
        }

        private void BTN_FIRST_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1pRODUIT.Rows.Count > 0)
            {
                this.dataGridView1pRODUIT.ClearSelection();
                this.dataGridView1pRODUIT.Rows[0].Selected = true;
                navi = 0;
            }

        }
        int navi;
        private void bTN_next_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1pRODUIT.Rows.Count > 0)
            {
                this.dataGridView1pRODUIT.ClearSelection();
                int pos = navi + 1;
                if (pos == this.dataGridView1pRODUIT.Rows.Count)
                {
                    return;
                }
                this.dataGridView1pRODUIT.Rows[pos].Selected = true;
                navi = pos;
            }

        }

        private void Btn_Privously_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1pRODUIT.Rows.Count > 0)
            {
                this.dataGridView1pRODUIT.ClearSelection();
                int pos = navi - 1;
                if (pos == this.dataGridView1pRODUIT.Rows.Count)
                {
                    return;
                }

                this.dataGridView1pRODUIT.Rows[pos].Selected = true;
                navi = pos;

            }

        }

        private void Btn_Last_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1pRODUIT.Rows.Count > 0)
            {
                this.dataGridView1pRODUIT.ClearSelection();
                int pos = this.dataGridView1pRODUIT.Rows.Count - 1;
                this.dataGridView1pRODUIT.Rows[pos].Selected = true;
                navi = pos;
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            string Quiry = "select * from Produit WHERE Nom_Produit = @p7";
            using (SqlConnection cnx = new SqlConnection(connectionstringProd))
            {
                SqlCommand cmd = new SqlCommand(Quiry, cnx);
                cmd.Parameters.AddWithValue("@p7", this.search_textBox7.Text);
                cnx.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    this.dataGridView1pRODUIT.Rows.Clear();
                    rd.Read();

                    this.dataGridView1pRODUIT.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);


                }
                 
                else
                    MessageBox.Show("le nom de produit  n'éxist de pas !");
                cnx.Close();

            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("are you sure doyou want to Quit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d==DialogResult.No)
            {
                return;
            }

            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
             
        }
    }
}
