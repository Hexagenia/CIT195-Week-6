using System;

namespace clubMemberIndexer
{
    public class ClubMembers
    {
        public const int Size = 15;
        private readonly string[] Members = new string[Size];

        public string ClubType { get; set; }
        public string ClubLocation { get; set; }
        public string MeetingDate { get; set; }

        // Default constructor
        public ClubMembers()
        {ClubType = "";
        ClubLocation = "";
        MeetingDate = "";}

        // get and set
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= Size)
                        {
                        throw new IndexOutOfRangeException("Index is out of range.");
                        }
                return Members[index];
            }
            set
            {
                if (index < 0 || index >= Size)
                            {
                                throw new IndexOutOfRangeException("Index is out of range.");
                            }
                Members[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new ClubMembers object
            ClubMembers club = new ClubMembers();

            // Adding values...
            club[0] = "Colin";
            club[1] = "Kerner";
            club[2] = "Parmida";

            // Add values to the ClubType, ClubLocation, and MeetingDate
            club.ClubType = "Esports Club";
            club.ClubLocation = "Computer Lab";
            club.MeetingDate = "Every Friday night";

            // Displaying club info
            Console.WriteLine("Club Information:");
            Console.WriteLine($"Club Type: {club.ClubType}");
            Console.WriteLine($"Club Location: {club.ClubLocation}");
            Console.WriteLine($"Meeting Date: {club.MeetingDate}");
            Console.WriteLine("Members:");

            // Displaying members
            for (int i = 0; i < ClubMembers.Size; i++)
            {
                if (!string.IsNullOrEmpty(club[i]))
                {
                    Console.WriteLine($"- {club[i]}");
                }
            }
        }
    }
}