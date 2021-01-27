using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
        // methoda alternatif refesanlar ekliyerek dinamiklik ve bilgilerin bağlantı sağlanır.
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }

}
