using System.Data;
using System.Data.SqlClient;

namespace UniMan
{
    public partial class Homes : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sema_\Documents\UniversityRLDb.mdf;Integrated Security=True;Connect Timeout=30");


        public Homes()
        {
            InitializeComponent();
            CountStud();
            CountDep();
            CountCol();
            CountFac();
            SumIncome();
            SumSalaries();
        }


        private void SumIncome()
        {
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(fee_Amount) from FeesTbl", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "")
            {
                home_FinancesInDepo.Text = "$ 0";
            }
            else
            {
                home_FinancesInDepo.Text = "$ " + dt.Rows[0][0].ToString();
            }
            connection.Close();
        }
        private void SumSalaries()
        {
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Sum(salary_Amount) from SalaryTbl", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "")
            {
                home_SalariesInDepo.Text = "$ 0";
            }
            else
            {
                home_SalariesInDepo.Text = "$ " + dt.Rows[0][0].ToString();
            }
            connection.Close();
        }


        private void CountStud()
        {
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from StudentTbl", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            home_StudCount.Text = dt.Rows[0][0].ToString();
            connection.Close();
        }
        private void CountDep()
        {
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DepartmentTbl", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            home_DepCount.Text = dt.Rows[0][0].ToString();
            connection.Close();
        }
        private void CountCol()
        {
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CollegeTbl", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            home_ColCount.Text = dt.Rows[0][0].ToString();
            connection.Close();
        }
        private void CountFac()
        {
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from CourseTbl", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            home_FacCount.Text = dt.Rows[0][0].ToString();
            connection.Close();
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
        private void feesBtn_Click(object sender, EventArgs e)
        {
            Fees Obj = new Fees();
            Obj.Show();
           this.Hide();
        }
        private void colBtn_Click(object sender, EventArgs e)
        {
            Colleges Obj = new Colleges();
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
