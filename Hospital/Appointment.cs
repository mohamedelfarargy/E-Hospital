namespace Hospital
{
    internal class Appointment
    {
        private List<Appointment> appointments;
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
        public AppointmentPurpose Purpose { get; set; }

        public Appointment(Patient patient, Doctor doctor, DateTime date, AppointmentPurpose purpose)
        {
            Patient = patient;
            Doctor = doctor;
            Date = date;
            Purpose = purpose;
            appointments = new List<Appointment>
            {
                this
            };
        }

        public void DisplayAppointmentInformation()
        {
            Console.WriteLine($"Appointment Information - Date: {Date}, Patient: {Patient.Name} (ID: {Patient.Id}), Doctor: {Doctor.Name}, Purpose: {Purpose}");
        }

        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
            Console.WriteLine("Appointment added successfully.");
        }

        public void CancelAppointment(Appointment appointment)
        {
            appointments.Remove(appointment);
            Console.WriteLine("Appointment Removed successfully.");
        }

        public List<Appointment> GetAllAppointments()
        {
            return appointments;
        }

        public List<Appointment> GetAppointmentsForPatient(Patient patient)
        {
            return appointments.FindAll(appointment => appointment.Patient == patient);
        }

        public List<Appointment> GetAppointmentsForDoctor(Doctor doctor)
        {
            return appointments.FindAll(appointment => appointment.Doctor == doctor);
        }
    }

    public enum AppointmentPurpose
    {
        GeneralCheckup,
        FollowUp,
        Consultation,
        Vaccination,
        DiagnosticTest,
        Treatment,
        Surgery,
        Other
    }
}
