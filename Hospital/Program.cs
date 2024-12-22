using Hospital;

internal class Program
{
    private static void Main(string[] args)
    {
        HospitalManager.GenerateReport();
        Patient patient = new Patient(1, "ahmed", 52, "good");
        Receptionist.RegisterNewPatient(patient);
        HospitalManager.Ambulances.FirstOrDefault().TransportPatient(Receptionist.Patients.FirstOrDefault());
        HospitalManager.Rooms.FirstOrDefault().AssignRoomToPatient(patient);
        Pharmacist pharmacist = HospitalManager.Employees.Where(e => e.Type == EmployeeType.Pharmacist).FirstOrDefault() as Pharmacist;
        pharmacist.DispenseMedication(patient, new Medication("Paracetamol", "3 Times"));
        HospitalManager.Departments.FirstOrDefault().GetDepartmentInfo();
        var clinic = HospitalManager.Clinics.FirstOrDefault();
        var doctor = HospitalManager.Employees.Where(e => e.Type == EmployeeType.Doctor).FirstOrDefault() as Doctor;
        var nurse = HospitalManager.Employees.Where(e => e.Type == EmployeeType.Nurse).FirstOrDefault() as Nurse;
        clinic.AddDoctor(doctor);
        clinic.DisplayClinicInformation();
        var Appointment = new Appointment(patient, doctor, DateTime.Now.AddDays(10), AppointmentPurpose.FollowUp);
        Appointment.DisplayAppointmentInformation();
        nurse.AssistDoctor(doctor);
        nurse.MonitorPatientVitals(patient);
    }
}