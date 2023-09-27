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
        //è un campo di tipo sqlconnection che verrà usato per 
        //il collegamento di visual al db
        public SqlConnection Connection {  get; set; }

        //costruttore con dati in entrata nome del db e nome server
        //svolge il collegamento al db col campo precedentemente definito
        public Database(string nomeDB, string nomeServer = "GAMING-RIG")
        {
            Connection=new SqlConnection($"Data Source = {nomeServer};Initial Catalog = {nomeDB}; Integrated Security= True");
        }

        //è un metodo che serve per aggiornare dei dati 
        public bool Update(string query)
        {
            //blocco di try, prova appunto ad aprire la connessione e svolgere
            //la query data           
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(query, Connection);
                int affette = cmd.ExecuteNonQuery();
                if (affette > 0)
                {
                    return true;
                }
                else return false;
            }
            //si occupa di gestire gli eccezioni o i problemi che sono arrivati
            //dal try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Query: \n {query}");
                return false;
            }
            //chiude la connessione alla fine del try o del catch
            finally 
            {
                Connection.Close();
            }          
        }
        //metodo che sfrutta una lista di dictionary per leggere dati da sql
        public List<Dictionary<string, string>> Read(string query) 
        {
            List<Dictionary<string, string>> ris = new();
            Connection.Open();
            SqlCommand cmd = new SqlCommand(query,Connection);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                Dictionary<string,string> riga = new Dictionary<string,string>();
                for (int i=0;i<dr.FieldCount; i++)
                {
                riga.Add(dr.GetName(i).ToLower(),dr.GetValue(i).ToString());
                }
                ris.Add(riga);
            }
            dr.Close();
            Connection.Close();
            return ris;
        }
        public Dictionary<string,string>ReadOne(string query) 
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
