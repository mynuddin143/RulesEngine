using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Repository
{
    public interface IRulesRepository
    {
        string GetRules(string type);
    }
}
