using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using System.Linq;

namespace Crud
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();

    }
}
