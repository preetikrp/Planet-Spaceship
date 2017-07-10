using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet_Spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastPlanets);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");
            Console.WriteLine("List of all planets after removing Pluto...");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);

            }
            Console.ReadLine();

            Console.WriteLine("List of Rocky Planets...");

            foreach (string planet in rockyPlanets)
            {
                Console.WriteLine(planet);

            }
            Console.ReadLine();

            Dictionary<string, string> PlanetSpacecraft = new Dictionary<string, string>();

            PlanetSpacecraft.Add("Mercury", "Mariner 10, MESSENGER, BepiColombo");
            PlanetSpacecraft.Add("Venus", "Sputnik 7, Venera 1, Mariner 1, Sputnik 19,Sputnik 20, Sputnik 21, Mariner 2 ");
            PlanetSpacecraft.Add("Earth", "Mars 1960A, Mars 1960B, Mars 1962A, Mars 1962B, Mariner 3, Mariner 4, Mariner 6, Mariner 7 ");
            PlanetSpacecraft.Add("Mars", "Mangalyaan");
            PlanetSpacecraft.Add("Jupiter", "Pioneer 10, Pioneer 11, Voyager1, Voyager2,");
            PlanetSpacecraft.Add("Saturn", "Voyager1, Pioneer 11, Voyager 2 ");
            PlanetSpacecraft.Add("Uranus", "Voyager 2");
            PlanetSpacecraft.Add("Neptune", "Voyager 2");

            Console.WriteLine("List of planets with the spacecrafts visited them...");
            foreach (KeyValuePair<string, string> planets in PlanetSpacecraft)
            {
                Console.WriteLine("{0} : {1}", planets.Key, planets.Value);


            }
            Console.ReadLine();
        }
    }
}
