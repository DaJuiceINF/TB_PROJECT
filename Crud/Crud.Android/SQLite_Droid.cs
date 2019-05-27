using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using SQLite;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Crud.Droid;

[assembly:Dependency(typeof(SQLite_Droid))]
namespace Crud.Droid
{
   public class SQLite_Droid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "mydatabase.sqlite";
            var dbPath =System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbPath, dbName);
            var conn = new SQLiteConnection(path);
            return conn; 
        }

       
    }
}