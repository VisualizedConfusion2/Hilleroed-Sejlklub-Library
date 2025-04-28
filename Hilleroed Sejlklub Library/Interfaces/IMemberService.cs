using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Interfaces
{
    interface IMemberService
    {
        // Get a member based on Id
        Member GetMember(int Id);

        // Get a list of all members
        List<Member> GetMembers();

        // Add a new member
        void Add(Member member);

        // Delete a member by Id
        void Delete(int Id);
    }
}
