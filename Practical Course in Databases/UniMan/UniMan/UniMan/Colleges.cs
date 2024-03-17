using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniMan
{
    public partial class Colleges : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sema_\Documents\UniversityRLDb.mdf;Integrated Security=True;Connect Timeout=30");
        int Key = 0;

        public Colleges()
        {
            InitializeComponent();
            showColleges();
        }

        private void showColleges()
        {
            string query = "SELECT * FROM CollegeTbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            ColDGV.DataSource = dataSet.Tables[0];
        }
        private void ColDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ColDGV.Rows[e.RowIndex];
                Key = Convert.ToInt32(row.Cells["col_ID"].Value);
                col_Nametb.Text = row.Cells["col_Name"].Value.ToString();
                col_PrincNametb.Text = row.Cells["col_Principal"].Value.ToString();
                col_PrincDOBdp.Value = Convert.ToDateTime(row.Cells["col_Date"].Value);
                col_Loctb.Text = row.Cells["col_Location"].Value.ToString();
            }
        }


        private void col_Save_Click(object sender, EventArgs e)
        {
            if (col_Nametb.Text != "" && col_PrincNametb.Text != "" && col_PrincDOBdp.Text != "" && col_Loctb.Text != "")
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO CollegeTbl VALUES (@name, @principal, @dob, @location)", connection);
                command.Parameters.AddWithValue("@name", col_Nametb.Text);
                command.Parameters.AddWithValue("@principal", col_PrincNametb.Text);
                command.Parameters.AddWithValue("@dob", col_PrincDOBdp.Value.Date);
                command.Parameters.AddWithValue("@location", col_Loctb.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Saved Successfully!");
                showColleges();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }

        private void col_Edit_Click(object sender, EventArgs e)
        {
            if (Key != 0)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE CollegeTbl SET col_Name=@name, col_Principal=@principal, col_Date=@dob, col_Location=@location WHERE col_ID=@id", connection);
                command.Parameters.AddWithValue("@name", col_Nametb.Text);
                command.Parameters.AddWithValue("@principal", col_PrincNametb.Text);
                command.Parameters.AddWithValue("@dob", col_PrincDOBdp.Value.Date);
                command.Parameters.AddWithValue("@location", col_Loctb.Text);
                command.Parameters.AddWithValue("@id", Key);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Updated Successfully!");
                showColleges();
            }
            else
            {
                MessageBox.Show("Select a college to update!");
            }
        }

        private void col_Delete_Click(object sender, EventArgs e)
        {
            if (Key != 0)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM CollegeTbl WHERE col_ID=@id", connection);
                command.Parameters.AddWithValue("@id", Key);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Deleted Successfully!");
                showColleges();
            }
            else
            {
                MessageBox.Show("Select a college to delete!");
            }
        }
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }

        private void studBtn_Click(object sender, EventArgs e)
        {
            Students Obj = new Students();
            Obj.Show();
            this.Hide();
        }

        private void depBtn_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }

        private void profBtn_Click(object sender, EventArgs e)
        {
            Professors Obj = new Professors();
            Obj.Show();
            this.Hide();
        }

        private void courBtn_Click(object sender, EventArgs e)
        {
            Courses Obj = new Courses();
            Obj.Show();
            this.Hide();
        }

        private void colBtn_Click(object sender, EventArgs e)
        {
            Colleges Obj = new Colleges();
            Obj.Show();
            this.Hide();
        }

        private void feesBtn_Click(object sender, EventArgs e)
        {
            Fees Obj = new Fees();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LogInForm Obj = new LogInForm();
            Obj.Show();
            this.Hide();
        }

        private void salaryBtn_Click(object sender, EventArgs e)
        {
            Fees Obj = new Fees();
            Obj.Show();
            this.Hide();
        }
    }
}
