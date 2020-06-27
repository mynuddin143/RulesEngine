using BusinessRulesEngine.DataAccess;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using static BusinessRulesEngine.PaymentEnum;

namespace Test
{
    public class RulesUnitTests
    {
        [Test]
        public void GetRules_PhysicalProduct()
        {
            string type = PaymentTypes.PhysicalProduct;
            RulesDA rules = new RulesDA();
            string result = rules.GetRules(type);


            Assert.AreEqual("Generate a PAcking Slip for shipping + generate a commission payment to agent",result);
        }

        [Test]
        public void GetRules_Book()
        {
            string type = PaymentTypes.Book;
            RulesDA rules = new RulesDA();
            string result = rules.GetRules(type);


            Assert.AreEqual("Create a Duplicate packing slip for the royalty department + generate a commission payment to agent", result);
        }

        [Test]
        public void GetRules_Membership()
        {
            string type = PaymentTypes.Membership;
            RulesDA rules = new RulesDA();
            string result = rules.GetRules(type);


            Assert.AreEqual("Activate that membership and Send an Email to the owner", result);
        }

        [Test]
        public void GetRules_UpgradeMembership()
        {
            string type = PaymentTypes.UpgradeMembership;
            RulesDA rules = new RulesDA();
            string result = rules.GetRules(type);


            Assert.AreEqual("Apply the UpgradeMembership and Send an Email to the owner", result);
        }

        [Test]
        public void GetRules_VedioForLearningSki()
        {
            string type = PaymentTypes.VedioForLearningSki;
            RulesDA rules = new RulesDA();
            string result = rules.GetRules(type);


            Assert.AreEqual("Add a first aid vedio to payment slip", result);
        }
    }
}
