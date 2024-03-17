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
    public partial class Courses : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sema_\Documents\UniversityRLDb.mdf;Integrated Security=True;Connect Timeout=30");
        int Key = 0;

        public Courses()
        {
            InitializeComponent();
            ShowCourses();
            getDepId();
            getProfId();
        }

        private void ShowCourses()
        {
            //connection.Open();
            string query = "SELECT * FROM CourseTbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            CourseDGV.DataSource = dataSet.Tables[0];
            //connection.Close();
        }

        private void getDepId()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select dep_ID from DepartmentTbl", connection);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("dep_ID", typeof(int));
                dt.Load(reader);
                course_DID.ValueMember = "dep_ID";
                course_DID.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connection.Close();
        }

        private void getDepName()
        {
            try
            {
                connection.Open();
                String query = "SELECT dep_Name FROM DepartmentTbl WHERE dep_ID = @DepID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DepID", course_DID.SelectedValue);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    course_DN.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Department not found for the selected ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connection.Close();
        }

        private void getProfId()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT prof_ID, prof_Name FROM ProfessorTbl", connection);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("prof_ID", typeof(int));
                dt.Load(reader);
                course_PID.ValueMember = "prof_ID";
                course_PID.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void getProfName()
        {
            try
            {
                connection.Open();
                String query = "SELECT prof_Name FROM ProfessorTbl WHERE prof_ID = @ProfID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProfID", course_PID.SelectedValue);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    course_PN.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Professor not found for the selected ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connection.Close();
        }

        private void CourseDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CourseDGV.Rows[e.RowIndex];
                Key = Convert.ToInt32(row.Cells["cors_ID"].Value);
                course_CN.Text = row.Cells["cors_Name"].Value.ToString();
                course_DN.Text = row.Cells["cors_DepName"].Value.ToString();
                course_PN.Text = row.Cells["cors_ProfName"].Value.ToString();
                course_DID.Text = row.Cells["cors_DepID"].Value.ToString();
                course_PID.Text = row.Cells["cors_ProfID"].Value.ToString();
                course_DurH.Text = row.Cells["cors_Duration"].Value.ToString();
            }
        }

        private void course_PID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getProfName();
        }

        private void course_DID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getDepName();
        }

        private void course_save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CourseTbl (cors_Name, cors_DepName, cors_ProfName, cors_DepID, cors_ProfID, cors_Duration) " +
                                                 "VALUES (@Name, @DepName, @ProfName, @DepID, @ProfID, @Duration)", connection);
                cmd.Parameters.AddWithValue("@Name", course_CN.Text);
                cmd.Parameters.AddWithValue("@DepName", course_DN.Text);
                cmd.Parameters.AddWithValue("@ProfName", course_PN.Text);
                cmd.Parameters.AddWithValue("@DepID", course_DID.SelectedValue);
                cmd.Parameters.AddWithValue("@ProfID", course_PID.SelectedValue);
                cmd.Parameters.AddWithValue("@Duration", course_DurH.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course saved successfully.");
                    ShowCourses();
                }
                else
                {
                    MessageBox.Show("Failed to save course.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void course_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CourseTbl SET cors_Name = @Name, cors_DepName = @DepName, cors_ProfName = @ProfName, " +
                                                 "cors_DepID = @DepID, cors_ProfID = @ProfID, cors_Duration = @Duration WHERE cors_ID = @ID", connection);
                cmd.Parameters.AddWithValue("@Name", course_CN.Text);
                cmd.Parameters.AddWithValue("@DepName", course_DN.Text);
                cmd.Parameters.AddWithValue("@ProfName", course_PN.Text);
                cmd.Parameters.AddWithValue("@DepID", course_DID.SelectedValue);
                cmd.Parameters.AddWithValue("@ProfID", course_PID.SelectedValue);
                cmd.Parameters.AddWithValue("@Duration", course_DurH.Text);
                cmd.Parameters.AddWithValue("@ID", Key);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course updated successfully.");
                    ShowCourses();
                }
                else
                {
                    MessageBox.Show("Failed to update course.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void course_delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM CourseTbl WHERE cors_ID = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", Key);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course deleted successfully.");
                    ShowCourses();
                    course_CN.Text = "";
                    course_DN.Text = "";
                    course_PN.Text = "";
                    course_DID.SelectedIndex = -1;
                    course_PID.SelectedIndex = -1;
                    course_DurH.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to delete course.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
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
