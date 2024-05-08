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

namespace MHR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void Button1_Click(object sender, EventArgs e)
        {

            string ConnectionString = "Data Source=DESKTOP-8OQ8UTE\\SQLEXPRESS;Initial Catalog=Nadra;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cnic = tbCNIC.Text;
            string name = tbName.Text;
            string fname = tbFName.Text;
            string age = tbFName.Text;
            string gender = tbGender.Text;


            string query = "INSERT INTO Citizen ( Name, Father,CNIC, Age, gender) VALUES ('" + name + "','" + fname + "','" + cnic + "','" + age + "','" + gender + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Inserted");

            tbCNIC.Text = "";
            tbName.Text = "";
            tbFName.Text = "";
            tbAge.Text = "";
            tbGender.Text = "";
        }

        private void TbName_Enter(object sender, EventArgs e)
        {
            tbName.Text = string.Empty;
        }

        private void TbFName_Enter(object sender, EventArgs e)
        {
            tbFName.Text = string.Empty;
        }

        private void TbCNIC_Enter(object sender, EventArgs e)
        {
            tbCNIC.Text = string.Empty;
        }

        private void TbAge_Enter(object sender, EventArgs e)
        {
            tbAge.Text = string.Empty;
        }

        private void TbGender_Enter(object sender, EventArgs e)
        {
            tbGender.Text = string.Empty;
        }

        private void View_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=DESKTOP-8OQ8UTE\\SQLEXPRESS;Initial Catalog=Nadra;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "SELECT * FROM Citizen";
            SqlCommand cmd = new SqlCommand(query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            viewField.DataSource = table;

            con.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=DESKTOP-8OQ8UTE\\SQLEXPRESS;Initial Catalog=Nadra;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cnic = tbCNIC.Text;
            string name = tbName.Text;
            string fname = tbFName.Text;
            string age = tbFName.Text;
            string gender = tbGender.Text;

            string query = "UPDATE Citizen SET Name = '" + name + "', Father = '" + fname + "', Age = '" + age + "', Gender = '" + gender + "' WHERE CNIC = '" + cnic + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated");

            tbCNIC.Text = "";
            tbName.Text = "";
            tbFName.Text = "";
            tbAge.Text = "";
            tbGender.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=DESKTOP-8OQ8UTE\\SQLEXPRESS;Initial Catalog=Nadra;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cnic = tbCNIC.Text;


            string query = "DELETE FROM Citizen WHERE CNIC = '" + cnic + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");

            tbCNIC.Text = "";
        }
    }
}
