using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TestCRUDApp.Data
{
    public class DBConnection
    {
        public static string conStr = "Data Source=DESKTOP-CMML9AE\\SQLEXPRESS;Initial Catalog=TodoAppDatabase;Integrated Security=True";
        public static SqlConnection con;
        public static DataGridView dataGridView;
        public static ComboBox comboBox;

        public static void OpenConnection()
        {
            con = new SqlConnection(conStr);
            con.Open();
        }
        public static void CloseConnection()
        {
            if (con != null)
            {
                con.Close();
            }
        }
        public static void DisplayTodo(DataGridView dgv)
        {
            string sql = "Select * from Tasks";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dgv != null)
                {
                    dgv.DataSource = dt;
                }
                CloseConnection();
            }

        }        

    }
}
