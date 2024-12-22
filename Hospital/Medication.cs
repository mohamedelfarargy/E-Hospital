namespace Hospital
{
    internal class Medication
    {
        public string Name { get; set; }
        public string Dosage { get; set; }

        public Medication(string name, string dosage)
        {
            Name = name;
            Dosage = dosage;
        }
    }
}
