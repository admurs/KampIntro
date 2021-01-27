using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager=new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer{Id = 1,BirthYear = 1989,FirstName = "ADEM",LastName = "URAS",IdentityNumber = 12345678901});

        }
    }
}
