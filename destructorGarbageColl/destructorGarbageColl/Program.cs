using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructorGarbageColl
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
                new Ornek(i);
            // referansız nesne oluşturma.


            Console.WriteLine("*******************");

            GC.Collect();


            Console.Read();
        }
    }

   
    class Ornek
    {
        int numara;
        //Sınıf ismi aynı olan method constructor  metodudur. Dönüş değeri yok.
        // ilk tetiklenecek constructor'dır.
        // Yapıcı Method.
        public Ornek(int id)
        {
            numara = id;
            Console.WriteLine(numara + "Nesne Üretildi.");
        }


        #region Destructor
        
        //Yıkıcı metod.
        ~Ornek()
        {
            Console.WriteLine(numara +"Nesne Siliniyor.");
        }

        #endregion
    }

}
