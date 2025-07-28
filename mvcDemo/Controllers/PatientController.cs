using EFCore.ClinicModels;
using Microsoft.AspNetCore.Mvc;
using mvcDemo.Models;
using mvcDemo.ViewModels;

namespace mvcDemo.Controllers
{
    public class PatientController : Controller
    {
        public ClinicContext context;

        public PatientController(ClinicContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var patients = context.Patients.Select(p => new PatientVM
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

            var patient = context.Patients.FirstOrDefault(p => p.Id == id);
            if (patient == null)
            {
                return NotFound();
            }


            var patientVM = patient.PatientVM();
            return View(patientVM);
        }

        //creat -------------------------------------------------------
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
                FullName = patient.FullName,
                NationalId = patient.NationalId,
                Email = patient.Email,
                PhoneNumber = patient.PhoneNumber,
                DateOfBirth = patient.DateOfBirth
            };
            context.Patients.Add(newPatient);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        // update -------------------------------------------------------
        public IActionResult Update(int Id)
        {
            var patient = context.Patients.FirstOrDefault(p => p.Id == Id);
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
            var existPatient = context.Patients.FirstOrDefault(p => p.Id == Id);

            if (existPatient == null)
            {
                return NotFound();
            }

            Updatedpatient.ToPatient(existPatient);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        // delete -------------------------------------------------------
        public IActionResult Delete(int Id)
        {
            var patient = context.Patients.FirstOrDefault(p => p.Id == Id);
            if (patient == null)
            {
                return NotFound();
            }
            context.Patients.Remove(patient);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}