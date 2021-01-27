using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.BirthYear == 1989 && gamer.FirstName == "ADEM" && gamer.LastName == "URAS" && gamer.IdentityNumber == 12345678901)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
