using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1998, FirstName = "Ateş Can", LastName = "Ergün", IdentityNumber = 11810732428 });
        }
    }
}
