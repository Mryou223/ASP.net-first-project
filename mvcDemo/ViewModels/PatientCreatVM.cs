using System.ComponentModel.DataAnnotations;

namespace mvcDemo.Models
{
    public class PatientCreatVM
    {
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name = "National Id")]
        public string NationalId { get; set; }

        public string Email { get; set; }
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        
    }
}