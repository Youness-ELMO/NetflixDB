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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-A7ECOHN\SQLEXPRESS;Initial Catalog=NetflixDB;Integrated Security=True");
        SqlCommand Cmd = new SqlCommand();
        DataSet ds = new DataSet();
       
        SqlDataAdapter daserie;
        SqlDataAdapter dagenre;


        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'netflixDBDataSet2.Serie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.serieTableAdapter.Fill(this.netflixDBDataSet2.Serie);
            // TODO: cette ligne de code charge les données dans la table 'netflixDBDataSet1.Genre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.genreTableAdapter1.Fill(this.netflixDBDataSet1.Genre);
            // TODO: cette ligne de code charge les données dans la table 'netflixDBDataSet.Genre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.genreTableAdapter.Fill(this.netflixDBDataSet.Genre);



            daserie = new SqlDataAdapter("select * from Serie ", cnx);
            daserie.Fill(ds, "Serie");

            dagenre = new SqlDataAdapter("select * from Genre ", cnx);
            dagenre.Fill(ds, "Genre");




            DataColumn[] cols_S = { ds.Tables["Serie"].Columns["codeserie"] };
            ds.Tables["Serie"].PrimaryKey = cols_S;
            DataColumn[] cols_G = { ds.Tables["Genre"].Columns["CodeGenre"] };
            ds.Tables["Genre"].PrimaryKey = cols_G;

            DataRelation drel = new DataRelation("serie-genre",
            ds.Tables["Genre"].Columns["CodeGenre"],
            ds.Tables["Serie"].Columns["CodeGenre"]);
            ds.Relations.Add(drel);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] r = ds.Tables["Serie"].Select("CodeGenre=" + comboBox1.SelectedValue + "");
            dataGridView1.DataSource = r.CopyToDataTable();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter daa = new SqlDataAdapter("select*from Serie join Genre on Serie.CodeGenre=Genre.CodeGenre where titreSerie ='" + comboBox2.Text + "'", cnx);
            
            DataSet d = new DataSet();
            daa.Fill(d, "IntituléTh");

            label4.Text = "" + d.Tables["intituleGenre"].Rows[0][0].ToString();
        }
    }
}
