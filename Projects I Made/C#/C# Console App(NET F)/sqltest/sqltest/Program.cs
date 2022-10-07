using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sqltest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login = "server = 172.19.176.160; uid = JJ; pwd = 1234; database = Test";
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = login;
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }
            conn.Open();
            Console.WriteLine("Du er nu logget ind på databasen!");


            Console.Write("Indtast navn: ");
            string navn = Console.ReadLine();
            Console.Write("Indtast alder: ");
            int alder = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast adresse: ");
            string adr = Console.ReadLine();
            // INSERT INTO tabelnavn (kolonne1, kolonne2, kolonne3)
            SqlCommand cmd = new SqlCommand($"INSERT INTO Person (Navn, Alder, Adresse) VALUES ('{navn}', '{alder}', '{adr}')", conn);
            cmd.ExecuteNonQuery();
            /* 
             * NonQuery: Opdater databasen, indsæt, slet, rediger værdier
             * Query: Læs enten alt eller specifikke ting fra databasen
            */
            Console.ReadKey();

            conn.Close();
        }
    }
}
