namespace Hospital
{
    internal class Nurse : Employee
    {
        public Nurse(int id, int age, string name) :
        base(EmployeeType.Nurse, id, 5000, age, DateTime.Now, name)
        {
            IsAssigned = false;
        }

        public void AssistDoctor(Doctor doctor)
        {
            if (IsAssigned == false)
            {
                Console.WriteLine($"The nurse will assist the doctor{doctor.Id} during the procedure");
                IsAssigned = true;
            }
            else
            {
                Console.WriteLine("The nurse is not available at the moment.");
            }
        }

        public void AdministerMedication(Patient patient, string medication)
        {
            if (IsAssigned == false)
            {
                Console.WriteLine($"The nurse will administer the medication:{medication} to the patient ID:{patient.Id}");
                IsAssigned = true;
            }
            else
            {
                Console.WriteLine("The nurse is not available at the moment.");
            }
        }

        public void GetNurseInfo()
        {
            Console.WriteLine($"Nurse ID = {Id}");
            Console.WriteLine($"Nurse Salary = {Salary}");
            Console.WriteLine($"Nurse Age = {Age}");
            Console.WriteLine($"Nurse Hiring Date = {HireDate}");
        }

        public void MonitorPatientVitals(Patient patient)
        {
            if (IsAssigned == false)
            {
                Console.WriteLine($"The nurse will monitor vital signs of the patient ID:{patient.Id}");
                IsAssigned = true;
            }
            else
            {
                Console.WriteLine("The nurse is not available at the moment.");
            }
        }

        public override void ShiftRegisterِِAttendance()
        {
            Shift shift = new Shift(this, DateTime.Now, DateTime.Now.AddHours(8));
            Console.WriteLine($"{Name}, a doctor, has registered attendance for a shift.");
        }
    }
}
