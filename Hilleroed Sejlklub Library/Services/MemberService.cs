using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Services
{
    internal class MemberService : IMemberService
    {
        private readonly List<Member> _members;

        public MemberService()
        {
            _members = new List<Member>();
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return _members;
        }

        public Member? GetMemberById(int id)
        {
            foreach (var member in _members)
            {
                if (member.MemberID == id)
                {
                    return member;
                }
            }
            return null;
        }

        public void AddMember(Member member)
        {
            _members.Add(member);
        }

        public bool UpdateMember(int id, Member updatedMember)
        {
            var member = GetMemberById(id);
            if (member == null)
                return false;

            member.Name = updatedMember.Name;
            member.ContactInfo = updatedMember.ContactInfo;
            member.Birthday = updatedMember.Birthday;
            member.Gender = updatedMember.Gender;
            return true;
        }

        public bool DeleteMember(int id)
        {
            var member = GetMemberById(id);
            if (member == null)
                return false;

            _members.Remove(member);
            return true;
        }

        public Member GetMember(int MemberID)
        {
            var member = GetMemberById(MemberID);
            if (member == null)
            {
                throw new KeyNotFoundException($"Member with ID {MemberID} not found.");
            }
            return member;
        }

        public List<Member> GetMembers()
        {
            var membersCopy = new List<Member>();
            foreach (var member in _members)
            {
                membersCopy.Add(member);
            }
            return membersCopy;
        }

        public void Add(Member member)
        {
            foreach (var existingMember in _members)
            {
                if (existingMember.MemberID == member.MemberID)
                {
                    throw new InvalidOperationException($"Member with ID {member.MemberID} already exists.");
                }
            }
            _members.Add(member);
        }

        public void Delete(int MemberID)
        {
            var member = GetMemberById(MemberID);
            if (member == null)
            {
                throw new KeyNotFoundException($"Member with ID {MemberID} not found.");
            }
            _members.Remove(member);
        }
    }
}
