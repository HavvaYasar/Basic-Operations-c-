using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Ops
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {   //normally this data comes from source but here is showing logic by sending a simple data
            if (user.BirthDate==1985 && user.FirstName=="Havva"
                && user.LastName=="yasar" && user.IdentitityNumber==12345 &&  user.Id==1)
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
