using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy;
using DesignPattern.NullObject;
using DesignPattern.Singleton;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Choose a design pattern. 1 = Strategy, 2=Null Object, 3= Singleton, 4=Observer, 5=Iterator");
                Console.WriteLine("type 'exit' and hit enter to stop");
                String chosenPattern = Console.ReadLine();

                switch (chosenPattern)
                {
                    case "1":
                        CallStrategyPattern();
                        break;
                    case "2":
                        CallNullObjectPattern();
                        break;
                    case "3":
                        CallSingletonPattern();
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }

                //exit loop
                if (chosenPattern.ToLower() == "exit")
                {
                    break;
                }
            }
      
        }

        public static void CallStrategyPattern()
        {
            //--------------------------------------------------------------------------------------------------
            //strategy pattern
            //--------------------------------------------------------------------------------------------------
            IWeapon weapon = null;
            var myCharacter = new Character();

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
            }

            myCharacter.SetWeapon(weapon);
            myCharacter.Attack();
          
        }

        public static void CallNullObjectPattern()
        {
            //--------------------------------------------------------------------------------------------------
            //strategy pattern
            //--------------------------------------------------------------------------------------------------
            IWeapon weapon = null;
            var myCharacter = new Character();

            //chose a weapon
            Console.WriteLine("Choose a weapon for Xalto!  ( 1 = Sword, 2 = Axe, 3 = Club )");
            String input = Console.ReadLine();

            //strategy portion
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
                default:          //null object called does nothing solves null problem
                    weapon = new Null();
                    break;               
            }

            //set the context portion
            myCharacter.SetWeapon(weapon);
            myCharacter.Attack();
           
        }

        public static void CallSingletonPattern()
        {

            var myFirstInstance   = Singleton.Singleton.GetInstance();
       
            //check to make sure only one instance is created. 
            var mySecondInstanceTry = Singleton.Singleton.GetInstance();

            //check to make sure only one instance is created. 
            var myThirdInstanceTry = Singleton.Singleton.GetInstance();

        }
    }
}

