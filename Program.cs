using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Strategy;
using DesignPattern.NullObject;
using DesignPattern.Observer.Subscriber;
using DesignPattern.Observer.Publisher;
using DesignPattern.Iterator.Iterator;
using DesignPattern.Iterator.Aggregate;
using DesignPattern.Decorator.Component;
using DesignPattern.Decorator.ConcreteComponent;
using DesignPattern.Decorator.ConcreteDecorator;

namespace DesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("Choose a Design Pattern -->");
                Console.WriteLine("1 = Strategy, 2=Null Object, 3= Singleton, 4=Observer, 5=Iterator, 6=Decorator");
                Console.WriteLine("");
                Console.WriteLine("type 'exit' and hit enter to stop");
                Console.WriteLine("-------------------------------------------------------------------------------");
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
                        CallIteratorPattern();
                        break;
                    case "6":
                        CallDecoratorPattern();
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
            ISubscriber reg1 = new RegularSubscriber();
            ISubscriber reg2 = new RegularSubscriber();
            ISubscriber mod1 = new Moderator();
            ISubscriber mod2 = new Moderator();

            //register subscribers  YouTube Channel
            myYouTubeChannel.registerSubscriber(prem1);
            myYouTubeChannel.registerSubscriber(prem2);
            myYouTubeChannel.registerSubscriber(prem3);
            myYouTubeChannel.registerSubscriber(reg1);
            myYouTubeChannel.registerSubscriber(reg2);
            myYouTubeChannel.registerSubscriber(mod1);
            myYouTubeChannel.registerSubscriber(mod2);
            //register subscribers  YouTube Channel
            myTwitterChannel.registerSubscriber(prem1);
            myTwitterChannel.registerSubscriber(reg1);
            myTwitterChannel.registerSubscriber(reg2);
            myTwitterChannel.registerSubscriber(mod1);

            Console.WriteLine("----------------------------------- registered youtube");
            Console.WriteLine("prem1 registered for youtube channel");
            Console.WriteLine("prem2 registered for youtube channel");
            Console.WriteLine("prem3 registered for youtube channel");
            Console.WriteLine("reg1 registered for youtube channel");
            Console.WriteLine("reg2 registered for youtube channel");
            Console.WriteLine("mod1 registered for youtube channel");
            Console.WriteLine("mod2 registered for youtube channel");

            Console.WriteLine("----------------------------------- notify subscribers - youtube");
            myYouTubeChannel.notifySubscribers();

            Console.WriteLine("----------------------------------- registered twitter");
            Console.WriteLine("prem1 registered for twitter channel");
            Console.WriteLine("reg1 registered for twitter channel");
            Console.WriteLine("reg2 registered for twitter channel");
            Console.WriteLine("mod1 registered for twitter channel");

            //notify subscribers
            Console.WriteLine("----------------------------------- notify subscribers - twitter");
            myTwitterChannel.notifySubscribers();

            //pause
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Click button to continue");
            Console.ReadKey();

            //unregister some of the subscribers  YouTube Channel
            myYouTubeChannel.unregisterSubscriber(prem1);
            myYouTubeChannel.unregisterSubscriber(prem3);
            myYouTubeChannel.unregisterSubscriber(reg2);
            myYouTubeChannel.unregisterSubscriber(mod2);
            Console.WriteLine("----------------------------------- unregistered youtube");
            Console.WriteLine("prem1 unregistered for youtube channel");
            Console.WriteLine("prem3 unregistered for youtube channel");
            Console.WriteLine("reg2 unregistered for youtube channel");
            Console.WriteLine("mod2 unregistered for youtube channel");

            Console.WriteLine("----------------------------------- notify subscribers - youtube");
            myYouTubeChannel.notifySubscribers();

            Console.WriteLine("-----------------------------------");

            myTwitterChannel.unregisterSubscriber(prem1);
            myTwitterChannel.unregisterSubscriber(prem2);
            myTwitterChannel.unregisterSubscriber(reg1);
            myTwitterChannel.unregisterSubscriber(mod1);
            Console.WriteLine("----------------------------------- unregistered twitter");
            Console.WriteLine("prem1 unregistered for twitter channel");
            Console.WriteLine("prem2 unregistered for twitter channel");
            Console.WriteLine("reg1 unregistered for twitter channel");
            Console.WriteLine("mod1 unregistered for twitter channel");

            //notify subscribers
            Console.WriteLine("----------------------------------- notify subscribers - twitter");
            myTwitterChannel.notifySubscribers();

            Console.WriteLine("-----------------------------------");

        }

        #region Iterator Pattern
        public static void CallIteratorPattern()
        {
            ISocialNetworking facebook = new Facebook();
            ISocialNetworking twitter = new Twitter();

            IIterator facebookIterator = facebook.CreateIterator();
            IIterator twitterIterator = twitter.CreateIterator();

            Console.WriteLine("Facebook: ");
            PrintUsers(facebookIterator);

            Console.WriteLine("Twitter: ");
            PrintUsers(twitterIterator);

            Console.ReadKey();

        }

        public static void PrintUsers(IIterator iterate)
        {
            while(!iterate.IsDone())
            {
                Console.WriteLine(iterate.Next());
            }
        }
        #endregion

        public static void CallDecoratorPattern()
        {
            IceCream iceCreamChocolate = new Chocolate();

            iceCreamChocolate = new Sprinkle(iceCreamChocolate);
            iceCreamChocolate = new Fudge(iceCreamChocolate);

            Console.WriteLine("Chocolate Ice Cream with Sprinkles, Fudge = " + iceCreamChocolate.Cost().ToString("C"));

            IceCream iceCreamVanilla = new Vanilla();

            iceCreamVanilla = new Sprinkle(iceCreamVanilla);
            iceCreamVanilla = new Fudge(iceCreamVanilla);
            iceCreamVanilla = new Caramel(iceCreamVanilla);
            iceCreamVanilla = new WhipCream(iceCreamVanilla);
            iceCreamVanilla = new WaffleCone(iceCreamVanilla);

            Console.WriteLine("Vanilla Ice Cream with Sprinkles, Fudge, Caramel, WhipCream, WaffleCone = " + iceCreamVanilla.Cost().ToString("C"));

            Console.ReadKey();

        }
    }                                                
}

