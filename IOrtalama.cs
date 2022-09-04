using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRAR_Interface
{
    public interface IOrtalama
    {
        //interfacemizi public yaptık diğer classlardan ulaşabilmek için
        //interface oluşturup burada ortalama hsaplama metodu yazıyoruz
        //Final ağırlıklı ve vize ağırlıklı ortalamaları hesaplamak için kalıtım verdireceğiz
        //öyle bir metod oluşturduk ki iki tiptede metodumuzu değiştirmeden kullanabiliyoruz
        

        double OrtalamaHesapla(double v1, double v2, double final);//=> metod
    }
}
