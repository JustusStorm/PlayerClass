using System;

namespace PlayerClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var playerThree = new Player("Jeremiah", "Katana", 700, "Human");

            var playerOne = new Player();
            playerOne.AttackValue = 5;
            playerOne.Weapon = "Garden Tool";
            playerOne.Species = "Hobbit";
            playerOne.Name = "Jonny";
            

            var playerTwo = new Player()
            {
                AttackValue = 100,
                Name = "Bubba",
                Weapon = "Club",
                Species = "Ogre"
            };

            Console.WriteLine(playerThree.Species);

            playerOne.Speak();
            playerTwo.Speak();

            playerOne.Attack();

            playerTwo.RecieveDamage(playerOne.AttackValue);

            playerTwo.SayHealth();
        }
    }
}
