using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDB.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }

        public Faculty Faculty { get; set; }
    }
}
