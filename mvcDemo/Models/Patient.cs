using mvcDemo.ViewModels;

namespace mvcDemo.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string NationalId { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public PatientVM PatientVM()
        {
            return new PatientVM
            {
                Id = this.Id,
                FullName = this.FullName,
                NationalId = this.NationalId,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber,
                DateOfBirth = this.DateOfBirth
            };
        }
        public PatientUpdateVm ToPatientUpdateVM()
        {
            return new PatientUpdateVm
            {
                
                FullName = FullName,
                DateOfBirth = DateOfBirth,
                Email = Email,
                NationalId = NationalId,
                PhoneNumber = PhoneNumber
            };
        }



    }
    } 