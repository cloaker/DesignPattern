using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy;
using DesignPattern.NullObject;
using DesignPattern.Observer.Subscriber;
using DesignPattern.Observer.Publisher;

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
                        CallObserverPattern();
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

        public static void CallObserverPattern()
        {
            var myYouTubeChannel = new YouTubeChannel();
            var myTwitterChannel = new TwitterChannel();

            //subscriber list 
            ISubscriber prem1 = new PremiumSubscriber();
            ISubscriber prem2 = new PremiumSubscriber();
            ISubscriber prem3 = new PremiumSubscriber();
            ISubscriber prem4 = new PremiumSubscriber();
            ISubscriber reg1 = new RegularSubscriber();
            ISubscriber reg2 = new RegularSubscriber();
            ISubscriber reg3 = new RegularSubscriber();
            ISubscriber reg4 = new RegularSubscriber();
            ISubscriber mod1 = new Moderator();
            ISubscriber mod2 = new Moderator();

            //register subscribers  YouTube Channel
            myYouTubeChannel.registerSubscriber(prem1);
            myYouTubeChannel.registerSubscriber(prem2);
            myYouTubeChannel.registerSubscriber(prem3);
            myYouTubeChannel.registerSubscriber(prem4);
            myYouTubeChannel.registerSubscriber(reg1);
            myYouTubeChannel.registerSubscriber(reg2);
            myYouTubeChannel.registerSubscriber(reg3);
            myYouTubeChannel.registerSubscriber(reg4);
            myYouTubeChannel.registerSubscriber(mod1);
            myYouTubeChannel.registerSubscriber(mod2);

            //register subscribers  YouTube Channel
            myTwitterChannel.registerSubscriber(prem1);
            myTwitterChannel.registerSubscriber(prem2);
            myTwitterChannel.registerSubscriber(prem3);
            myTwitterChannel.registerSubscriber(prem4);
            myTwitterChannel.registerSubscriber(reg1);
            myTwitterChannel.registerSubscriber(reg2);
            myTwitterChannel.registerSubscriber(reg3);
            myTwitterChannel.registerSubscriber(reg4);
            myTwitterChannel.registerSubscriber(mod1);
            myTwitterChannel.registerSubscriber(mod2);

            //notify subscribers
            myTwitterChannel.notifySubscribers();
            myYouTubeChannel.notifySubscribers();

            //pause
            Console.ReadKey();

            //unregister some of the subscribers  YouTube Channel
            myYouTubeChannel.unregisterSubscriber(prem1);
            myYouTubeChannel.unregisterSubscriber(prem3);
            myYouTubeChannel.unregisterSubscriber(reg1);
            myYouTubeChannel.unregisterSubscriber(reg3);
            myYouTubeChannel.unregisterSubscriber(mod1);
            myTwitterChannel.unregisterSubscriber(prem1);
            myTwitterChannel.unregisterSubscriber(prem3);
            myTwitterChannel.unregisterSubscriber(reg1);
            myTwitterChannel.unregisterSubscriber(reg3);
            myTwitterChannel.unregisterSubscriber(mod1);

            //notify subscribers
            myTwitterChannel.notifySubscribers();
            myYouTubeChannel.notifySubscribers();

            //pause
            Console.ReadKey();

        }
    }
}

