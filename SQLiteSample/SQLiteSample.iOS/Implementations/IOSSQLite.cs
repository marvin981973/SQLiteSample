using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Foundation;
using SQLite;
using SQLiteSample.Helpers;
using SQLiteSample.iOS.Implementaions;
using UIKit;

[assembly: Dependency(typeof(IOSSQLite))]
namespace SQLiteSample.iOS.Implementaions
{
    public class IOSSQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, DatabaseHelper.DbFileName);
            // Create the connection
            //var plat = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var conn = new SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}