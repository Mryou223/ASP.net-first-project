using mvcDemo.Models;
using Microsoft.AspNetCore.Mvc;
using mvcDemo.ViewModels;

namespace mvcDemo.Controllers
{
    public class PatientController : Controller
    {


        public IActionResult Index()
        {
            var patients = Constants.Patients.Select(p => new PatientVM
            {
                Id = p.Id,
                FullName = p.FullName,
                DateOfBirth = p.DateOfBirth,
                Email = p.Email,
                NationalId = p.NationalId,
                PhoneNumber = p.PhoneNumber
            }).ToList();
            return View(patients);
        }

        public IActionResult Details(int id)
        {

            var patient = Constants.Patients.FirstOrDefault(p => p.Id == id);
            if (patient == null)
            {
                return NotFound();
            }


            var patientVM = patient.PatientVM();
            return View(patientVM);
        }
        public IActionResult Create()
        {
            var patient = new PatientCreatVM();

            return View(patient);
        }

        [HttpPost]
        public IActionResult Create(PatientCreatVM patient)
        {
            if (!ModelState.IsValid)
            {
                return View(patient);
            }
            var newPatient = new Patient
            {
                Id = Constants.Patients.Count + 1,
                FullName = patient.FullName,
                NationalId = patient.NationalId,
                Email = patient.Email,
                PhoneNumber = patient.PhoneNumber,
                DateOfBirth = patient.DateOfBirth
            };
            Constants.Patients.Add(newPatient);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int Id)
        {
            var patient = Constants.Patients.FirstOrDefault(p => p.Id == Id);
            if (patient == null)
            { return NotFound(); }
            var patientVM = patient.ToPatientUpdateVM();
            return View(patientVM);
        }

        [HttpPost]
        public IActionResult Update(PatientUpdateVm Updatedpatient, int Id)
        {
            if (!ModelState.IsValid)
            {
                return View(Updatedpatient);
            }
            var existPatient = Constants.Patients.FirstOrDefault(p => p.Id == Id);

            if (existPatient == null)
            {
                return NotFound();
            }

            Updatedpatient.ToPatient(existPatient);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            var patient = Constants.Patients.FirstOrDefault(p => p.Id == Id);
            if (patient == null)
            {
                return NotFound();
            }
            Constants.Patients.Remove(patient);
            return RedirectToAction("Index");
        }
        
    }
}