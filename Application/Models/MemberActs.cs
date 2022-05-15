﻿using Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class MemberActs
    {
        public Member GetMember(int paramMemberNumber)
        {
            MemberData memberData = new MemberData();
            
            // LINQ
            return memberData.Members.Where(x => x.Member_Number == paramMemberNumber).SingleOrDefault();
        }
    }
}