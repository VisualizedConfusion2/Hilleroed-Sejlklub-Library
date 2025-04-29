using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Services
{
    internal class MemberService : IMember
    {
        // List to store all members
        private readonly List<Member> _members;

        // Constructor to initialize the member list
        public MemberService()
        {
            _members = new List<Member>();
        }

        // Retrieve all members
        public List<Member> GetAllMembers()
        {
            return _members;
        }

        // Retrieve a member by their ID
        public Member? GetMemberById(int id)
        {
            foreach (Member member in _members)
            {
                if (member.MemberID == id)
                {
                    return member;
                }
            }
            return null;
        }

        // Add a new member to the list
        public void AddMember(Member member)
        {
            _members.Add(member);
        }

        // Update an existing member's details
        public bool UpdateMember(int id, Member updatedMember)
        {
            Member? member = GetMemberById(id);
            if (member == null)
                return false;

            // Update member properties
            member.Name = updatedMember.Name;
            member.ContactInfo = updatedMember.ContactInfo;
            member.Birthday = updatedMember.Birthday;
            member.Gender = updatedMember.Gender;
            return true;
        }

        // Delete a member by their ID
        public bool DeleteMember(int id)
        {
            Member? member = GetMemberById(id);
            if (member == null)
                return false;

            _members.Remove(member);
            return true;
        }

        // Retrieve a member by ID or throw an exception if not found
        public Member GetMember(int MemberID)
        {
            Member? member = GetMemberById(MemberID);
            if (member == null)
            {
                throw new KeyNotFoundException($"Member with ID {MemberID} not found.");
            }
            return member;
        }

        // Get a copy of the list of all members
        public List<Member> GetMembers()
        {
            List<Member> membersCopy = new List<Member>();
            foreach (Member member in _members)
            {
                membersCopy.Add(member);
            }
            return membersCopy;
        }

        // Add a new member, ensuring no duplicate IDs
        public void Add(Member member)
        {
            foreach (Member existingMember in _members)
            {
                if (existingMember.MemberID == member.MemberID)
                {
                    throw new InvalidOperationException($"Member with ID {member.MemberID} already exists.");
                }
            }
            _members.Add(member);
        }

        // Delete a member by ID or throw an exception if not found
        public void Delete(int MemberID)
        {
            Member? member = GetMemberById(MemberID);
            if (member == null)
            {
                throw new KeyNotFoundException($"Member with ID {MemberID} not found.");
            }
            _members.Remove(member);
        }
    }
}
