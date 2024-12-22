namespace Hospital
{
    internal class Ambulance
    {
        public string LicensePlate { get; set; }
        public bool IsAvailable { get; set; }
        public Patient CurrentPatient { get; private set; }

        public Ambulance(string licensePlate)
        {
            LicensePlate = licensePlate;
            IsAvailable = true;
            CurrentPatient = null;
        }

        public void TransportPatient(Patient patient)
        {
            if (IsAvailable)
            {
                CurrentPatient = patient;
                Console.WriteLine($"Ambulance {LicensePlate} is transporting patient {patient.Name} (ID: {patient.Id}).");
            }
            else
            {
                Console.WriteLine($"Ambulance {LicensePlate} is not available to transport a patient. Dispatch it first.");
            }
        }

        public void ReturnAmbulance()
        {
            IsAvailable = true;
            if (CurrentPatient != null)
            {
                Console.WriteLine($"Ambulance {LicensePlate} has returned after transporting patient {CurrentPatient.Name} (ID: {CurrentPatient.Id}).");
                CurrentPatient = null;
            }
            else
            {
                Console.WriteLine($"Ambulance {LicensePlate} has returned after completing a mission.");
            }
        }
    }
}
