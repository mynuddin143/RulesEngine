using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    public class PaymentEnum
    {
        public static class PaymentTypes
        {
            public const string PhysicalProduct= "PhysicalProduct";
            public const string Book = "Book";
            public const string Membership = "Membership";
            public const string UpgradeMembership = "UpgradeMembership";
            public const string VedioForLearningSki = "VedioForLearningSki";

        }
    }
}
