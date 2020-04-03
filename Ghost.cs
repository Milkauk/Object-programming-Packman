using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_tehtävä6
{
    class Ghost
    {
        public void SyoPacman(Pacman pacman)
        {
            pacman.VahennaElama();
            Console.WriteLine("Ghost söi pacmanin");
        }

    }
}
