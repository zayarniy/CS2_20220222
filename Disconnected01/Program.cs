using System;
using System.Data.SqlClient;

namespace AccessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //OleDbConnectionStringBuilder oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder();

            //Строка подключение
            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Accounts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\zaaza\source\repos\CS2_20220222\Disconnected01\bin\Debug\net6.0\Accounts.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //Объект подключение к базе данных
            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Account", connection);
                //SqlCommand command1 = new SqlCommand("Insert Into Account(nvcLogin,nvcPassword,bActive) Values ('Login','Password',1)",connection);
                //SqlCommand command1 = new SqlCommand("Delete From Account Where nvcLogin='root'", connection);
                SqlCommand command1 = new SqlCommand("Update Account Set nvcPassword='admin1' Where nvcLogin='admin'", connection);
                int n=command1.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                //OleDbDataReader reader = command.ExecuteScalar();
                while (reader.Read())//Считываем каждую строчку
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", (int)reader["id"], reader.GetString(1), reader.GetString(2), reader.GetBoolean(3));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection?.Close();
            }
            Console.ReadKey();
        }
    }
}