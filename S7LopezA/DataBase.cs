using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace S7LopezA
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();
    }
}
