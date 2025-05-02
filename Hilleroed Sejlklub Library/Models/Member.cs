namespace Hilleroed_Sejlklub_Library.Models
{
    public class Member
    {
        // Property to store the name of the member
        public string Name { get; set; }

        // Unique identifier for the member
        public int MemberID { get; set; }

        // Contact information for the member (e.g., email or phone number)
        public string ContactInfo { get; set; }

        // Date of birth of the member
        public DateTime Birthday { get; set; }

        // Gender of the member (e.g., Male, Female, Non-binary, etc.)
        public string Gender { get; set; }

        // Default constructor
        public Member()
        { }

        // Parameterized constructor to initialize all properties
        public Member(string name, int memberID, string contactInfo, DateTime birthday, string gender)
        {
            Name = name;
            MemberID = memberID;
            ContactInfo = contactInfo;
            Birthday = birthday;
            Gender = gender;
        }
    }
}
