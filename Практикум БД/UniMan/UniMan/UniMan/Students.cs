using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace UniMan
{
    public partial class Students : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sema_\Documents\UniversityRLDb.mdf;Integrated Security=True;Connect Timeout=30");
        int Key = 0;

        public Students()
        {
            InitializeComponent();
            ShowStudents();
            getDepId();
        }

        private void ShowStudents()
        {
            //connection.Open();
            string query = "SELECT * FROM StudentTbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            StudDGV.DataSource = dataSet.Tables[0];
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
                studDepIDcb.ValueMember = "dep_ID";
                studDepIDcb.DataSource = dt;
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
                cmd.Parameters.AddWithValue("@DepID", studDepIDcb.SelectedValue);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    studDepNamet.Text = result.ToString();
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

        private void ResetInputs()
        {
            studNamet.Text = "";
            //studDOBTP.Value = ;
            studGenderCB.SelectedIndex = -1;
            studAdresstb.Text = "";
            studDepNamet.Text = "";
            studDepIDcb.SelectedIndex = -1;
            studSemcb.Text = "";
            studTelTb.Text = "";
        }

        private void StudDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = StudDGV.Rows[e.RowIndex];
                Key = Convert.ToInt32(row.Cells["stud_ID"].Value);
                studNamet.Text = row.Cells["stud_Name"].Value.ToString();
                studDOBTP.Text = row.Cells["stud_DOB"].Value.ToString();
                studGenderCB.Text = row.Cells["stud_Gender"].Value.ToString();
                studAdresstb.Text = row.Cells["stud_Address"].Value.ToString();
                studDepNamet.Text = row.Cells["stud_DepName"].Value.ToString();
                studDepIdtb.Text = row.Cells["stud_DepID"].Value.ToString();
                studSemcb.Text = row.Cells["stud_Semester"].Value.ToString();
                studTelTb.Text = row.Cells["stud_Phone"].Value.ToString();
            }
        }

        private void studSave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO StudentTbl (stud_Name, stud_DOB, stud_Gender, stud_Address, stud_DepName, stud_DepID, stud_Semester, stud_Phone) " +
                               "VALUES (@studName, @studDOB, @studGender, @studAddress, @studDepName, @studDepID, @studSemester, @studPhone)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@studName", studNamet.Text);
                cmd.Parameters.AddWithValue("@studDOB", studDOBTP.Value);
                cmd.Parameters.AddWithValue("@studGender", studGenderCB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@studAddress", studAdresstb.Text);
                cmd.Parameters.AddWithValue("@studDepName", studDepNamet.Text);
                cmd.Parameters.AddWithValue("@studDepID", studDepIDcb.SelectedValue);
                cmd.Parameters.AddWithValue("@studSemester", studSemcb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@studPhone", studTelTb.Text);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Student information saved successfully");
                ResetInputs();
                ShowStudents();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void studDel_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a student to delete");
                return;
            }

            try
            {
                connection.Open();
                string query = "DELETE FROM StudentTbl WHERE stud_ID=@studID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@studID", Key);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student deleted successfully");
                    ResetInputs();
                    ShowStudents(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("No student was deleted");
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

        private void studEdit_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a student to edit");
                return;
            }

            try
            {
                connection.Open();
                string query = "UPDATE StudentTbl SET stud_Name = @studName, stud_DOB = @studDOB, stud_Gender = @studGender, stud_Address = @studAddress, stud_DepName = @studDepName, stud_DepID = @studDepID, stud_Semester = @studSemester, stud_Phone = @studPhone WHERE stud_ID = @studID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@studID", Key);
                cmd.Parameters.AddWithValue("@studName", studNamet.Text);
                cmd.Parameters.AddWithValue("@studDOB", studDOBTP.Value);
                cmd.Parameters.AddWithValue("@studGender", studGenderCB.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@studAddress", studAdresstb.Text);
                cmd.Parameters.AddWithValue("@studDepName", studDepNamet.Text);
                cmd.Parameters.AddWithValue("@studDepID", studDepIDcb.SelectedValue);
                cmd.Parameters.AddWithValue("@studSemester", studSemcb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@studPhone", studTelTb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student information updated successfully");
                ResetInputs();
                ShowStudents();
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

        private void studDepIDcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getDepName();
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
