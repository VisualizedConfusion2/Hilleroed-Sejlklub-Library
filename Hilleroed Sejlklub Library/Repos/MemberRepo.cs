using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;

namespace Hilleroed_Sejlklub_Library.Repos
{
    public class MemberRepo : IMemberRepo
    {
        private List<Member> _members;

        public MemberRepo()
        {
            _members = new List<Member>();
        }

        public void Add(Member member)
        {
            if (member == null)
            {
                throw new ArgumentNullException("member");
            }

            _members.Add(member);
        }

        public void Delete(int MemberID)
        {
            Member memberToDelete = null;

            foreach (Member member in _members)
            {
                if (member.MemberID == MemberID)
                {
                    memberToDelete = member;
                    break;
                }
            }

            if (memberToDelete != null)
            {
                _members.Remove(memberToDelete);
            }
        }

        public List<Member> Get()
        {
            return _members;
        }

        public Member GetMember(int MemberID)
        {
            foreach (Member member in _members)
            {
                if (member.MemberID == MemberID)
                {
                    return member;
                }
            }

            return null;
        }

        public string GetContactInfo(int MemberID)
        {
            foreach (Member member in _members)
            {
                if (member.MemberID == MemberID)
                {
                    return $"Email: {member.ContactInfo}";
                }
            }

            return "Kontaktinformation ikke fundet.";
        }

        public string GetGender(int MemberID)
        {
            foreach (Member member in _members)
            {
                if (member.MemberID == MemberID)
                {
                    return member.Gender;
                }
            }
            return "Ukendt køn";
        }
    }
}