using mvcDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace mvcDemo.ViewModels
{
    public class PatientFilteredListVm
    {
       public PatientFilterVm filter { get; set; }

       public List<PatientVM> patients { get; set; }
    }
}
