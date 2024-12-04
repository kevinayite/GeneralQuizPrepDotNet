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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection("Data Source=WILLIAM\\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");


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

            private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirm.Text)
            {
                int phone = int.Parse(textBoxPhone.Text);
                string pwd = encryptPwd(textBoxPassword.Text);
                String type = comboBox1.Text;
                string qry = "INSERT INTO utilisateurs VALUES ('" + phone + "','" + pwd + "', '"+type+"')";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New user created " + phone);
                //DisplayData();

                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mismatching pwd");

            }
        }
    }
    
}
