namespace Hospital
{
    internal class Clinic
    {
        public ClinicType Type { get; set; }
        public List<Doctor> Doctors { get; }
        public List<Nurse> Nurses { get; }
        public List<Patient> Patients { get; }

        public Clinic(ClinicType type)
        {
            Type = type;
            Doctors = new List<Doctor>();
            Nurses = new List<Nurse>();
            Patients = new List<Patient>();
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine($"Doctor {doctor.Name} added to {Type} clinic.");
        }

        public void AddNurse(Nurse nurse)
        {
            Nurses.Add(nurse);
            Console.WriteLine($"Nurse {nurse.Name} added to {Type} clinic.");
        }

        public void AdmitPatient(Patient patient)
        {
            Patients.Add(patient);
            Console.WriteLine($"{patient.Name} admitted to {Type} clinic.");
        }

        public void DisplayClinicInformation()
        {
            Console.WriteLine($"Clinic Information - {Type}");
            Console.WriteLine($"Number of Doctors: {Doctors.Count}");
            Console.WriteLine($"Number of Nurse: {Nurses.Count}");
            Console.WriteLine($"Number of Patients: {Patients.Count}");
        }
    }

    enum ClinicType
    {
        General,
        Pediatrics,
        Orthopedics,
        Cardiology,
        Dermatology,
    }
}
