using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*İhtiyackrediManager ihtiyackrediManager = new İhtiyackrediManager();
            ihtiyackrediManager.hesapla();

            TaşıtKrediManager taşıtKrediManager = new TaşıtKrediManager();
            taşıtKrediManager.hesapla();

            Konutkredimanager konutkredimanager = new Konutkredimanager();
            konutkredimanager.hesapla(); */
            // bu iki şekildede olur ikiside birbirinin referans numarasını tutabilir.



            IKrediManager ihtiyackrediManager = new İhtiyackrediManager();
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();
            IKrediManager konutkredimanager = new Konutkredimanager();

            ILoggerService databaseloggerservices = new DatabaseLoggerService();
            ILoggerService FileLoggerservices = new FileLoggerService();

            List<ILoggerService> loggerservices = new List<ILoggerService>() { FileLoggerservices, databaseloggerservices };

            BasvuruManager basvurumanager = new BasvuruManager();
            basvurumanager.BasvuruYap(konutkredimanager, loggerservices);
            
            List<IKrediManager> krediler = new List<IKrediManager>() 
            { ihtiyackrediManager,taşıtKrediManager};

            //basvurumanager.KrediOnBilgilendirmesiYap(krediler);


          

        }
        
    }
}
