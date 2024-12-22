namespace Hospital
{
    internal class Pharmacist : Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Medication> AssignedMedications { get; }

        public Pharmacist(int id, int age, string name)
            : base(EmployeeType.Pharmacist, id, 3000, age, DateTime.Now, name)
        {
            AssignedMedications = new List<Medication>();
        }

        public void DispenseMedication(Patient patient, Medication medication)
        {
            Pharmacies pharmacies = new Pharmacies();
            pharmacies.DispenseMedication(patient, medication);
            AssignedMedications.Add(medication);
        }

        public void UpdateMedicationDosage(Medication medication, string newDosage)
        {
            medication.Dosage = newDosage;
            Console.WriteLine($"Pharmacist {Name} updated the dosage of {medication.Name} to {newDosage}");
        }

        public void ViewAssignedMedications()
        {
            Console.WriteLine($"Pharmacist {Name} is assigned the following medications:");
            foreach (var medication in AssignedMedications)
            {
                Console.WriteLine($"- {medication.Name} ({medication.Dosage})");
            }
        }

        public override void ShiftRegisterِِAttendance()
        {
            Shift shift = new Shift(this, DateTime.Now, DateTime.Now.AddHours(8));
            Console.WriteLine($"{Name}, a doctor, has registered attendance for a shift.");
        }
    }
}
