using MySql.Data.MySqlClient;

namespace TDSQueueClass
{
    public static class Banco
    {
        /// <summary>
        /// Abre uma conexão com o banco de dados.
        /// </summary>
        /// <returns>Um objetos de comandos Mysql com uma conexão aberta.</returns>
        
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
