using mvcDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace mvcDemo.ViewModels
{
    public class PatientFilterVm
    {
        public int? Id { get; set; }

        public string? FullName { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
