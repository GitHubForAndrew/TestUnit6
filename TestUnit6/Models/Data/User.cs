using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnit6.Models.Data
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public Account  Account { get; private set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
