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
using System.Configuration;

namespace Polomka
{
    public partial class Main : Form
    {
        private SqlConnection sqlConnection = null;
        public Main()
        {
            InitializeComponent();
        }

        private void showClient_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectDB"].ConnectionString);
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from client", sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            serch.Visible = true;
            SerchText.Visible = true;
            SerchButton.Visible = true;
            delete.Visible = true;
        }

        private void addNewClient_Click(object sender, EventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SerchText.Text == "")
                MessageBox.Show("Заполните поля");
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(SerchText.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                    }
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Данная функция находиться в разработке");
            
        }
    }
}




