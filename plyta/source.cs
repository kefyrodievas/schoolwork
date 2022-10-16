using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plyta
{
    class Program
    {   
        
        internal static void Main(string[] args)
        {
            double[] sienosilgis = new double[4],
                //    sienosplotis = new double[4],
                   sienosaukstis = new double[4];
            for(int i = 0; i < 4; i++){
                Console.Write("Iveskite {0} sienos ilgi: ", i + 1);
                sienosilgis[i] = double.Parse(Console.ReadLine());
                Console.Write("Iveskite {0} sienos auksti: ", i + 1);
                sienosaukstis[i] = double.Parse(Console.ReadLine());
            }
            plyta[] p = new plyta[2];
            p[0] = new plyta(250, 120, 88);
            p[1] = new plyta(200, 115, 71);
            int[,] w = new int[2, 5];
            w[0, 4] = 0;
            w[1, 4] = 0;
            add(p, w, sienosilgis, sienosaukstis);
            output(w);            

        }

        static void add(plyta[] p, int[,] w, double[] sienosilgis, double[] sienosaukstis){
            for(int i = 0; i < 4; i++){
                w[0, i] = wall(p[0], sienosilgis[i], sienosaukstis[i]);
                w[1, i] = wall(p[1], sienosilgis[i], sienosaukstis[i]);
                w[0, 4] += w[0, i];
                w[1, 4] += w[1, i];
            }
        }
        static void output(int[,] w){
            for(int i = 0; i < 4; i++){
                Console.Write("{0, 6:d}{1, 6:d}\n", w[0, i], w[1, i]);
            }
            Console.Write("{0, 6:d}{1, 6:d}\n", w[0, 4], w[1, 4]);
        }

        static int wall(plyta p, double sienosilgis, double sienosaukstis){
            return(int)(sienosilgis * 1000 / p.retIlgis() * 
                   sienosaukstis * 1000 / p.retAukstis());
        }


    }
    class plyta
    {
        private int ilgis,
                    plotis,
                    aukstis;
        public plyta(int ilgis, int plocioreiksme, int aukscioreiksme)
        {
            this.ilgis = ilgis;
            plotis = plocioreiksme;
            aukstis = aukscioreiksme;
        }
        public int retIlgis(){ return ilgis; }
        public int retPlotis(){ return plotis; }
        public int retAukstis(){ return aukstis; }
    }
}