using Rules_Engine_Design_pattern.Engine;
using Rules_Engine_Design_pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rules_Engine_Design_pattern.Rules
{
    public class FirstTimeUserRule : IUserPromoRule
    {
        public decimal CalculatePromo(User user, decimal currentPromo)
        {
            if (!user.DOfirstpurchase.HasValue)
            {
                return .15m;
            }
            return 0;
        }
    }
}
