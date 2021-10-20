using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            Console.WriteLine($"{hero} will fight {villain}");

            string heroWeapon = PickWeapon();
            string villainWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}, {villain} picked {villainWeapon}");
        }
        private static string PickWeapon()
        {
            string[] weapon = { "plastic fork",}
        }
        private static string PickHero()
        {
            string[] superHeroes = { "Luke Skywalker", "Batman", "Marko Vanhanen" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);
        }
        private static string PickVillain()
        {
            string[] villain = { "joker from the movie joker", "joker if he could beatbox", "Toivo" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villain.Length);

            return villain[randomIndex];
        }
    }
}
