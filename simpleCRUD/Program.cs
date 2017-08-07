using System;
using System.Collections.Generic;
using DbConnection;

namespace simpleCRUD
{
    class Program
    {
        public class DBmethods
        {
            public static object Read()
            {
                object myUsers = DbConnector.Query("SELECT * FROM Users");
                return myUsers;
            }
            public static void createUser(string FirstName, string LastName, int FavoriteNumber)
            {
                string queryString = $"INSERT INTO Users (FirstName, LastName, FavoriteNumber) VALUES ('{FirstName}', '{LastName}', {FavoriteNumber})";
                DbConnector.Execute(queryString);
            }
            // public static void updateInfo(int id, string FirstName, string LastName, int FavoriteNumber)
            // {
            //     string queryString = $"UPDATE USERS SET FirstName = '{FirstName}', LastName = '{LastName}', FavoriteNumber = {FavoriteNumber} WHERE id = {id}";
            //     DbConnector.Execute(queryString);
            // }
            // public static void deleteUser(int id)
            // {
            //     string queryString = $"DELETE FROM Users WHERE id = {id}";
            //     DbConnector.Execute(queryString);
            // }
        }
        static void Main(string[] args)
        {
            object myUsers = DBmethods.Read();
            System.Console.WriteLine(myUsers);

            DBmethods.createUser("bobby", "Dukes", 86);

            // DBmethods.updateInfo(2, "Dee", "Reynolds", 56);
            
            // object updatedUsers = DBmethods.Read();
            // System.Console.WriteLine(updatedUsers);

            // DBmethods.deleteUser(2);

            // object afterDelete = DBmethods.Read();
            // System.Console.WriteLine(afterDelete);
        }
    }
}
