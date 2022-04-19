using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77DersStructs
{
    struct Kitap
    {
        public string Yazar { get; set; }
        public string kitapAdi;
        public double fiyat;
        public Kitap(string kA,double f)
        {
            this.Yazar = "Null";
            this.kitapAdi = kA;
            this.fiyat = f;

        }
    }

    // class:  Komplex yapilarda kullanilir. Kalitim (inheritance) var.
    // struct: Basic yapilarda kulanilir. Kalitim (inheritance) yok.

    class Program
    {
        static void Main(string[] args)
        {
            Kitap k1 = new Kitap("Suc ve Ceza", 20.25);

        

            Console.WriteLine(k1.kitapAdi, k1.fiyat);


            Kitap k2; //Struct Ornegi
            int x;    //Struct Ornegi
            float y;  //Struct Ornegi
        }
    }
}
