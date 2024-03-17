using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UniMan
{
    public partial class Departments : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sema_\Documents\UniversityRLDb.mdf;Integrated Security=True;Connect Timeout=30";
        int Key = 0;

        public Departments()
        {
            InitializeComponent();
            ShowDepartments();
        }

        private void ShowDepartments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DepartmentTbl";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                DepDGV.DataSource = dataSet.Tables[0];
            }
        }

        private void ResetInputs()
        {
            DepNamet.Text = "";
            DepIntaket.Text = "";
            DepFeest.Text = "";
        }

        private void DepDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DepDGV.Rows[e.RowIndex];
                Key = Convert.ToInt32(row.Cells["dep_ID"].Value);
                DepNamet.Text = row.Cells["dep_Name"].Value.ToString();
                DepIntaket.Text = row.Cells["dep_Intake"].Value.ToString();
                DepFeest.Text = row.Cells["dep_Fees"].Value.ToString();
            }
        }

        private void DepSaveb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DepNamet.Text) || string.IsNullOrWhiteSpace(DepIntaket.Text) || string.IsNullOrWhiteSpace(DepFeest.Text))
            {
                MessageBox.Show("Please provide all information.");
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO DepartmentTbl(dep_Name, dep_Intake, dep_Fees) VALUES(@DN, @DI, @DF)", connection);
                        cmd.Parameters.AddWithValue("@DN", DepNamet.Text);
                        cmd.Parameters.AddWithValue("@DI", DepIntaket.Text);
                        cmd.Parameters.AddWithValue("@DF", DepFeest.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Department Added!");
                    ShowDepartments();
                    ResetInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DepDeleteb_Click(object sender, EventArgs e)
        {
            if (Key != 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM DepartmentTbl WHERE dep_ID=@DKey", connection);
                        cmd.Parameters.AddWithValue("@DKey", Key);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Department Deleted!");
                    ShowDepartments();
                    ResetInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a department to delete.");
            }
        }

        private void DepEditb_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = "UPDATE DepartmentTbl SET dep_Name=@DN, dep_Intake=@DI, dep_Fees=@DF WHERE dep_ID=@DKey";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@DN", DepNamet.Text);
                        cmd.Parameters.AddWithValue("@DI", DepIntaket.Text);
                        cmd.Parameters.AddWithValue("@DF", DepFeest.Text);
                        cmd.Parameters.AddWithValue("@DKey", Key);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Department Updated!");
                            ShowDepartments();
                            ResetInputs();
                        }
                        else
                        {
                            MessageBox.Show("No department updated. Verify the department ID.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
