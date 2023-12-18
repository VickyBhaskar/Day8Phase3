using System;
using System.Data.SqlClient;
namespace Day8AssignmentPart1
{
    internal class Program
    {
        static SqlDataReader SqlDataReader;


        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string constr = "Data Source=VICKY_BHASKAR;Initial Catalog=Day8;Integrated Security=True";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand
                {
                    Connection = con,
                    CommandText = "select * from Products Order by PName Desc"

                };
                con.Open();
                reader = cmd.ExecuteReader();
                Console.WriteLine("*******Product Details as follows*********\n");
                while (reader.Read())
                {
                    Console.WriteLine("PId:\t" + reader["Pid"]);
                    Console.WriteLine("Product Name:\t" + reader["PName"]);
                    Console.WriteLine("Product Price:\t" + reader["PPrice"]);
                    Console.WriteLine("Mfg Date:\t" + reader["MnfDate"]);
                    Console.WriteLine("Exp Date:\t" + reader["ExpDate"]);
                    Console.WriteLine("\n");
                    Console.WriteLine("--------------------------------------------------");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}