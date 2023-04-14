using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using static TestCRUDApp.Data.DBConnection;
using static TestCRUDApp.TodoCMD;
using TestCRUDApp.Data;
using System.Data;

namespace TestCRUDApp
{
    public partial class Form1 : Form
    {
        DBConnection conDB = new DBConnection();
        public TextBox Textbox;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TaskID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int taskID = int.Parse(TaskID.SelectedItem.ToString());

            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand($"SELECT TaskTitle, TaskDescription FROM Tasks WHERE TaskID = {taskID}", con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TaskTitlebtn.Text = reader.GetString(0);
                    TaskDesbtn.Text = reader.GetString(1);
                }
                else
                {
                    MessageBox.Show("No matching record found");
                }

                reader.Close();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this task?", 
                    "Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    OpenConnection();
                    int taskID = 0;
                    if (TaskID != null && TaskID.SelectedItem != null && int.TryParse(TaskID.SelectedItem.ToString(), out taskID))
                    {
                        SqlCommand cmd = new SqlCommand($"UPDATE Tasks SET TaskDescription = '{TaskDesbtn.Text}', TaskTitle = '{TaskTitlebtn.Text}', CreatedDate = '{dateTimePicker1.Value}', CompletionDate = '{dateTimePicker2.Value}', ScheduledDate = '{dateTimePicker3.Value}' WHERE TaskID = {taskID}", con);

                        var rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully updated");
                        }
                        else
                        {
                            MessageBox.Show("No rows updated");
                        }
                        DisplayTodo(dataGridView1);
                        CloseConnection();
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid task ID");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayTodo(dataGridView1);
            TaskIDList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenConnection();
            int taskID = int.Parse(TaskID.SelectedItem.ToString());
            DeleteTodo(taskID);
            TaskIDList();
            DisplayTodo(dataGridView1);
            CloseConnection();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            InsertTodo();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                var search = SearchTextbox.Text;
                var dt = SearchRecord(search);
                dataGridView1.DataSource = dt;
                //dt.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { CloseConnection(); }
            
        }       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void TaskIDList()
        {
            OpenConnection();
            string sql = "Select TaskID from Tasks";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TaskID.Items.Add(dr["TaskID"].ToString());
            }
            CloseConnection();
        }
        public void InsertTodo()
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand($"insert into Tasks values('{TaskDesbtn.Text}','{TaskTitlebtn.Text}','{dateTimePicker1.Text}','{dateTimePicker2.Text}','{dateTimePicker3.Text}')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                DisplayTodo(dataGridView1);
                CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Inappropriate entry");
            }
        }
    }
}

