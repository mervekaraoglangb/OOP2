using System;
using System.Collections.Generic;
using System.Text;

namespace ödev5oyunsimule
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(gamer Gamer)
        {
           if(Gamer.Birthyear==2000 && Gamer.FirstName == "Merve"&& Gamer.LastName=="Karaoğlan" && Gamer.IDentityNumber==200510083)
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
