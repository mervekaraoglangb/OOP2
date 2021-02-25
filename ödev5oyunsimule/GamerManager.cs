using System;
using System.Collections.Generic;
using System.Text;

namespace ödev5oyunsimule
{
    //Microservices
    class GamerManager : IGamerService

    {
        IUserValidationService userValidationService;//manager içinde manager oluşturmak istenirse

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void add(gamer gamer)
        {
            if (userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
            
        }

        public void Delete(gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(gamer gamer)
        {
            Console.WriteLine("Kayıt  Güncellendi");
        }
    }
}
