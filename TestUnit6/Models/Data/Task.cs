using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnit6.Models.Data
{
    public class Task : BaseEntity
    {
        public string Name { get; set; }
        public string Descrioption { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }

        public User User { get; set; }
    }
}
