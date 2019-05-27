using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Crud.Model
{
    public class Patient
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
