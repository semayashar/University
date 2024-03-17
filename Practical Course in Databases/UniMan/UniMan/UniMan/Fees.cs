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
    public partial class Fees : Form
    {
        SqlConnection connection = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sema_\Documents\UniversityRLDb.mdf;Integrated Security=True;Connect Timeout=30");
        int Key = 0;

        public Fees()
        {
            InitializeComponent();
            ShowFees();
            ShowSalary();
            getStudId();
            getProfID();
        }

        //SHOW TABLE
        private void ShowFees()
        {
            string query = "SELECT * FROM FeesTbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            FeesDGV.DataSource = dataSet.Tables[0];
        }
        private void ShowSalary()
        {
            string query = "SELECT * FROM SalaryTbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            SalaryDGV.DataSource = dataSet.Tables[0];
        }


        //RESET INPUTS 
        private void ResetInputsFees()
        {
            fees_SIDcb.SelectedValue = -1;
            fees_SNtb.Text = "";
            //fees_Period.Text = "";
            fees_DNtb.Text = "";
            fees_Amount.Text = "";
            fees_Period.SelectedValue = -1;
        }
        private void ResetInputSalaries()
        {
            salary_PIDcb.Text = "";
            salary_PNtb.Text = "";
            salary_Amount.Text = "";
        }


        //GET PROFESSOR NAME AND ID
        private void getProfID()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT prof_ID FROM ProfessorTbl", connection);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("prof_ID", typeof(int));
                dt.Load(reader);
                salary_PIDcb.ValueMember = "prof_ID";
                salary_PIDcb.DataSource = dt;
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
                cmd.Parameters.AddWithValue("@ProfID", salary_PIDcb.SelectedValue);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    salary_PNtb.Text = result.ToString();
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


        //GET STUDENT NAME AND ID
        private void getStudId()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select stud_ID from StudentTbl", connection);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("stud_ID", typeof(int));
                dt.Load(reader);
                fees_SIDcb.ValueMember = "stud_ID";
                fees_SIDcb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connection.Close();
        }
        private void getStudName()
        {
            try
            {
                connection.Open();
                string query = "SELECT stud_Name, stud_DepName FROM StudentTbl WHERE stud_ID = @studID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@studID", fees_SIDcb.SelectedValue);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    fees_SNtb.Text = reader["stud_Name"].ToString();
                    fees_DNtb.Text = reader["stud_DepName"].ToString();
                }
                reader.Close();
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


        //FEES FUNCTIONS
        private void fees_Pay_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO FeesTbl (stud_ID, stud_Name, stud_DepName, fee_Period, fee_Amount, payDate) " +
                "VALUES (@studID, @studName, @studDepName, @feePeriod, @feeAmount, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@studID", fees_SIDcb.Text);
                cmd.Parameters.AddWithValue("@studName", fees_SNtb.Text);
                cmd.Parameters.AddWithValue("@studDepName", fees_DNtb.Text);
                cmd.Parameters.AddWithValue("@feePeriod", fees_Period.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@feeAmount", fees_Amount.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fee information saved successfully");
                ResetInputsFees();
                ShowFees();
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
        private void fees_SIDcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getStudName();
        }
        private void FeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = FeesDGV.Rows[e.RowIndex];
                Key = Convert.ToInt32(row.Cells["fee_ID"].Value);
                fees_SIDcb.SelectedValue = row.Cells["stud_ID"].Value;
                fees_SNtb.Text = row.Cells["stud_Name"].Value.ToString();
                fees_DNtb.Text = row.Cells["stud_DepName"].Value.ToString();
                fees_Amount.Text = row.Cells["fee_Amount"].Value.ToString();
                fees_Period.SelectedValue = row.Cells["payDate"].Value;
            }
        }


        //SALARY FUNCTIONS
        private void salary_Pay_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO SalaryTbl (salary_ProfID, salary_ProfName, salary_Period, salary_Amount) " +
                "VALUES (@profID, @profName, @salaryPeriod, @salaryAmount)";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@profID", salary_PIDcb.Text);
                cmd.Parameters.AddWithValue("@profName", salary_PNtb.Text);
                cmd.Parameters.AddWithValue("@salaryPeriod", salary_Period.Value);
                cmd.Parameters.AddWithValue("@salaryAmount", salary_Amount.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary information saved successfully");
                ResetInputSalaries();
                ShowSalary();
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
        private void salary_PIDcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getProfName();
        }
        private void SalaryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = SalaryDGV.Rows[e.RowIndex];
                Key = Convert.ToInt32(row.Cells["salary_ID"].Value);
                salary_PIDcb.SelectedValue = row.Cells["salary_ProfID"].Value;
                salary_PNtb.Text = row.Cells["salary_ProfName"].Value.ToString();
                salary_Period.Text = row.Cells["salary_Period"].Value.ToString();
                salary_Amount.Text = row.Cells["salary_Amount"].Value.ToString();
            }
        }


        //MENU OPTIONS
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
