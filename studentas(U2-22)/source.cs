using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chashtag
{
    class Program
    {   
        
        internal static void Main(string[] args)
        {
            Studentas s = new Studentas();
            s.detilit(10);
            s.deticent(10);
            Console.Write("litu:{0, 9:d}\ncentu:{1, 8:d}", s.retlit(), s.retcent()); 
        }
    }

    class Cukrus{
        private double price;
        private string man;
    }

    class Studentas{
        private int lit, cent;

        public Studentas(){
            // int lit, cent;
        }

        public void detilit(int lit){
            this.lit = lit;
        }
        public void deticent(int cent){
            this.cent = cent;
        }

        public int retlit(){ return lit; }
        public int retcent(){ return cent; }
    }
}