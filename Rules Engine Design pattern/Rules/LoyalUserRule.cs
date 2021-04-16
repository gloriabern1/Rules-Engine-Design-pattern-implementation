using Rules_Engine_Design_pattern.Engine;
using Rules_Engine_Design_pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rules_Engine_Design_pattern.Rules
{
    public class LoyalUserRule : IUserPromoRule
    {
        public decimal CalculatePromo(User user, decimal currentPromo)
        {
            if (user.DOfirstpurchase.HasValue)
            {
                if (user.DOfirstpurchase.Value < DateTime.Now.AddYears(-15))

                    return .15m;
                if (user.DOfirstpurchase.Value < DateTime.Now.AddYears(-10))

                    return .12m;
                if (user.DOfirstpurchase.Value < DateTime.Now.AddYears(-5))

                    return .10m;
                if (user.DOfirstpurchase.Value < DateTime.Now.AddYears(-2))

                    return .08m;
                if (user.DOfirstpurchase.Value < DateTime.Now.AddYears(-1))

                    return .05m;
            }
            return 0;
        }
    }

}
