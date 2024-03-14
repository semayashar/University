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
    public partial class Professors : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sema_\Documents\UniversityRLDb.mdf;Integrated Security=True;Connect Timeout=30");
        int Key = 0;

        public Professors()
        {
            InitializeComponent();
            ShowProfessors();
            getDepId();
        }

        private void ShowProfessors()
        {
            //connection.Open();
            string query = "SELECT * FROM ProfessorTbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            ProfDGV.DataSource = dataSet.Tables[0];
            //connection.Close();
        }

        private void getDepId()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select dep_ID, dep_Name from DepartmentTbl", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                prof_DepIDcb.ValueMember = "dep_ID";
                prof_DepIDcb.DataSource = dt;
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

        private void getDepName()
        {
            try
            {
                connection.Open();
                String query = "SELECT dep_Name FROM DepartmentTbl WHERE dep_ID = @DepID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DepID", prof_DepIDcb.SelectedValue);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    prof_DepNametb.Text = result.ToString();
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
            finally
            {
                connection.Close();
            }
        }

        private void ResetInputs()
        {
            prof_Namet.Text = "";
            prof_Gendercb.SelectedIndex = -1;
            prof_Addresstb.Text = "";
            prof_DepNametb.Text = "";
            prof_DepIDcb.SelectedIndex = -1;
            prof_Qualcb.SelectedIndex = -1;
            prof_Experience.Text = "";
            prof_Salary.Text = "";
        }

        private void ProfDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProfDGV.Rows[e.RowIndex];
                Key = Convert.ToInt32(row.Cells["prof_ID"].Value);
                prof_Namet.Text = row.Cells["prof_Name"].Value.ToString();
                prof_DOBdtp.Text = row.Cells["prof_DOB"].Value.ToString();
                prof_Gendercb.SelectedItem = row.Cells["prof_Gender"].Value.ToString();
                prof_Addresstb.Text = row.Cells["prof_Addres"].Value.ToString();
                prof_DepNametb.Text = row.Cells["prof_DepName"].Value.ToString();
                prof_DepIDcb.SelectedValue = row.Cells["prof_DepID"].Value; // Ensure proper selection
                prof_Qualcb.SelectedItem = row.Cells["prof_Qual"].Value.ToString();
                prof_Experience.Text = row.Cells["prof_Exper"].Value.ToString();
                prof_Salary.Text = row.Cells["prof_Salary"].Value.ToString();
            }
        }


        private void prof_Save_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO ProfessorTbl (prof_Name, prof_DOB, prof_Gender, prof_Addres, prof_DepName, prof_DepID, prof_Qual, prof_Exper, prof_Salary) " +
                    "VALUES (@profName, @profDOB, @profGender, @profAddress, @profDepName, @profDepID, @profQualification, @profExperience, @profSalary)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@profName", prof_Namet.Text);
                cmd.Parameters.AddWithValue("@profDOB", prof_DOBdtp.Value);
                cmd.Parameters.AddWithValue("@profGender", prof_Gendercb.SelectedItem.ToString()); // Change from SelectedValue to SelectedItem
                cmd.Parameters.AddWithValue("@profAddress", prof_Addresstb.Text);
                cmd.Parameters.AddWithValue("@profDepName", prof_DepNametb.Text);
                cmd.Parameters.AddWithValue("@profDepID", prof_DepIDcb.SelectedValue);
                cmd.Parameters.AddWithValue("@profQualification", prof_Qualcb.SelectedItem.ToString()); // Change from SelectedValue to SelectedItem
                cmd.Parameters.AddWithValue("@profExperience", prof_Experience.Text);
                cmd.Parameters.AddWithValue("@profSalary", prof_Salary.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Professor information saved successfully");
                ResetInputs();
                ShowProfessors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Ensure the connection is closed even if an exception occurs
            }
        }

        private void prof_DepIDcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getDepName();
        }

        private void prof_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "UPDATE ProfessorTbl SET prof_Name = @profName, prof_DOB = @profDOB, prof_Gender = @profGender, " +
                               "prof_Addres = @profAddress, prof_DepName = @profDepName, prof_DepID = @profDepID, " +
                               "prof_Qual = @profQualification, prof_Exper = @profExperience, " +
                               "prof_Salary = @profSalary WHERE prof_ID = @profID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@profID", Key);
                cmd.Parameters.AddWithValue("@profName", prof_Namet.Text);
                cmd.Parameters.AddWithValue("@profDOB", prof_DOBdtp.Value);
                cmd.Parameters.AddWithValue("@profGender", prof_Gendercb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@profAddress", prof_Addresstb.Text);
                cmd.Parameters.AddWithValue("@profDepName", prof_DepNametb.Text);
                cmd.Parameters.AddWithValue("@profDepID", prof_DepIDcb.SelectedValue);
                cmd.Parameters.AddWithValue("@profQualification", prof_Qualcb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@profExperience", prof_Experience.Text);
                cmd.Parameters.AddWithValue("@profSalary", prof_Salary.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Professor information updated successfully");
                ResetInputs();
                ShowProfessors();
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

        private void prof_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM ProfessorTbl WHERE prof_ID = @profID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@profID", Key);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Professor information deleted successfully");
                ResetInputs();
                ShowProfessors();
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
