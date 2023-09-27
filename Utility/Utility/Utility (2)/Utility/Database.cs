using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Database
    {
       
        public SqlConnection Connection { get; set; }

        public Database(string nomeDB, string nomeServer = "GAMING-RIG")
        {
            Connection = new SqlConnection($"Data Source = {nomeServer};Initial Catalog = {nomeDB};Integrated Security = True");


        }
        public bool Update(string query)
        {
            try
            {
                Connection.Open();

                SqlCommand cmd = new SqlCommand(query, Connection);

                int affette = cmd.ExecuteNonQuery();

                if (affette > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Query: \n {query}");
                return false;
            }
            finally
            {
                Connection.Close();

            }

        }

        public List<Dictionary<string, string>> Read(string query)
        {
            List<Dictionary<string, string>> ris = new();
            Connection.Open();
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Dictionary<string, string> riga = new Dictionary<string, string>();

                for (int i = 0; i < dr.FieldCount; i++)

                {

                    riga.Add(dr.GetName(i).ToLower(), dr.GetValue(i).ToString());
                }

                ris.Add(riga);

            }

            dr.Close();
            Connection.Close();


            return ris;

        }
        public Dictionary<string, string> ReadOne(string query)
        {
            try
            {
                return Read(query)[0];
            }
            catch
            {
                return null;
            }
        }
    }
}
