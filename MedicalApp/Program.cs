using System;
using System.Collections.Generic;

namespace MedicalApp
{
   
   class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }

    }
    class Gender
    {
        enum Sex
        {
            Male, Female, Unceratain
        }
    }

    class Patient : User
    {
        public Gender Sex { get; set; }
       
        public DateTime BirthDate { get; set; }

    }

    class Doctor: User
    {
        public int SpecializationId { get; set; }

    }

    public class Appointment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
      
    }

    public class Attendance
    {
        public int Id { get; set; }
        public string ClinicRemarks { get; set; }
        public string Diagnosis { get; set; }
        public string Therapy { get; set; }
        public int PatientId { get; set; }
    }
}
