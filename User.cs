using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_01_2026_DigitalisNyomozas
{
    internal class User
    {
        private string nev;
        private string azonosito;
        private string szerepkor;

        public User(string nev, string azonosito, string szerepkor)
        {
            this.nev = nev;
            this.azonosito = azonosito;
            this.szerepkor = szerepkor;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Szerepkor { get => szerepkor; set => szerepkor = value; }
    }
    
}
