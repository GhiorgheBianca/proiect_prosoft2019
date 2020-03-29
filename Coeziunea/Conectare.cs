using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coeziunea
{
    class Conectare
    {
        //pentru accesarea bazei de date

        private static string var;
        public static string variabila
        {
            get { return var; }
            set { var = value; }
        }

        //

        //conectat sau deconectat

        private static string email;
        public static string conectat
        {
            get { return email; }
            set { email = value; }
        }

        //

        //profesor sau inspector

        private static int statut = -2;
        public static int status
        {
            get { return statut; }
            set { statut = value; }
        }

        //

        private static string clasa;
        public static string Clase
        {
            get { return clasa; }
            set { clasa = value; }
        }

        //intrebari

        private static int[] quest;
        public static int[] Ordine_Intrebari
        {
            get { return quest; }
            set { quest = value; }
        }

        private static int nr_intreb;
        public static int Numar_Intrebare
        {
            get { return nr_intreb; }
            set { nr_intreb = value; }
        }

        private static int nr_total;
        public static int Total
        {
            get { return nr_total; }
            set { nr_total = value; }
        }

        private static double sum_rezult;
        public static double Rezultat
        {
            get { return sum_rezult; }
            set { sum_rezult = value; }
        }

        //

        //cronometru

        private static int timeCs = 0;
        public static int TimeCs
        {
            get { return timeCs; }
            set { timeCs = value; }
        }

        private static int timeSec = 0;
        public static int TimeSec
        {
            get { return timeSec; }
            set { timeSec = value; }
        }

        private static int timeMin = 0;
        public static int TimeMin
        {
            get { return timeMin; }
            set { timeMin = value; }
        }

        //

        //verificare schimbare parola

        private static string parola;
        public static string Parola
        {
            get { return parola; }
            set { parola = value; }
        }

        private static bool adevarat;
        public static bool VerifPar
        {
            get { return adevarat; }
            set { adevarat = value; }
        }

        //

        //reține id-ul mesajului selectat

        private static int mesaj;
        public static int Mesaje
        {
            get { return mesaj; }
            set { mesaj = value; }
        }

        //
    }
}
