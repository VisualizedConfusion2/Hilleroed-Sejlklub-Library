﻿using Hilleroed_Sejlklub_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilleroed_Sejlklub_Library.Interfaces
{
    public interface IMemberRepo
    {
        // Get a member based on Id  
        Member GetMember(int MemberID);

        // Get a list of all members  
        List<Member> Get();

        // Add a new member  
        void Add(Member member);

        // Delete a member by Id  
        void Delete(int MemberID);

        // Get contact info of a member by Id  
        string GetContactInfo(int MemberID);

        // Get gender of a member by Id  
        string GetGender(int MemberID);


    }
}
