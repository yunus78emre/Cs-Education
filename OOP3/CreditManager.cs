using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //**interfaceleri biririnin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    //loglama kim ne zaman hangi operasyonu çağırdığnı gösteren sistemde olan hareketleri döktüğümüz durum
    interface ICreditManager
    {
        void Calculate();
        
    }
}
