using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_tehtävä6
{
    class Program
    {
        //Jatka videossa tehtyä koodia.
        //Lisää Pacmanille attribuutti ”elamat”.
        //Lisää Pacmanille metodi ”VahennaElama”, joka tulostaa konsoliin ”Pacman syöty” ja vähentää elämistä yhden.
        //Tee yksinkertainen Ghost-luokka, jolla on metodi: SyoPacman. Kun Ghost syö Pacmanin (eli kutsutaan SyoPacman-metodia), kutsutaan Pacmanin VahennaElama-metodia.


        static void Main(string[] args)
        {
            Pacman pacman = new Pacman(3,3);

            Hedelma fruit1 = new Hedelma();
            Hedelma fruit2 = new Hedelma();
            Hedelma fruit3 = new Hedelma();

            Ghost kummitus = new Ghost();

            pacman.Syo(fruit1);

            Console.WriteLine("Mitkä hedelmät näkyvät:");
            Console.WriteLine(fruit1.nakyvissa);
            Console.WriteLine(fruit2.nakyvissa);
            Console.WriteLine(fruit3.nakyvissa);

            pacman.VahennaElama();
            Console.WriteLine(pacman);

            kummitus.SyoPacman(pacman);
            Console.WriteLine(pacman);

            Console.ReadKey();
        }
    }
}
