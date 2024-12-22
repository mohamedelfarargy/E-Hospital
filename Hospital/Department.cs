namespace Hospital
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        List<Employee> DepartmentEmployee { get; set; }

        List<Room> DepartmentRoom { get; set; }

        public Department(
            List<Employee> departmentEmployee,
            List<Room> departmentRoom,
            int departmentId,
            string departmentName
            )
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            DepartmentEmployee = departmentEmployee;
            DepartmentRoom = departmentRoom;
        }

        public void AddEmployee(Employee e)
        {
            if (DepartmentEmployee.Contains(e) || e.IsAssigned != false)
            {
                Console.WriteLine($"Employee with id {e.Id} already exists in a department.");
            }
            else
            {
                DepartmentEmployee.Add(e);
                e.IsAssigned = true;
            }
        }

        public void RemoveEmployee(Employee e)
        {
            DepartmentEmployee.Remove(e);
            e.IsAssigned = false;
        }


        public void GetDepartmentInfo()
        {
            Console.WriteLine($"Department ID = {DepartmentId}");
            Console.WriteLine($"Department Name = {DepartmentName}");
            foreach (Employee e in DepartmentEmployee)
            {
                Console.WriteLine($"Employee ID = {e.Id},Employee Age = {e.Age}, Employee Hiring Date = {e.HireDate},Employee Salary = {e.Salary}, Employee Type = {e.Type} ");
            }
            foreach (Room r in DepartmentRoom)
            {
                Console.WriteLine($"Room Number = {r.Number}, Room Type = {r.RoomType}");
            }
        }
    }
}
