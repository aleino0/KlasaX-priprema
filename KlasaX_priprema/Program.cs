using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaX_priprema
{
    class KlasaX
    {
        private int broj;

        public int Broj { get => broj; set => broj = value; }
        
        public KlasaX(int broj1) 
        {
            broj = broj1;
        }
        public override string ToString()
        {
            return "vrijednost varijable broj je " + broj;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaX broj = new KlasaX(10);
            Console.WriteLine(broj);
            Console.ReadKey();
        }
    }
}
