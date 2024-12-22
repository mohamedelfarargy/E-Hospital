namespace Hospital
{
    internal class Room
    {
        public bool IsAssigned { get; set; }
        public int Number { get; }
        public RoomType RoomType { get; set; }

        public Room(int number, RoomType roomType)
        {
            Number = number;
            RoomType = roomType;
            IsAssigned = false;
        }

        public void AssignRoomToPatient(Patient patient)
        {
            if (!IsAssigned)
            {
                IsAssigned = true;
                Console.WriteLine($"Room {Number} ({RoomType}) assigned to {patient.Name} (ID: {patient.Id}).");
            }
            else
            {
                Console.WriteLine($"Room {Number} ({RoomType}) is already assigned.");
            }
        }

        public void ReleaseRoom()
        {
            if (IsAssigned)
            {
                IsAssigned = false;
                Console.WriteLine($"Room {Number} ({RoomType}) has been released and is now available.");
            }
            else
            {
                Console.WriteLine($"Room {Number} ({RoomType}) is not currently assigned.");
            }
        }
    }

    public enum RoomType
    {
        General,
        Examination,
        Operating,
        Recovery,
        ICU,
        Emergency,
        Other
    }
}
