namespace Hospital
{
    internal abstract class Employee
    {
        protected Employee(EmployeeType type, int id, float salary, int age, DateTime hireDate, string name)
        {
            Type = type;
            Id = id;
            Salary = salary;
            Age = age;
            HireDate = hireDate;
            Name = name;
        }

        public EmployeeType Type { get; set; }
        public int Id { get; set; }
        public float Salary { get; set; }
        public int Age { get; set; }
        public DateTime HireDate { get; set; }

        public abstract void ShiftRegisterِِAttendance();
        public bool IsAssigned { get; set; }
        public string Name { get; set; }


    }
    public enum EmployeeType
    {
        Receptionist,
        Doctor,
        Nurse,
        Pharmacist
    }
}
