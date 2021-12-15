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
    public partial class NewClient : Form
    {
        private SqlConnection sqlConnection = null;
        public NewClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(FirstNameText.Text=="")
                MessageBox.Show("Заполните поля");
            if(SecondNameText.Text=="")
                MessageBox.Show("Заполните поля");
            if(SurnameNameText.Text=="")
                MessageBox.Show("Заполните поля");
            if(BirthdayText.Text=="")
                MessageBox.Show("Заполните поля");
            if (EmailText.Text == "")
                MessageBox.Show("Заполните поля");
            if (PhoneText.Text == "")
                MessageBox.Show("Заполните поля");
            if (BirthdayText.Text == "")
                MessageBox.Show("Заполните поля");
            if (GenderText == null)
                MessageBox.Show("Заполните поля");
            else
            {
                SqlCommand sqlCommand = new SqlCommand("insert into  Client([FirstName],[LastName],[Patronymic],[Birthday],[RegistrationDate],[Email],[Phone],[GenderCode],)" +
                                                                                 "values(@firstname,@secondname,@surmane,@birthday,@regdate,@email,@phone,@gendergod)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("firstname", FirstNameText.Text);
                sqlCommand.Parameters.AddWithValue("secondmane", SecondNameText.Text);
                sqlCommand.Parameters.AddWithValue("surmane", SurnameNameText.Text);
                sqlCommand.Parameters.AddWithValue("birthday", BirthdayText.Text);
                sqlCommand.Parameters.AddWithValue("birthday", BirthdayText.Text);
                sqlCommand.Parameters.AddWithValue("regdate", DateTime.Now);
                sqlCommand.Parameters.AddWithValue("email", EmailText.Text);
                sqlCommand.Parameters.AddWithValue("gendergod", GenderText.SelectedIndex+1);
                MessageBox.Show(sqlCommand.ExecuteNonQuery().ToString());

            }
        }
    }
}


