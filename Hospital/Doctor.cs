namespace Hospital
{
    internal class Doctor : Employee
    {
        public Doctor(int id, int age, string name)
        : base(EmployeeType.Doctor, id, 5000, age, DateTime.Now, name)
        {
        }

        public override void ShiftRegisterِِAttendance()
        {
            Shift shift = new Shift(this, DateTime.Now, DateTime.Now.AddHours(8));
            Console.WriteLine($"{Name}, a doctor, has registered attendance for a shift.");
        }

        public void PerformSurgery(Patient patient, SurgeryType surgeryType)
        {
            Console.WriteLine($"{Name} is performing {surgeryType} surgery on patient {patient.Name}.");
        }
    }

    internal enum SurgeryType
    {
        Appendectomy,
        CardiacBypass,
        KneeReplacement,
        CataractRemoval
    }
}
