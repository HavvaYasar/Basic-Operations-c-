using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Ops
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public void Save(User user)
        {
            if(_userValidationService.Validate(user) == true)
             {
                Console.WriteLine("saved");
               
             }
            else
            {
                Console.WriteLine("validation failed");
            }
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
