﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
         if (gamer.BirthYear==1998 && gamer.FirstName == "Ateş Can" && gamer.LastName == "Ergün" && gamer.IdentityNumber == 11810732428)
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
