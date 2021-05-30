using System;

namespace Basic_Ops
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.Save(new User { Id = 1, BirthDate = 1985, FirstName = "havva", LastName = "yasar" });
            Console.ReadLine();
        }

        
    }       
}
