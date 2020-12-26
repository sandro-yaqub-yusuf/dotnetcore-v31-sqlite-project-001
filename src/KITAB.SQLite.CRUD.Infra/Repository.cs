using System;
using System.Data.SQLite;

namespace KITAB.SQLite.CRUD.Infra
{
    public class Repository
    {
        public static string DbFile
        {
            get
            {
                var curDir = Environment.CurrentDirectory;

                if (curDir.IndexOf("KITAB.SQLite.CRUD.ConsoleApp", 0) > 0)
                {
                    curDir = curDir.Substring(0, (curDir.Length - (curDir.Length - curDir.IndexOf("KITAB.SQLite.CRUD.ConsoleApp", 0))));
                }
                else
                {
                    curDir += "\\";
                }

                return curDir + "Database\\estoque.db";
            }
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}
