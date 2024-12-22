namespace Hospital
{
    internal class Shift
    {
        private DateTime startTime;
        private DateTime endTime;
        private Employee assignedEmployee;
        private static List<Shift> allShifts = new List<Shift>();

        public Shift(Employee employee, DateTime startTime, DateTime endTime)
        {
            this.assignedEmployee = employee;
            this.startTime = startTime;
            this.endTime = endTime;
            allShifts.Add(this);
        }

        public void AssignEmployee(Employee employee)
        {
            this.assignedEmployee = employee;
        }

        public void GetShiftDetails()
        {
            Console.WriteLine($"Shift Details: StartTime - {startTime}, EndTime - {endTime}, Assigned Employee - {assignedEmployee.Name}");
        }

        public void UpdateShift(DateTime newStartTime, DateTime newEndTime)
        {
            this.startTime = newStartTime;
            this.endTime = newEndTime;
        }

        public void GetShiftsForEmployee(Employee employee)
        {

            foreach (Shift shift in allShifts)
            {
                if (shift.assignedEmployee == employee)
                {
                    Console.WriteLine($"Shift Details: StartTime - {shift.startTime}, EndTime - {shift.endTime}, Assigned Employee - {shift.assignedEmployee.Name}");
                }
            }
        }
    }
}
