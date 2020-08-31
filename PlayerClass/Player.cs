using System;
namespace PlayerClass
{
    public class Player
    {
        public Player()
        {

        }

        public Player(string name, string weapon, int attackValue, string species)
        {
            Name = name;
            Weapon = weapon;
            AttackValue = attackValue;
            Species = species;
        }



        private int health = 1000;

        public string Name { get; set; }
        public string Weapon { get; set; }
        public int AttackValue { get; set; }
        public string Species { get; set; }

        public void RecieveDamage(int damageAmount)
        {
            health -= damageAmount;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name}: attacking with my {Weapon}!");
        }

        public void Speak()
        {
            Console.WriteLine($"{Name}: speaking in language of {Species}: Hello!");
        }

        public void SayHealth()
        {
            Console.WriteLine($"{Name}'s health is {health}");
        }
    }
}
