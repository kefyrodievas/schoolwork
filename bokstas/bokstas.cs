using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bokstas
{
    class Program
    {   
        
        internal static void Main(string[] args)
        {
            double[] sienosilgis = new double[3],
                   sienosplotis = new double[3],
                   sienosaukstis = new double[3];
            for(int i = 0; i < 2; i++){
                Console.Write("Iveskite {0} sienos ilgi: ", i + 1);
                sienosilgis[i] = double.Parse(Console.ReadLine());
                Console.Write("Iveskite {0} sienos auksti: ", i + 1);
                sienosaukstis[i] = double.Parse(Console.ReadLine());
                Console.Write("Iveskite {0} sienos ploti: ", i + 1);
                sienosplotis[i] = double.Parse(Console.ReadLine());
            }
            bokstas b = new bokstas(2.5, 5.2, 0.5);
            plyta p = new plyta(250, 120, 90);
            sienosaukstis[2] = b.retAukstis();
            sienosplotis[2] = b.retPlotis();
            sienosilgis[2] = Math.PI * b.retSkers();
            total t = new total(wall(p, sienosilgis[0], sienosaukstis[0], sienosplotis[0]),
                                wall(p, sienosilgis[1], sienosaukstis[1], sienosplotis[1]),
                                wall(p, sienosilgis[2], sienosaukstis[2], sienosplotis[2]));

            Console.Write("Bokstai:{0, 6:d}  \nSienos:{1, 6:d}", 4 * t.b1(), 2 * t.s1() + 2 * t.s2());


            // add(p, w, sienosilgis, sienosaukstis);
            // output(w);            

        }

        // static void output(int[,] w){
        //     for(int i = 0; i < 4; i++){
        //         Console.Write("{0, 6:d}{1, 6:d}\n", w[0, i], w[1, i]);
        //     }
        //     Console.Write("{0, 6:d}{1, 6:d}\n", w[0, 4], w[1, 4]);
        // }

        static int wall(plyta p, double sienosilgis, double sienosaukstis, double sienosplotis){
            return(int)(sienosilgis * 1000 / p.retIlgis() * 
                        sienosaukstis * 1000 / p.retAukstis() *
                        sienosplotis * 1000 / p.retPlotis());
        }


    }

    class total{
        private double siena1, 
               siena2,
               bokstas;

        public total(double siena1, double siena2, double bokstas){
            this.siena1 = siena1;
            this.siena2 = siena2;
            this.bokstas = bokstas;
        }
        public int s1(){ return (int)siena1; }
        public int s2(){ return (int)siena2; }
        public int b1(){ return (int)bokstas; }
    }

    class bokstas{
        private double aukstis, 
               skersmuo,
               plotis;

        public bokstas(double aukstis, double skersmuo, double plotis){
            this.aukstis = aukstis;
            this.skersmuo = skersmuo;
            this.plotis = plotis;
        }
        public double retSkers(){ return skersmuo; }
        public double retPlotis(){ return plotis; }
        public double retAukstis(){ return aukstis; }
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