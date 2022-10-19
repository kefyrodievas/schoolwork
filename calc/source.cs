using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {   
        
        internal static void Main(string[] args)
        {
            // Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write(">> ");
            string veiksmas = Console.ReadLine();
            List<double> skaiciai = nparsing(veiksmas);
            List<char> veiksmai = oparsing(veiksmas);
            Console.WriteLine(skaiciai[0]);
            Console.WriteLine(veiksmai[0]);
        }

        public static List<double> nparsing(string veiksmas){
            List<double> skaiciai = new List<double>();
            int i = 0;
            double skaicius = 0;
            double multiplier = 10;
            bool dec = false;
            bool negative = false;
            int length = veiksmas.Length;
            while(i < length){
                
                if(veiksmas[i] >= '0' && veiksmas[i] <= '9'){
                    negative = veiksmas[i--] == '-' ? true : false;
                    skaicius = dec == false ? skaicius * multiplier + ((double)veiksmas[i] - 48) :
                    skaicius + multiplier * ((int)veiksmas[i] - 48);
                    multiplier = dec == false ? multiplier : multiplier / 10;
                }
                else if(veiksmas[i] == '.' || veiksmas[i] == ','){
                    dec = true;
                    multiplier = 0.1;
                }
                else skaiciai.Add((double)skaicius);
                i++;
                
            }
            return skaiciai;
        }
        public static List<char> oparsing(string veiksmas){
            List<char> veiksmai = new List<char>();
            int length = veiksmas.Length;
            int i = 0;
            while(i < length){
                if(veiksmas[i] < '0' || veiksmas[i] > '9'){
                    if(veiksmas[i] != ' ' && veiksmas[i] != '.' && veiksmas[i] != ',') veiksmai.Add(veiksmas[i]);
                }
                i++;
            }
            return veiksmai;
        }

        // public static double calc(List<double> nlist, List<char> olist){
        //     int numcount = 1;
        //     double ans = 0;
        //     ans += nlist[0];
        //     List<double> temp = new List<double>();
        //     for(int i = 0; i < olist.count; i++){
        //         switch(olist[i]){
        //             case'+':
        //                 if(olist[i++] != '*' || olist[i++] != '/'){
        //                     ans += nlist[numcount];
        //                     numcount++;
        //                 }
        //                 break;
        //             case'-':
        //                 if(olist[i++] != '*' || olist[i++] != '/'){
        //                     ans -= nlist[numcount];
        //                     numcount++;
        //                 }
        //         }
        //     }
        // }
    }
}