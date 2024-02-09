using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPFmitEF.Models
{
    internal class Student
    {
        //ClassNameId --> Key mit Autoincrement
        //[Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        
    }
}
