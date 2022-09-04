using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRAR_Interface
{
    public class FinalAğirlikliSinav : IOrtalama
    {
        //const sabit değer demektir değişmez
        //FinalAğirlikliSinav hesaplaması yapacağımız için const FinalYuzdesi değerini 0.60 olarak yazıyoruz

        private const double FinalYuzdesi = 0.60;
        private const double VizelYuzdesi = 0.40;

        //IOrtalamadan aldığımız metodumuzu hiç değiştirmeden const sabit değerimizi veredek metodumuza hesaplatıyoruz
        public double OrtalamaHesapla(double v1, double v2, double final)
        {
            return ((v1 + v2) / 2) * VizelYuzdesi + (final * FinalYuzdesi);
        }
    }
}
