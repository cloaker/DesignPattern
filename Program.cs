using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetStrategyPattern();
        }

        public static void GetStrategyPattern()
        {
            //--------------------------------------------------------------------------------------------------
            //strategy pattern
            //--------------------------------------------------------------------------------------------------
            IWeapon weapon = null;
            var myCharacter = new Character();

            while (true)
            {
                Console.WriteLine("Choose a weapon for Xalto!  ( 1 = Sword, 2 = Axe, 3 = Club )");
                String input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        weapon = new Sword();
                        break;
                    case "2":
                        weapon = new Axe();
                        break;
                    case "3":
                        weapon = new Club();
                        break;
                    default:
                        break;
                }

                myCharacter.SetWeapon(weapon);
                myCharacter.Attack();
            }
        }
    }
}

