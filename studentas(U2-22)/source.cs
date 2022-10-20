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
            s.detilit(125);
            s.deticent(36);
            Cukrus c1 = new Cukrus(0, "a");
            Cukrus c2 = c1;
            Cukrus c3 = c1;
            while (true) {
                Console.Write(">>");
                c1 = input(c1);
                c2 = input(c2);
                c3 = input(c3);
                for(int i = 0; i < 3; i++)
                {
                    Console.Write("cukraus pavadinimas:{0, 10} \ncukraus kaina:{1, 16}\n",
                    (i == 0 ? c1.getman() : i == 1 ? c2.getman() : c3.getman()),        //ternary operator fuckery since arrays are haram
                    (i == 0 ? c1.getprice() : i == 1 ? c2.getprice() : c3.getprice()));
                }
                Console.Write("brangiausias cukrus:{0, 10}\n",
                retmax(c1, c2, c3) == 0 ? c1.getman() : retmax(c1, c2, c3) == 1 ? c2.getman() : c3.getman());
                
            }
            //input(c);




        }

        public static int retmax(Cukrus c1, Cukrus c2, Cukrus c3)
        {
            double max = 0;
            int maxc = 0;
            for(int i = 0; i < 3; i++)
            {
                maxc = (i == 0 ? c1.getprice() : i == 1 ? c2.getprice() : c3.getprice()) > max ? i : maxc; //ternary operator fuckery since arrays are haram
                max = (i == 0 ? c1.getprice() : i == 1 ? c2.getprice() : c3.getprice()) > max ?
                (i == 0 ? c1.getprice() : i == 1 ? c2.getprice() : c3.getprice()) : max;
            }
            return maxc;
        }

    // i == 0 ? c1.getprice() : i == 1 ? c2.getprice() : c3.getprice()
        public static Cukrus input(Cukrus c)
        {
            string foo;
            foo = Console.ReadLine();
            c = parse(foo, c);
            return c;
        }

        public static Cukrus parse(string foo, Cukrus c)
        {
            string man = "";
            double price = 0;
            int i = 0;
            while(i < foo.Length && foo[i] != ' ')
            {
                man += foo[i];
                i++;
            }
            i++;
            while(i < foo.Length && foo[i] >='0' && foo[i] <= '9')
            {
                price *= 10;
                price += foo[i] - 48;
                i++;
            }
            c = new Cukrus(price, man);
            return c;

        }
        
    }
    
    class Cukrus
    {
        private double price;
        private string man;
        private int[] date;

        public Cukrus(double price, string man/*, int[] date*/) {
            this.price = price;
            this.man = man;
            this.date = date;
        }
        
        public double getprice() { return price; }
        public string getman() { return man; }
    }

    class Studentas
    {
        private int lit, cent;

        public Studentas()
        {
            // int lit, cent;
        }

        public void detilit(int lit)
        {
            this.lit = lit;
        }
        public void deticent(int cent)
        {
            this.cent = cent;
        }

        public int retlit() { return lit; }
        public int retcent() { return cent; }
    }
}