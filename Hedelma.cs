using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_tehtävä6
{
    class Hedelma
    {
        public bool nakyvissa;

        public Hedelma()
        {
            nakyvissa = true;
        }
        public void Katoa()
        {
            nakyvissa = false;
            Console.WriteLine("Hedelmä piilotettu");
        }
    }
}
