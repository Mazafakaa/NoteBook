using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NoteBookBl
{
    class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("NoteBook")
        {

        }
        public DbSet<People> Peoples { get; set; }

    }
}
