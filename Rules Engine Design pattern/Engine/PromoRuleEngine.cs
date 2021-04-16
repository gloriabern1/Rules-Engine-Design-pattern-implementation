using Rules_Engine_Design_pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rules_Engine_Design_pattern.Engine
{
    public class PromoRuleEngine
    {
        List<IUserPromoRule> _rules = new List<IUserPromoRule>();
        public PromoRuleEngine(IEnumerable<IUserPromoRule> rules)
        {
            _rules.AddRange(rules);

        }

        public decimal CalculatePromoPercentage(User user)
        {
            decimal promo = 0m;
            foreach (var rule in _rules)
            {
                promo = Math.Max(promo, rule.CalculatePromo(user, promo));
            }
            return promo;
        }
    }

}
