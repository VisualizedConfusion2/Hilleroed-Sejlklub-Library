namespace Hilleroed_Sejlklub_Library.Models
{
    public class Member
    {
        public string Name { get; set; }
        public int MemberID { get; set; }
        public string ContactInfo { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

        
        public Member() { }

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
