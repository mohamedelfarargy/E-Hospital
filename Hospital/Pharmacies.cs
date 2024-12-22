namespace Hospital
{
    internal class Pharmacies
    {
        private List<Medication> availableMedications;

        public Pharmacies()
        {
            availableMedications = new List<Medication>();
        }

        public void AddMedication(Medication medication)
        {
            availableMedications.Add(medication);
            Console.WriteLine($"New medication added to the pharmacy: {medication.Name}");
        }

        public void DispenseMedication(Patient patient, Medication medication)
        {
            if (availableMedications.Contains(medication))
            {
                Console.WriteLine($"Dispensing {medication.Name} to {patient.Name} (ID: {patient.Id})");
            }
            else
            {
                Console.WriteLine($"{medication.Name} is not available in the pharmacy.");
            }
        }
    }
}
