using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;

namespace Hilleroed_Sejlklub_Library.Repos
{
    public class MemberRepo : IMemberRepo
    {
        // Private list to store members
        private List<Member> _members;

        // Constructor to initialize the member list
        public MemberRepo()
        {
            _members = new List<Member>();
        }

        // Method to add a new member to the list
        public void Add(Member member)
        {
            // Check if the provided member is null
            if (member == null)
            {
                // Throw an exception if the member is null
                throw new ArgumentNullException("member");
            }

            // Add the member to the list
            _members.Add(member);
        }

        // Method to delete a member by their MemberID
        public void Delete(int MemberID)
        {
            // Variable to store the member to be deleted
            Member memberToDelete = null;

            // Iterate through the list of members
            foreach (Member member in _members)
            {
                // Check if the current member's ID matches the provided MemberID
                if (member.MemberID == MemberID)
                {
                    // Assign the member to the variable and break the loop
                    memberToDelete = member;
                    break;
                }
            }

            // If a member to delete is found, remove it from the list
            if (memberToDelete != null)
            {
                _members.Remove(memberToDelete);
            }
        }

        // Method to retrieve the list of all members
        public List<Member> Get()
        {
            // Return the list of members
            return _members;
        }

        // Method to retrieve a member by their MemberID
        public Member GetMember(int MemberID)
        {
            // Iterate through the list of members
            foreach (Member member in _members)
            {
                // Check if the current member's ID matches the provided MemberID
                if (member.MemberID == MemberID)
                {
                    // Return the matched member
                    return member;
                }
            }

            // Return null if no member with the given ID is found
            return null;
        }

        // Method to get the contact information of a member by their MemberID
        public string GetContactInfo(int MemberID)
        {
            // Iterate through the list of members
            foreach (Member member in _members)
            {
                // Check if the current member's ID matches the provided MemberID
                if (member.MemberID == MemberID)
                {
                    // Return the contact information of the matched member
                    return $"Email: {member.ContactInfo}";
                }
            }

            // Return a default message if no member with the given ID is found
            return "Kontaktinformation ikke fundet.";
        }

        // Method to get the gender of a member by their MemberID
        public string GetGender(int MemberID)
        {
            // Iterate through the list of members
            foreach (Member member in _members)
            {
                // Check if the current member's ID matches the provided MemberID
                if (member.MemberID == MemberID)
                {
                    // Return the gender of the matched member
                    return member.Gender;
                }
            }
            // Return a default value if no member with the given ID is found
            return "Ukendt køn";
        }
    }
}