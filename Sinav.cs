using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRAR_Interface
{
    public class Sinav
    {
        //sinav adında bir class oluşturduk burada proplarımızı tanımladık

        public string Adi { get; set; }
        public double Vize1 { get; set; }
        public double Vize2 { get; set; }
        public double Final { get; set; }
        public SinavTip SinavTip { get; }//oluşturduğumuz enum'u okumak için yazdık
        public DersAdi DersAdi { get; }//oluşturduğumuz enum'u okumak için yazdık




        public Sinav()
        {

        }

        //oluşturduğumuz ctor parametreli enum değerini alırken buradan okuma yapacak

        public Sinav(DersAdi dersAdi)
        {
            this.DersAdi = dersAdi;
        }

        //oluşturduğumuz ctor parametreli enum değerini alırken buradan okuma yapacak
        public Sinav(SinavTip sinavTip)
        {
            this.SinavTip = sinavTip;
        }

        //genel olarak ortalama hesaplayan bir metod oluşturduk burada vize ve final ağırlıklı ortalamayı seçerek hesaplama yapıyor
        public double OrtalamaHesapla()
        {
            //Sınav tipimiz FinalAğırlıklı ise
            if (SinavTip==SinavTip.FinalAgirlikliSinav)
            {
                //FinalAğırlıklıSınav'ı new'liyoruz
                FinalAğirlikliSinav finalAğirlikliSinav = new FinalAğirlikliSinav();
                //finalAgirlikliSinav. dedikten sonra o class'taki OrtalamaHesapla metodumuzu çağırıyoruz 
                //metod bizden parametre isteyecektir ne istediğini okuyarak parametreyi vermeliyiz

                return finalAğirlikliSinav.OrtalamaHesapla(v1:this.Vize1,v2: this.Vize2,final: this.Final);
            }

            //VizeAgirlikliSinav class'ımızı newliyoruz
            VizeAgirlikliSinav vizeAgirlikliSinav = new VizeAgirlikliSinav();

            //vizeAgirlikliSinav. dedikten sonra classımızın içindeki OrtalamaHesapla metodumuzu çağırıyoruz
            //metod bizden parametre isteyecektir ne istediğini okuyarak parametreyi vermeliyiz
            return vizeAgirlikliSinav.OrtalamaHesapla(v1: this.Vize1, v2: this.Vize2, final: this.Final);

        }



    }
}
