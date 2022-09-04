using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRAR_Interface
{
    public class VizeAgirlikliSinav:IOrtalama
    {
        //const sabit değer demektir değişmez
        //VizeAgirlikliSinav hesaplaması yapacağımız için const VizelYuzdesi değerini 0.60 veriyoruz

        private const double FinalYuzdesi= 0.40;
        private const double VizelYuzdesi= 0.60;

        //IOrtalamadan aldığımız metodumuzu hiç değiştirmeden const sabit değerimizi veredek metodumuza hesaplatıyoruz

        public double OrtalamaHesapla(double v1, double v2, double final)
        {
            return  ((v1 + v2) /2) * VizelYuzdesi + (final * FinalYuzdesi);
            
        }
    }
}
