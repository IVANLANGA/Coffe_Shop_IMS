using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BeetleCaf
{
    public partial class Order : Form
    {

       
        SqlConnection connection = DatabaseConnector.OpenConnection();
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet dataset;
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            string comm = @"Select * FROM Drinks";

            try
            {
                    command = new SqlCommand(comm, connection);
                    adapter = new SqlDataAdapter(command);
                    adapter.SelectCommand = command;
                    dataset = new DataSet();
                    adapter.Fill(dataset, "Drinks");

                    //dataGridView1.DataSource = dataset;
                    //dataGridView1.DataMember = "Drinks";


                    reader = command.ExecuteReader();

                    //.while (reader.Read())
                    //{
                       // cmbCoffee.Items.Add(reader.GetValue(0));
                        //cmbTea.Items.Add(reader.GetValue(1));
                        //cmbPastry.Items.Add(reader.GetValue(2));
                        //cmbSandwich.Items.Add(reader.GetValue(3));
                    //}
                    reader.Close();
                
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnStage_Click(object sender, EventArgs e)
        {

        }
    }
}
