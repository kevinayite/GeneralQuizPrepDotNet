using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeneralQuiz
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
           // PopulateUserTypes();
        }

        SqlConnection con = new SqlConnection("Data Source=WILLIAM\\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");

        private void DisplayStudents()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Students");
            Candidates.DataSource = ds.Tables["Students"];
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE students SET names = @ProductName, gender = @UnitPrice, " +
                  "campaignTitle = @Quantity, marks = @ExpiryDate, request = @req WHERE studId = @ProductID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ProductID", textBoxId.Text);
            cmd.Parameters.AddWithValue("@ProductName", textBoxNames.Text);
            cmd.Parameters.AddWithValue("@UnitPrice",comboBoxGender.Text);
            cmd.Parameters.AddWithValue("@Quantity", comboBoxCampaign.Text);
            cmd.Parameters.AddWithValue("@ExpiryDate", textBoxMarks.Text);
            cmd.Parameters.AddWithValue("@req", comboBoxRequest.Text);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Successfully updated", "Success");
                DisplayStudents();
            }
            else
            {
                MessageBox.Show("No rows updated", "Information");
            }
        }

        private void Candidates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                foreach (DataGridViewRow row in Candidates.SelectedRows)
                {
                    textBoxId.Text = row.Cells[0].Value.ToString();
                    textBoxNames.Text = row.Cells[1].Value.ToString();
                    comboBoxGender.Text = row.Cells[2].Value.ToString();
                    comboBoxCampaign.Text = row.Cells[3].Value.ToString();
                    textBoxMarks.Text = row.Cells[4].Value.ToString();
                    comboBoxRequest.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Campaign ( campaign) " + "VALUES (@Quantity)";

            SqlCommand cmd = new SqlCommand(query, con);
            
            cmd.Parameters.AddWithValue("@Quantity", textBoxCampaigns.Text);
            

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully inserted", "Success");
           // DisplayStudents();
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            GenerateReportsToPDF();
        }

        private void GenerateReportsToPDF()
        {
            // Create a new PDF document
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("Reports.pdf", FileMode.Create));
            document.Open();

            // Query for approved students
            string approvedQuery = "SELECT * FROM Students WHERE marks >= 14";
            SqlDataAdapter approvedAdapter = new SqlDataAdapter(approvedQuery, con);
            DataTable approvedTable = new DataTable();
            approvedAdapter.Fill(approvedTable);

            // Add approved students to the PDF
            AddStudentsToPDF(document, "Approved Students", approvedTable);

            // Query for denied students
            string deniedQuery = "SELECT * FROM Students WHERE marks < 14";
            SqlDataAdapter deniedAdapter = new SqlDataAdapter(deniedQuery, con);
            DataTable deniedTable = new DataTable();
            deniedAdapter.Fill(deniedTable);

            // Add denied students to the PDF
            AddStudentsToPDF(document, "Denied Students", deniedTable);

            // Close the document
            document.Close();
            MessageBox.Show("PDF report generated successfully.", "Success");
        }

        private void AddStudentsToPDF(Document document, string title, DataTable table)
        {
            // Add title to the PDF
            document.Add(new Paragraph(title));

            // Create a table
            PdfPTable pdfTable = new PdfPTable(table.Columns.Count);

            // Add headers to the table
            foreach (DataColumn column in table.Columns)
            {
                pdfTable.AddCell(column.ColumnName);
            }

            // Add data rows to the table
            foreach (DataRow row in table.Rows)
            {
                foreach (var cell in row.ItemArray)
                {
                    pdfTable.AddCell(cell.ToString());
                }
            }

            // Add table to the document
            document.Add(pdfTable);
        }

    }
}
