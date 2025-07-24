using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clinic
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<appointment> appointments { get; set; } = new();
    }
}
