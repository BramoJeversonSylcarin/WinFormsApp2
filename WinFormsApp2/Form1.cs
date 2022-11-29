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

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {


        static string chaine = @"Data Source=localhost;Initial Catalog=BDGED_copy;Integrated Security=True";
        "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        "Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from etudiants";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonConfirm_Click_data();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Dossier(ID_DOSSIER, NOM_DOSSIER) values('" + txtId_dossier.Text + "','" + txtNom_dossier.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update Dossier set NOM_DOSSIER='" + txtNom_dossier.Text + "' where ID_DOSSIER='" + txtId_dossier.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from DOSSIER";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from DOSSIER";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }
    }
    }
}
