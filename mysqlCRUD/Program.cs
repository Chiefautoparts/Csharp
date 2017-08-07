using System;
using System.Collections.Generic;
using DbConnection;

namespace mysqlCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Read("SELECT * FROM Users");
            Console.WriteLine("FirstName");
            string fName = Console.ReadLine();
            Console.WriteLine("LastName");
            string lName = Cosnsole.ReadLine();
            Console.WriteLine("FavotieNumber");
            string FavNum = Console.ReadLine();
            Create(fName, lName, FavNum);

            void Read(string query)
            {
                var results = DbConnector.Query(query);
                foreach(var records in results)
                {
                    foreach(var record in records)
                    {
                        Console.WriteLine(record.Key + ": " + record.Value);
                    }
                }
            }
            void Create(string fName, string lName, int FavNum)
            {
                var query = "INSERT INTO Users(FirstName, LastName, FavoriteNumber) VALUES('fName', 'lName', 'FavNum')";
                var results = DbConnector.Query(query);
                Read("SELECT * FROM Users");
            }
        }
    }
}
