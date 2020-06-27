using BusinessRulesEngine.Repository;
using static BusinessRulesEngine.PaymentEnum;

namespace BusinessRulesEngine.DataAccess
{
    public class RulesDA : IRulesRepository
    {
        public string Result;
        public string GetRules(string type)
        {
            //individual logic's has to be taken care accordingly
            if(type== PaymentTypes.PhysicalProduct)
            {
                Result="Generate a PAcking Slip for shipping + generate a commission payment to agent";
            }
            if (type == PaymentTypes.Book)
            {
                Result = "Create a Duplicate packing slip for the royalty department + generate a commission payment to agent";
            }
            if (type == PaymentTypes.Membership)
            {
                Result = "Activate that membership and Send an Email to the owner";
            }
            if (type == PaymentTypes.UpgradeMembership)
            {
                Result = "Apply the UpgradeMembership and Send an Email to the owner";
            }
            if (type == PaymentTypes.VedioForLearningSki)
            {
                Result = "Add a first aid vedio to payment slip";
            }
            return Result;
        }
    }
}
