namespace Hilleroed_Sejlklub_Library.Models
{
    public class Boat
    {
        /// <summary>
        /// En Member class repræsenterer et medlem af Hillerød sejlklub
        /// </summary>
        public string Name { get; set; }
        public int Id { get; set; }
        public string ContactInfo { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

        public Boat(string name, int id, string contactInfo, DateTime birthday, string gender)
        {
            Name = name;
            Id = id;
            ContactInfo = contactInfo;
            Birthday = birthday;
            Gender = gender;
        }
    }
}
