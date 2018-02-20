using System;
using System.IO;
using lion.Droid.Persistence;
using lion.Persistence;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace lion.Droid.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}