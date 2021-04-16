using Rules_Engine_Design_pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rules_Engine_Design_pattern.Engine
{
    public interface IUserPromoRule
    {
        decimal CalculatePromo(User user, decimal currentPromo);
    }
}
