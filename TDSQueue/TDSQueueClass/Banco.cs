using MySql.Data.MySqlClient;

namespace TDSQueueClass
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new();
            string strConn = @"server=10.91.45.21;database=tdsqueuedb01;user=root;password=";
            MySqlConnection cn = new(strConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return cmd;
        }
    }
}
