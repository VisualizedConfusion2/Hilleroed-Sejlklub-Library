namespace Hilleroed_Sejlklub_Library.Models
{
    public class Member
    {
        /// <summary>  
        /// En Member class repræsenterer et medlem af Hillerød sejlklub  
        /// </summary>  
        public string Name { get; set; }
        public int MemberID { get; set; }
        public string ContactInfo { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

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
