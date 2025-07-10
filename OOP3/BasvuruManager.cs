using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager , ILoggerService loggerService)
        {
            // Başvuran bilgilerini değerlendirme
            Console.WriteLine("Başvuru bilgileri değerlendirildi.");
            creditManager.Calculate();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List <ICreditManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Calculate();
            }
        }
    }
}
