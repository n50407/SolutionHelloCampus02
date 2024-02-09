using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPFmitEF.Models
{
    internal class Campus02DBContext: DbContext
    {
        //Jede Tabelle in der DB wird als DbSet definiert
        public DbSet<Student> Students { get; set; }
    }
}
