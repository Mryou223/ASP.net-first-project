using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clinic
{
    internal class appointment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Doctor")]
        public int DocId { get; set; }
        public Doctor Doctor { get; set; }

    }
}
