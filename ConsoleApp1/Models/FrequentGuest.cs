using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mapping.Models
{
    public class FrequentGuest : Guest
    {
        public int LoyaltyPoints { get; set; } = 0;

        public MembershipLevel MembershipLevel { get; set; }

        public DateTime LastStayDate { get; set; }
    }
    public enum MembershipLevel
    {
        Silver, Gold, Platinum
    }
}

