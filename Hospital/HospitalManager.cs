namespace Hospital
{
    internal static class HospitalManager
    {
        public static string HospitalName => "El Shifa Hospital";
        public static void GenerateReport()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Generating a report on {HospitalName} statistics.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"We have {Rooms.Count()} Rooms");
            Console.WriteLine($"We have {Employees.Count()} Employees");
            Console.WriteLine($"We have {Departments.Count()} Departments");
        }

        public static List<Employee> Employees { get; set; }
        public static List<Room> Rooms { get; set; }
        public static List<Department> Departments { get; set; }
        public static List<Ambulance> Ambulances { get; set; }
        public static List<Clinic> Clinics { get; set; }

        static HospitalManager()
        {

            Employees = new List<Employee>() {
                new Doctor(1,21,"Ahmed Awad"),
                new Doctor(2,22,"Ahmed Safwat"),
                new Doctor(3,23,"Ahmed Nabih"),
                new Doctor(4,24,"Ahmed Gamal"),
                new Doctor(5,25,"Ahmed Mostafa"),
                new Doctor(6,26,"Ahmed Rabie3"),
                new Doctor(7,27,"Ahmed Abd elGhany"),
                new Doctor(8,28,"Ahmed samir"),
                new Doctor(9,31,"Mohamed Zyad"),
                new Doctor(10,32,"Mohamed Gamal"),
                new Doctor(11,33,"Mohamed Tarek"),
                new Doctor(12,33,"Sara Tarek"),
                new Doctor(13,33,"Samira Tarek"),
                new Doctor(14,33,"Mostafa Tarek"),
                new Pharmacist(4,34,"Mohamed Sayed"),
                new Pharmacist(5,35,"Mohamed Mostafa"),
                new Nurse(1,23,"Sohir"),
                new Nurse(2,34,"Shaimaa"),
                new Nurse(3,36,"Samira"),
                new Nurse(4,28,"Lara"),
                new Nurse(5,38,"Samia"),
                new Nurse(6,19,"Sara"),
                new Nurse(7,40,"Farida"),
                new Nurse(8,18,"Sandy"),
                new Nurse(8,18,"So3ad"),
                new Nurse(8,18,"Ziad"),

            };
            Rooms = new List<Room>()
            {
                new Room(1,RoomType.General),
                new Room(2,RoomType.General),
                new Room(3,RoomType.General),
                new Room(4,RoomType.General),
                new Room(5,RoomType.General),
                new Room(6,RoomType.General),
                new Room(7,RoomType.General),
                new Room(8,RoomType.General),
                new Room(9,RoomType.ICU),
                new Room(10,RoomType.ICU),
                new Room(11,RoomType.ICU),
                new Room(12,RoomType.Examination),
                new Room(13,RoomType.Examination),
                new Room(14,RoomType.Examination),
                new Room(15,RoomType.Examination),
                new Room(16,RoomType.Examination),
                new Room(17,RoomType.Examination),
                new Room(18,RoomType.Examination),
                new Room(19,RoomType.Examination),
                new Room(20,RoomType.Examination),
                new Room(21,RoomType.Operating),
                new Room(22,RoomType.Operating),
                new Room(23,RoomType.Operating),
                new Room(24,RoomType.Operating),
                new Room(25,RoomType.Operating),
                new Room(26,RoomType.Operating),
                new Room(27,RoomType.Operating),
                new Room(28,RoomType.Operating),
                new Room(29,RoomType.Emergency),
                new Room(30,RoomType.Emergency),
                new Room(31,RoomType.Emergency),
                new Room(32,RoomType.Emergency),
                new Room(33,RoomType.Recovery),
                new Room(34,RoomType.Recovery),
                new Room(35,RoomType.Other),
                new Room(36,RoomType.Other),
                new Room(37,RoomType.Other),
                new Room(38,RoomType.Other),
            };
            Departments = new List<Department>() {
                new Department(Employees.Where(e=>e.Type == EmployeeType.Pharmacist).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Other).ToList(),9,"Pharmacy"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Nurse).Skip(0).Take(2).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Recovery).ToList(),2,"Internal Medicine"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Nurse).Skip(2).Take(2).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Emergency).ToList(),1,"Emergency"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Nurse).Skip(4).Take(2).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Operating).ToList(),3,"Surgery"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Nurse).Skip(6).Take(2).ToList(),Rooms.Where(e=>e.RoomType == RoomType.General).ToList(),4,"Pediatrics"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Nurse).Skip(8).Take(2).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Examination).ToList(),5,"Obstetrics and Gynecology"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(0).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Examination).ToList(),6,"Cardiology"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(1).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Examination).ToList(),7,"Radiology"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(2).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Examination).ToList(),8,"Laboratory"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(3).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Examination).ToList(),10,"Intensive Care Unit"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(4).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Examination).ToList(),11,"Physical Therapy"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(5).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Other).ToList(),12,"Nutrition Services"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(6).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Other).ToList(),13,"Oncology"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(7).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Other).ToList(),14,"Psychiatry"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(8).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Other).ToList(),15,"Infectious Diseases"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(9).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Other).ToList(),16,"Respiratory Therapy"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(10).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Other).ToList(),17,"Neurology"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(11).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Other).ToList(),18,"Anesthesiology"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(12).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Other).ToList(),19,"Medical Records"),
                new Department(Employees.Where(e=>e.Type == EmployeeType.Doctor).Skip(13).Take(1).ToList(),Rooms.Where(e=>e.RoomType == RoomType.Other).ToList(),20,"Patient Services"),
            };
            Ambulances = new List<Ambulance>()
            {
                new Ambulance("9821"),
                new Ambulance("5663"),
            };
            Clinics = new List<Clinic>()
            {
                new Clinic(ClinicType.General),
                new Clinic(ClinicType.Cardiology),
                new Clinic(ClinicType.Dermatology),
                new Clinic(ClinicType.Orthopedics),
                new Clinic(ClinicType.Pediatrics),
            };
        }
    }
}
