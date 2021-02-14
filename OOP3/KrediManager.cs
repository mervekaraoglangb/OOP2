using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface- şablon - arayüz
    //interface genellikle oprerasyonel konularda kullanılır.
    interface IKrediManager
    {
        void hesapla();
        void biseyyap();
        

        
    }//ÖNEMLİ - interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan duurmlar için kullanılır.
    //bu örenkete kredi türlerde hesaplanma vardır bunlar birbirine ortaktır. IkrediManagerde biz referans tipleri tutarız

}
