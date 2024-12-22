namespace Hospital
{
    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsAssigned { get; set; }
        public string MedicalCondition { get; set; }

        public Patient(int id, string name, int age, string medicalCondition)
        {
            Id = id;
            Name = name;
            Age = age;
            MedicalCondition = medicalCondition;
            IsAssigned = false;
        }


        public void DisplayPatientInformation()
        {
            Console.WriteLine($"Patient Information - ID: {Id}, Name: {Name}, Age: {Age}, Medical History: {MedicalCondition}, Assigned: {IsAssigned}");
        }
    }
}
