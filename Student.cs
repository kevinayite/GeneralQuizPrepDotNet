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

namespace GeneralQuiz
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            PopulateUserTypes();
        }

        SqlConnection con = new SqlConnection("Data Source=WILLIAM\\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Students (studId, names, gender, campaignTitle, marks, request) " +
                              "VALUES (@ProductID, @ProductName, @UnitPrice, @Quantity, @DateAdded, @req)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ProductID", textBoxId.Text);
            cmd.Parameters.AddWithValue("@ProductName", textBoxNames.Text);
            cmd.Parameters.AddWithValue("@UnitPrice", comboBoxGender.Text);
            cmd.Parameters.AddWithValue("@Quantity", comboBoxCampaign.Text);
            cmd.Parameters.AddWithValue("@DateAdded", textBoxMarks.Text);
            cmd.Parameters.AddWithValue("@req", comboBoxRequest.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully inserted", "Success");
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Students");
            Students.DataSource = ds.Tables["Students"];
        }

        private void Student_Load(object sender, EventArgs e)
        {
           // DisplayStudents();
        }

        

        //Populating the combobox automatically with data from the db, campaign table and capaign column
        private void PopulateUserTypes()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT campaign FROM Campaign", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string campaignTitle = reader["Campaign"].ToString();
                    comboBoxCampaign.Items.Add(campaignTitle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


    }

        
    
}
