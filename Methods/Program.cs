using System;

namespace Methods
{
    internal class Program
    {
        static int health = 10;
        static int enemy = 10;
        static int points = 0;
        static int multiplier = 1;
        static Random rdn = new Random();
        static void Main(string[] args)
        {
            int damage = 3;
            while (true)
            {
                int j = (rdn.Next(1, 5));
                //Console.WriteLine(j);
                
                if (j == 1)
                {
                    Console.WriteLine("You took damage");
                    multiplier = 1;
                    TakeDamage(damage);
                    ShowHUD();
                }
                else if (j == 2)
                {
                    Console.WriteLine("Nothing happened...");
                    ShowHUD();
                }
                else if (j == 3)
                {

                    Console.WriteLine("You earned points and hit the enemy");
                    enemy = enemy - 2;
                    multiplier  = multiplier + 1;
                    points = AddScore(points, multiplier);
                    ShowHUD();
                }
                else if (health > 0)
                {
                    if (health == 10)
                    {
                        Console.WriteLine("Health is full");
                        ShowHUD();
                    }
                    else
                    {
                        Console.WriteLine("You healed");
                        health = health + 1;
                        ShowHUD();
                    }
                }
                if (health <= 0)
                {
                    Console.WriteLine("You Lost");
                    Console.ReadKey(true);
                    break;
                }
                if (enemy == 0)
                {
                    Console.WriteLine("You WIN");
                    Console.ReadKey(true);
                    break;
                }
                Console.ReadKey(true);
            }

                
            
        }

        static void ShowHUD()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++");
            Console.WriteLine("Health : " + health);
            Console.WriteLine("Score: " + points);
            Console.WriteLine("Combo: X" + multiplier);
            Console.WriteLine("Enemy health : " + enemy);
            Console.WriteLine("++++++++++++++");
            Console.WriteLine();
        }

        static void TakeDamage(int damage)
        {
            health = health - damage;
        }

        static int AddScore(int pointsEarned, int scoreMultiplier)
        {
            return pointsEarned = pointsEarned + 100 * scoreMultiplier;
        }
    }
}
