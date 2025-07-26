using mvcDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace mvcDemo.ViewModels
{
    public class PatientUpdateVm
    {
        public string FullName { get; set; }
        [Display(Name = "National Id")]
        public string NationalId { get; set; }

        public string Email { get; set; }
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public void ToPatient(Patient patient)
        {
            patient.FullName = FullName;
            patient.NationalId = NationalId;
            patient.Email = Email;
            patient.PhoneNumber = PhoneNumber;
            patient.DateOfBirth = DateOfBirth;
        }
    }
}
