using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralQuiz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PopulateUserTypes();
        }
        SqlConnection con = new SqlConnection(@"Data Source=WILLIAM\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string phone = textBoxPhone.Text.Trim();
            string password = textBoxPassword.Text;
            string user = comboBox1.Text.Trim();

            if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Please fulfill the fields.");
                return;
            }

            // Select * from UserAccount where un='' pwd=''
            string userName = textBoxPhone.Text.Trim();
            string passwd = encryptPwd(textBoxPassword.Text);  // we need to encrypt what the user is giving to us first
            string typeUser = comboBox1.Text.Trim();
            if (validateUser(userName, passwd, typeUser))
            {
                MessageBox.Show("Success!!!!");
                if (typeUser == "Manager")
                {
                    Manager frm = new Manager();
                    frm.ShowDialog();
                }
                else
                {
                    Student frm = new Student();
                    frm.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Username and password are incorrect");
            }
        }

        private bool validateUser(string phone, string pwd, string type)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Utilisateurs WHERE phone=@uname and pwd=@pwd and type=@type", con);
                cmd.Parameters.AddWithValue("@uname", phone);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@type", type);
                int responseNo = Convert.ToInt32(cmd.ExecuteScalar());
                return responseNo == 1;
                //if(responseNo == 1)
                // MessageBox.Show("Response No:" + responseNo);
                return true;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close(); // Ensure connection is closed even in case of exception
            }
        }
        private string encryptPwd(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }

        }

        private void PopulateUserTypes()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT Type FROM Utilisateurs", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string userType = reader["Type"].ToString();
                    comboBox1.Items.Add(userType);
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



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 acc = new Form1();
            acc.ShowDialog();
        }
    }
}
