using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {// method injection - metodun kullanacagı hangi kredi veya logun gönderilecegini yapıyoruz
        public void BasvuruYap(IKrediManager kredimanager, List<ILoggerService> Loggerservices)
        {
            //public voide ne gönderirsek onun referansı çalışır
            //başvuran Bilgilerini Degerlendirme
            //
            
            kredimanager.hesapla();
            foreach (var loggerservice in Loggerservices)
            {
                loggerservice.Log();
            }


        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.hesapla();

            }
        }


    }
}
