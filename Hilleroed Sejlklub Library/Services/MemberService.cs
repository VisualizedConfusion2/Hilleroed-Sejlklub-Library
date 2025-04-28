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
            return _members.FirstOrDefault(m => m.MemberID == id);
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
            return GetMemberById(MemberID) ?? throw new KeyNotFoundException($"Member with ID {MemberID} not found.");
        }

        public List<Member> GetMembers()
        {
            return _members.ToList();
        }

        public void Add(Member member)
        {
            if (_members.Any(m => m.MemberID == member.MemberID))
                throw new InvalidOperationException($"Member with ID {member.MemberID} already exists.");
            _members.Add(member);
        }

        public void Delete(int MemberID)
        {
            var member = GetMemberById(MemberID);
            if (member == null)
                throw new KeyNotFoundException($"Member with ID {MemberID} not found.");
            _members.Remove(member);
        }
    }
}
