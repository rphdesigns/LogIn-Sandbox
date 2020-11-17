using System.Data.SqlClient;
using System.Windows.Forms;


namespace LogIn_Sandbox.Home_Page
{
    public class DataBaseConnection
    {
        public static string conn;
        public static SqlConnection connect;
        SqlConnection cn = new SqlConnection();

        public static void db_connection()
        {
            //Database Connection
            try
            {
                //database connection string
                conn = @"Data Source=USPTCWHP6077634;Initial Catalog=MichaelsTestApp;Integrated Security=True";
                connect = new SqlConnection(conn);
                connect.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
    }

}