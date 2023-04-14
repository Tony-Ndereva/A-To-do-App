using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static TestCRUDApp.Data.DBConnection;
using static TestCRUDApp.Form1;
using System.Threading.Tasks;

namespace TestCRUDApp
{
    public class TodoCMD
    {
        Form1 form1 = new Form1();
        public static DataGridView dataGridView1;
        public static TextBox TextBox;

        public static void DeleteTodo(int taskID)
        {
            OpenConnection();
           
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this task?", 
                "Confirmation", MessageBoxButtons.YesNo);
                       
            if (dialogResult == DialogResult.Yes)
            {
                string sql = $"DELETE FROM Tasks WHERE TaskID = {taskID}";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public static DataTable SearchRecord(string search)
        {
            OpenConnection();
            string sql = "SELECT * from Tasks WHERE TaskTitle = @search";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@search", search);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }      

    }

}

