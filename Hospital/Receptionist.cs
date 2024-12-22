namespace Hospital
{
    internal static class Receptionist
    {
        public static List<Patient> Patients { get; set; }

        static Receptionist()
        {
            Patients = new List<Patient>();
        }


        public static void RegisterNewPatient(Patient patient)
        {
            Patients.Add(patient);
            Console.WriteLine($"Receptionist has registered a new patient: {patient.Name}, Age: {patient.Age}.");
        }

        public static void DischargePatient(Patient patient)
        {
            if (Patients.Contains(patient))
            {
                Patients.Remove(patient);
                Console.WriteLine($"Receptionist has discharged patient: {patient.Name}, Age: {patient.Age}.");
            }
            else
            {
                Console.WriteLine($"Patient {patient.Name} not found in the hospital records.");
            }
        }

    }
}
