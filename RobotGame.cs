using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRobotGamev1
{
    class Robot
    {
        string name;
        int powerLevel = 0;
        int speed;
        int ammo;
        int health;
        bool hasWeapon;
        string weapon;
        int bodyArmor;
        double killPercentage;
        int answer; 

        public Robot()
        {

        }
        public void PowerUp()
        {
            Console.WriteLine("Press 1 to power up.");
            int answer = Convert.ToInt32(Console.ReadLine());
            
            while (powerLevel < 500)
            {

                if (answer == 1)
                {
                    powerLevel += 100;
                    Console.WriteLine("Your power level is at " + powerLevel + "...keep adding?");
                    Console.ReadLine();

                }
                
                {
                   
                }
                
            }
            Console.WriteLine("You have reached maximum power!");
            Console.ReadLine();
         
        }
        public int SpeedUp()
        {
            speed += 15;
            return speed;
        }
        public string GetWeapon(string SelectWeapon)
        {
            return weapon;
        }
    }
}
