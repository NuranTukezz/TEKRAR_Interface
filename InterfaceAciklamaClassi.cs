using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEKRAR_Interface
{
    class InterfaceAciklamaClassi
    {
        //Abstracc class'ta da Interfacede'de metod body'si yok bu clssları miras(Abstrac) ve implemente(Interface) ederken 
        //neden abstract override olarak gelir interface return isteyerek gelir =>
        //Interface yapıyı değiştirmek için kullanılır



        /*
        1- interface ve abstract class’lar new anahtar sözcüğü ile oluşturulamazlar.
        2- Bir sınıf birden fazla interface’i kalıtım olarak alabilir ama bir sınıfa bir tane abstract class kalıtım alınabilir.
        3- Interface içerisinde boş metodlar tanımlanabilir ama abstract class’larda hem boş metodlar tanımlanabilir 
        hemde içi dolu metodlar tanımlabilir.
         4- Abstract sınıflar içerisinde metod gövdeleri tanımlanıp özellik değerleri ayarlandığı için 
        genellikle sonradan üzerine ek geliştirilmek yapmak için kullanılıır ama interface de ise 
        body ve değer set edilemediği için tamamen interface üzerinden tüm üyeleri implemente edilerek
        sıfırdan geliştirmeler yapılması gereken durumlarda kullanılır.
        5- Abstract class’lar içerisinde sadece abstract olarak işaretlenmiş metod ve özellikler implement edilmek zorundadır
        fakat interface içerisindeki tüm özellik ve metodlar implement edilmek zorundadır.
        6- Bir class bir tane abstract class’ı kalıtım olarak alabilir ama bir class istenilen sayıda interface’i kalıtım olarak alabilir.
        7- Interface içerisinde özellik ve metodlarda erişim belirleyiciler kullanılmaz herşey public olarak kabul edilir fakat abstract sınıflarda kullanılabilir.
        8- Abstract sınıflara diğer sınıf ve interface’ler kalıtım olarak geçilebilir fakat interface’e yine farklı interface’ler haricinde herhangi bir yapı kalıtım olarak geçilemez.
 
         */




    }
}
