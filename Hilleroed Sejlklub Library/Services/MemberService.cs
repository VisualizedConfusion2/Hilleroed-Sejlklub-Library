using Hilleroed_Sejlklub_Library.Interfaces;
using Hilleroed_Sejlklub_Library.Models;
using Hilleroed_Sejlklub_Library.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Services
{
    internal class MemberService
    {
        // List to store all members
        private IMemberRepo _memberRepo;

        // Constructor to initialize the member list
        public MemberService(IMemberRepo memberRepo)
        {
            _memberRepo = memberRepo ?? throw new ArgumentNullException(nameof(memberRepo));
        }

        // Retrieve all members
        public List<Member> Get()
        {
            return _memberRepo.Get();
        }

        // Retrieve a member by their ID
        public void GetMemberById(int id)
        {
            //missinglogic
        }

        // Add a new member to the list
        public void Add(Member member)
        {
            _memberRepo.Add(member);
        }

        // Delete a member by their ID
        public void Delete(int id)
        {
            _memberRepo.Delete(id);
        }

        //NO LOGIC HERE YET
        public string GetContactInfo(int MemberID)
        {
            throw new NotImplementedException();
        }

        public string GetGender(int MemberID)
        {
            throw new NotImplementedException();
        }
    }
}
