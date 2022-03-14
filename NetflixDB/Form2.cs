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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-A7ECOHN\SQLEXPRESS;Initial Catalog=NetflixDB;Integrated Security=True");
        SqlCommand Cmd = new SqlCommand();
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        BindingManagerBase bnd;
        private void button5_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["Serie"].NewRow();
            r[0] = textBox1.Text;
            r[1] = textBox2.Text;
            r[2] = dateTimePicker1.Value;
            r[3] = textBox3.Text;


            ds.Tables["Serie"].Rows.Add(r);
            MessageBox.Show("Ajout bien fait ! ");


           
        }


       
        private void Form2_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Serie", cnx);
            da.Fill(ds, "Serie");


            dataGridView1.DataSource = ds.Tables["Serie"];



           
        }

        int pos;
        public void navigation()
        {
            try
            {
                textBox1.Text = ds.Tables["Serie"].Rows[pos][0].ToString();
                textBox2.Text = ds.Tables["Serie"].Rows[pos][1].ToString();
               //datetimepircker
                textBox3.Text = ds.Tables["Serie"].Rows[pos][3].ToString();
            }
            catch
            {
                MessageBox.Show("fin !!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           pos=0;
            navigation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pos -= 1;
            navigation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pos +=1;
            navigation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             
            pos = ds.Tables["Serie"].Rows.Count - 1;
            navigation();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Donner le code de Serie");
            }
            else
            {
                DataRow r = ds.Tables["Serie"].Select("codeserie='" + textBox1.Text + "'")[0];
                r[1] = textBox2.Text;
                r[2] = dateTimePicker1.Value;
                r[3] = textBox3.Text;

                MessageBox.Show("MOodification bien fait ! ");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Donner le code de Serie");
            }
            else
            {
                ds.Tables["Serie"].Select("codeserie='" + textBox1.Text + "'")[0].Delete();
                MessageBox.Show("Suppression bien fait ! ");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder b = new SqlCommandBuilder(da);
            da.Update(ds.Tables["Serie"]);
            MessageBox.Show("bien enregistrer");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
            textBox3.Clear();
           

        }

        private void nouveau(object sender, EventArgs e)
        {

        }
    }
}
