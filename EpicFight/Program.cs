using System;

namespace EpicFight
{
    class Program
   {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            int heroHP = GenerateHP(hero);
            int villainHP = GenerateHP(villain);
            Console.WriteLine($"{hero} will fight {villain}");

            string heroWeapon = PickWeapon();
            string villainWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}, {villain} picked {villainWeapon}");
            
            while(heroHP > 0 && villainHP > 0)
            {
                heroHP = heroHP - Hit(villain, hero, villainWeapon);
                villainHP = villainHP - Hit(hero, villain, heroWeapon);
            }
            if(heroHP <= 0)
            {
                Console.WriteLine("Dark side wins");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day");
            }


        }

        private static string PickWeapon()
        {
           string[] weapon = {"plastic fork", "kohvi", "viinaa", "flipflops"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, weapon.Length);
            return weapon[randomIndex];
        }

        private static int Hit(string someName, string characterOne, string characterTwo, string someWeapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, someWeapon.Length / 2);
            Console.WriteLine($"{characterOne} hit {strike}");
            if(strike == someWeapon.Length / 2)
            {
                Console.WriteLine($"{characterOne} made a critical hit!");
            }
            Console.WriteLine($"{someName} hit {strike}.");
            if(strike == someWeapon.Length / 2)
            {
                Console.WriteLine($"{someName} made a critical hit!");
            }
            else if (strike == 0)
            {
                Console.WriteLine($"aww {characterTwo} dodged the attack");
            }
            return strike;
        }
        private static int GenerateHP(string someName)
        {
            Random rnd = new Random();
            return rnd.Next(someName.Length, someName.Length + 10);
        }

        private static string PickHero()
        {
           string[] superHeroes = {"Luke Skywalker", "Batman", "Marko Vanhanen", "bbl drake"};
           Random rnd = new Random();
           int randomIndex = rnd.Next(0, superHeroes.Length);
            return superHeroes[randomIndex];
        }

        private static string PickVillain()
        {
            string[] villain = {"joker from the movie joker", "joker if he could beatbox", "Toivo", "emo"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villain.Length);
            return villain[randomIndex];  
        }

    }
}
