using Rules_Engine_Design_pattern.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Rules_Engine_Design_pattern.Engine
{
    public class PromoCalculator
    {

        public decimal CalculatePromoPercentage(User user)
        {
            //A more elegant alternative to the part commented out below. This approach uses reflection
            // in getting the type of the 'Iuserpromorule' interface and all the classes that implement that interface.
            //While also creating new instances of the classes that 
            // implement the 'Iuserpromorule' interface

            var ruletype = typeof(IUserPromoRule);
            IEnumerable<IUserPromoRule> rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruletype.IsAssignableFrom(p) && !p.IsInterface).Select(r => Activator.CreateInstance(r) as IUserPromoRule);


            //var rules = new List<IUserPromoRule>();
            //rules.Add(new FirstTimeUserRule());
            //rules.Add(new LoyalUserRule());
            //rules.Add(new MilitaryUserRule());
            //rules.Add(new ElderlyUserRule());
            //rules.Add(new BirthdayRule());

            var engine = new PromoRuleEngine(rules);
            return engine.CalculatePromoPercentage(user);
        }
    }
}

