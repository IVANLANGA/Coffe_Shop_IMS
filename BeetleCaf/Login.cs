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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BeetleCaf
{
    public partial class Login : Form
    {

        SqlConnection connection = DatabaseConnector.OpenConnection();
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet dataset;

        private string username;
        private string password;
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            username = txtUsername.Text;
            password = txtPassword.Text;

            if (authenticateUser(username, password))
            {
                Form1 main = Application.OpenForms.OfType<Form1>().FirstOrDefault();

                AdminPanel adminPanel = new AdminPanel();
                adminPanel.MdiParent = main;
                
                adminPanel.Show();
                this.Close();



            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
                        
        }
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblerror_Click(object sender, EventArgs e)
        {

        }

        public bool authenticateUser(string username, string password)
        {
            string query = "SELECT * FROM Staff WHERE Username = '" + username + "'  AND Password = '" + password + "'";
            bool authenticated = false;
            command = new SqlCommand(query, connection);

            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                authenticated = true;
            }

            reader.Close();
            return authenticated;
        }
    }
}
