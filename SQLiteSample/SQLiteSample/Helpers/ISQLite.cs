using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteSample.Helpers
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
