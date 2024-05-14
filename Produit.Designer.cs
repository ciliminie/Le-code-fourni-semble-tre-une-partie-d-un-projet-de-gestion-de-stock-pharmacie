namespace Pharmacie_Project
{
    partial class Produit 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void  Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1pRODUIT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nserie_textBox4 = new System.Windows.Forms.TextBox();
            this.Prix_textBox3 = new System.Windows.Forms.TextBox();
            this.Nom_textBox2 = new System.Windows.Forms.TextBox();
            this.ID_textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Search_text = new System.Windows.Forms.Button();
            this.Btn_Last = new System.Windows.Forms.Button();
            this.Btn_Privously = new System.Windows.Forms.Button();
            this.bTN_next = new System.Windows.Forms.Button();
            this.BTN_FIRST = new System.Windows.Forms.Button();
            this.Btn_NEW = new System.Windows.Forms.Button();
            this.BTN_modyfy = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.bTN_LIST = new System.Windows.Forms.Button();
            this.bTN_ADD = new System.Windows.Forms.Button();
            this.dateTimePicker1pro = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2pro = new System.Windows.Forms.DateTimePicker();
            this.Btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1pRODUIT)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1pRODUIT
            // 
            this.dataGridView1pRODUIT.AllowUserToAddRows = false;
            this.dataGridView1pRODUIT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1pRODUIT.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1pRODUIT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1pRODUIT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1pRODUIT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1pRODUIT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1pRODUIT.Location = new System.Drawing.Point(370, 118);
            this.dataGridView1pRODUIT.Name = "dataGridView1pRODUIT";
            this.dataGridView1pRODUIT.Size = new System.Drawing.Size(752, 329);
            this.dataGridView1pRODUIT.TabIndex = 51;
            this.dataGridView1pRODUIT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1pRODUIT_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID_Produite";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom Produit :";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prix :";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "N° Série :";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Production ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date expiration :";
            this.Column6.Name = "Column6";
            // 
            // search_textBox7
            // 
            this.search_textBox7.Location = new System.Drawing.Point(918, 459);
            this.search_textBox7.Name = "search_textBox7";
            this.search_textBox7.Size = new System.Drawing.Size(100, 20);
            this.search_textBox7.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Date Expiration :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Date Production  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Donnez le nom pour chercher :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "N° Série :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Prix Produit :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nom De Produit :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID :";
            // 
            // Nserie_textBox4
            // 
            this.Nserie_textBox4.Location = new System.Drawing.Point(155, 144);
            this.Nserie_textBox4.Name = "Nserie_textBox4";
            this.Nserie_textBox4.Size = new System.Drawing.Size(100, 20);
            this.Nserie_textBox4.TabIndex = 40;
            // 
            // Prix_textBox3
            // 
            this.Prix_textBox3.Location = new System.Drawing.Point(137, 210);
            this.Prix_textBox3.Name = "Prix_textBox3";
            this.Prix_textBox3.Size = new System.Drawing.Size(100, 20);
            this.Prix_textBox3.TabIndex = 39;
            // 
            // Nom_textBox2
            // 
            this.Nom_textBox2.Location = new System.Drawing.Point(155, 83);
            this.Nom_textBox2.Name = "Nom_textBox2";
            this.Nom_textBox2.Size = new System.Drawing.Size(100, 20);
            this.Nom_textBox2.TabIndex = 38;
            // 
            // ID_textBox1
            // 
            this.ID_textBox1.Location = new System.Drawing.Point(155, 20);
            this.ID_textBox1.Name = "ID_textBox1";
            this.ID_textBox1.Size = new System.Drawing.Size(100, 20);
            this.ID_textBox1.TabIndex = 37;
            // 
            // Btn_Search_text
            // 
            this.Btn_Search_text.Location = new System.Drawing.Point(1047, 456);
            this.Btn_Search_text.Name = "Btn_Search_text";
            this.Btn_Search_text.Size = new System.Drawing.Size(75, 23);
            this.Btn_Search_text.TabIndex = 36;
            this.Btn_Search_text.Text = "Search";
            this.Btn_Search_text.UseVisualStyleBackColor = true;
            this.Btn_Search_text.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Last
            // 
            this.Btn_Last.Location = new System.Drawing.Point(243, 424);
            this.Btn_Last.Name = "Btn_Last";
            this.Btn_Last.Size = new System.Drawing.Size(36, 23);
            this.Btn_Last.TabIndex = 35;
            this.Btn_Last.Text = "Last";
            this.Btn_Last.UseVisualStyleBackColor = true;
            this.Btn_Last.Click += new System.EventHandler(this.Btn_Last_Click);
            // 
            // Btn_Privously
            // 
            this.Btn_Privously.Location = new System.Drawing.Point(155, 424);
            this.Btn_Privously.Name = "Btn_Privously";
            this.Btn_Privously.Size = new System.Drawing.Size(70, 23);
            this.Btn_Privously.TabIndex = 34;
            this.Btn_Privously.Text = "Previously";
            this.Btn_Privously.UseVisualStyleBackColor = true;
            this.Btn_Privously.Click += new System.EventHandler(this.Btn_Privously_Click);
            // 
            // bTN_next
            // 
            this.bTN_next.Location = new System.Drawing.Point(99, 424);
            this.bTN_next.Name = "bTN_next";
            this.bTN_next.Size = new System.Drawing.Size(41, 23);
            this.bTN_next.TabIndex = 33;
            this.bTN_next.Text = "Next";
            this.bTN_next.UseVisualStyleBackColor = true;
            this.bTN_next.Click += new System.EventHandler(this.bTN_next_Click);
            // 
            // BTN_FIRST
            // 
            this.BTN_FIRST.Location = new System.Drawing.Point(52, 424);
            this.BTN_FIRST.Name = "BTN_FIRST";
            this.BTN_FIRST.Size = new System.Drawing.Size(41, 23);
            this.BTN_FIRST.TabIndex = 32;
            this.BTN_FIRST.Text = "First";
            this.BTN_FIRST.UseVisualStyleBackColor = true;
            this.BTN_FIRST.Click += new System.EventHandler(this.BTN_FIRST_Click);
            // 
            // Btn_NEW
            // 
            this.Btn_NEW.BackColor = System.Drawing.Color.White;
            this.Btn_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NEW.Location = new System.Drawing.Point(962, 42);
            this.Btn_NEW.Name = "Btn_NEW";
            this.Btn_NEW.Size = new System.Drawing.Size(75, 23);
            this.Btn_NEW.TabIndex = 31;
            this.Btn_NEW.Text = "Nouveau ";
            this.Btn_NEW.UseVisualStyleBackColor = false;
            this.Btn_NEW.Click += new System.EventHandler(this.Btn_NEW_Click);
            // 
            // BTN_modyfy
            // 
            this.BTN_modyfy.BackColor = System.Drawing.Color.White;
            this.BTN_modyfy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_modyfy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_modyfy.Location = new System.Drawing.Point(829, 42);
            this.BTN_modyfy.Name = "BTN_modyfy";
            this.BTN_modyfy.Size = new System.Drawing.Size(75, 23);
            this.BTN_modyfy.TabIndex = 30;
            this.BTN_modyfy.Text = "Modifier";
            this.BTN_modyfy.UseVisualStyleBackColor = false;
            this.BTN_modyfy.Click += new System.EventHandler(this.BTN_modyfy_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.White;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(722, 42);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 29;
            this.Btn_Delete.Text = "Supriméz";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // bTN_LIST
            // 
            this.bTN_LIST.BackColor = System.Drawing.Color.White;
            this.bTN_LIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTN_LIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTN_LIST.Location = new System.Drawing.Point(610, 42);
            this.bTN_LIST.Name = "bTN_LIST";
            this.bTN_LIST.Size = new System.Drawing.Size(75, 23);
            this.bTN_LIST.TabIndex = 28;
            this.bTN_LIST.Text = "Afficher";
            this.bTN_LIST.UseVisualStyleBackColor = false;
            this.bTN_LIST.Click += new System.EventHandler(this.bTN_LIST_Click);
            // 
            // bTN_ADD
            // 
            this.bTN_ADD.BackColor = System.Drawing.Color.White;
            this.bTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTN_ADD.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTN_ADD.ForeColor = System.Drawing.Color.Black;
            this.bTN_ADD.Location = new System.Drawing.Point(492, 42);
            this.bTN_ADD.Name = "bTN_ADD";
            this.bTN_ADD.Size = new System.Drawing.Size(75, 23);
            this.bTN_ADD.TabIndex = 27;
            this.bTN_ADD.Text = "Ajoutez";
            this.bTN_ADD.UseVisualStyleBackColor = false;
            this.bTN_ADD.Click += new System.EventHandler(this.bTN_ADD_Click);
            // 
            // dateTimePicker1pro
            // 
            this.dateTimePicker1pro.Location = new System.Drawing.Point(155, 269);
            this.dateTimePicker1pro.Name = "dateTimePicker1pro";
            this.dateTimePicker1pro.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1pro.TabIndex = 52;
            // 
            // dateTimePicker2pro
            // 
            this.dateTimePicker2pro.Location = new System.Drawing.Point(155, 337);
            this.dateTimePicker2pro.Name = "dateTimePicker2pro";
            this.dateTimePicker2pro.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2pro.TabIndex = 53;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Red;
            this.Btn_Close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Close.Location = new System.Drawing.Point(1104, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(40, 26);
            this.Btn_Close.TabIndex = 54;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacie_Project.Properties.Resources.pharmacy_racks_66_1;
            this.ClientSize = new System.Drawing.Size(1143, 502);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.dateTimePicker2pro);
            this.Controls.Add(this.dateTimePicker1pro);
            this.Controls.Add(this.dataGridView1pRODUIT);
            this.Controls.Add(this.search_textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nserie_textBox4);
            this.Controls.Add(this.Prix_textBox3);
            this.Controls.Add(this.Nom_textBox2);
            this.Controls.Add(this.ID_textBox1);
            this.Controls.Add(this.Btn_Search_text);
            this.Controls.Add(this.Btn_Last);
            this.Controls.Add(this.Btn_Privously);
            this.Controls.Add(this.bTN_next);
            this.Controls.Add(this.BTN_FIRST);
            this.Controls.Add(this.Btn_NEW);
            this.Controls.Add(this.BTN_modyfy);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.bTN_LIST);
            this.Controls.Add(this.bTN_ADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1pRODUIT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1pRODUIT;
        private System.Windows.Forms.TextBox search_textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nserie_textBox4;
        private System.Windows.Forms.TextBox Prix_textBox3;
        private System.Windows.Forms.TextBox Nom_textBox2;
        private System.Windows.Forms.TextBox ID_textBox1;
        private System.Windows.Forms.Button Btn_Search_text;
        private System.Windows.Forms.Button Btn_Last;
        private System.Windows.Forms.Button Btn_Privously;
        private System.Windows.Forms.Button bTN_next;
        private System.Windows.Forms.Button BTN_FIRST;
        private System.Windows.Forms.Button Btn_NEW;
        private System.Windows.Forms.Button BTN_modyfy;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button bTN_LIST;
        private System.Windows.Forms.Button bTN_ADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1pro;
        private System.Windows.Forms.DateTimePicker dateTimePicker2pro;
        private System.Windows.Forms.Button Btn_Close;
    }
}