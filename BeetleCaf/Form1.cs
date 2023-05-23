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
    
    public partial class Form1 : Form
    {

        SqlConnection connection = DatabaseConnector.OpenConnection();
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet dataset;

        string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                connection = new SqlConnection(conn);
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void makeOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order orderForm = new Order();
            orderForm.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            
            login.ShowDialog();

           
    
        }

        


        //login.authenticateUser()
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
