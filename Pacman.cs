using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_tehtävä6
{
    class Pacman
    {
        public int pisteet;
        public int elamat;

        public Pacman()
        {
            pisteet = 0;
        }

        public Pacman(int pisteet, int elamat)
        {
            this.pisteet = pisteet;
            this.elamat = elamat;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine(pisteet);
        }

        public void Syo(Hedelma fruit)
        {
            pisteet++;
            Console.WriteLine("Hedelmä syöty");
            fruit.Katoa();
        }

        public void VahennaElama()
        {
            elamat--;
            Console.WriteLine("Pacman syöty");
        }
        public override string ToString()
        {
            return "Pacmanin pisteet: " + this.pisteet + " Pacmanin elämät: " + this.elamat;
        }
    }
}
