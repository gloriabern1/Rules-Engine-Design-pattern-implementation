using Rules_Engine_Design_pattern.Engine;
using Rules_Engine_Design_pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rules_Engine_Design_pattern.Rules
{

    public class BirthdayRule : IUserPromoRule
    {
        public decimal CalculatePromo(User user, decimal currentPromo)
        {
            bool isBirthday = user.DOB.HasValue && user.DOB.Value.Day ==
             DateTime.Today.Day && user.DOB.Value.Month == DateTime.Today.Month;

            if (isBirthday) return currentPromo + .10m;
            return currentPromo;

        }
    }

}
