using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDB.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual IEnumerable<Student> Students { get; set; }
    }
}
