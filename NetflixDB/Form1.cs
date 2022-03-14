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

namespace NetflixDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-A7ECOHN\SQLEXPRESS;Initial Catalog=NetflixDB;Integrated Security=True");
        SqlCommand Cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        BindingManagerBase bnd;

        private void Form1_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Genre", cnx);
            da.Fill(ds, "Genre");

           
            dataGridView1.DataSource = ds.Tables["Genre"];



            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["Genre"].NewRow();
            r[0] = textBox1.Text;
            r[1] = textBox2.Text;


            ds.Tables["Genre"].Rows.Add(r);
            MessageBox.Show("Ajout bien fait ! ");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Donner le code de Genre");
            }
            else
            {
                DataRow d = ds.Tables["Genre"].Select("CodeGenre='" + textBox1.Text + "'")[0];
                d[1] = textBox2.Text;
               
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Donner le code de Genre");
            }
            else
            {
                ds.Tables["Genre"].Select("CodeGenre='" + textBox1.Text + "'")[0].Delete();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder b = new SqlCommandBuilder(da);
            da.Update(ds.Tables["Genre"]);
            MessageBox.Show("bien enregistrer");
        }

        int pos;
        public void navigation()
        {
            try
            {
                textBox1.Text = ds.Tables["Genre"].Rows[pos][0].ToString();
                textBox2.Text = ds.Tables["Genre"].Rows[pos][1].ToString();
               
            }
            catch
            {
                MessageBox.Show("fin !!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pos = 0;
            navigation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos -= 1;
            navigation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pos += 1;
            navigation();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            pos = ds.Tables["Genre"].Rows.Count - 1;
            navigation();
        }
    }
}
