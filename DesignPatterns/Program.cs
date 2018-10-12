using DesignPatterns.Patterns.Adapter;
using DesignPatterns.Patterns.Bridge;
using DesignPatterns.Patterns.Builder;
using DesignPatterns.Patterns.Decorator;
using DesignPatterns.Patterns.FacadeDesign;
using DesignPatterns.Patterns.Factory;
using DesignPatterns.Patterns.Mediator;
using DesignPatterns.Patterns.ProtoType;
using DesignPatterns.Patterns.Singleton;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonPattern();
            FactoryPattern();
            BuilderPattern();
            DecoratorPattern();
            FacadeDesignPattern();
        }

        public static void SingletonPattern()
        {
            Console.WriteLine("Enter row no");
            var row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column no");
            var column = Convert.ToInt32(Console.ReadLine());

            Singleton singleObject = Singleton.GetInstance();
            string response = singleObject.AlloteSeat(row, column);
            Console.WriteLine($"Response : {response}");
            SingletonPattern();
        }

        public static void FactoryPattern()
        {
            Console.WriteLine("Choose Mobile \n 1. Apple\n 2. Nokia\n 3. Samsung\n");
            var option = Convert.ToInt32(Console.ReadLine());
            MobileType mobileType = MobileType.None;
            switch (option)
            {
                case 1:
                    mobileType = MobileType.Apple;
                    break;

                case 2:
                    mobileType = MobileType.Nokia;
                    break;

                case 3:
                    mobileType = MobileType.Samsung;
                    break;
            }

            Mobile mobile = Factory.CreateMobile(mobileType)?.GetMobile();
            Console.WriteLine($"Model : {mobile.ModelName}\nOperating System : {mobile.OperatingSystem}");
            Console.ReadLine();
        }

        public static void BuilderPattern()
        {
            VehicleBuilder builder;
            Shop shop = new Shop();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }

        public static void DecoratorPattern()
        {
            //Create EcomomyCar instance.   
            ICar objCar = new EconomyCar();

            //Wrp EconomyCar instance with BasicAccessories.   
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

            Console.Write("Car Details: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

            Console.Read();
        }

        public static void FacadeDesignPattern()
        {
            string _approved = "approved";
            string _rejected = "rejected";

            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine($"{ customer.Name} has been" + (eligible ? _approved : _rejected));


            // Wait for user
            Console.ReadKey();
        }

        public static void ProtoTypePattern()
        {
            Developer dev = new Developer();
            dev.Name = "Chris";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Griff";

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Helen";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "SJ";
            typistCopy.WordsPerMinute = 115;

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());

            Console.ReadKey();
        }

        public static void AdapterPattern()
        {
            ITarget Itarget = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
            client.ShowEmployeeList();

            Console.ReadKey();
        }

        public static void BridgePattern()
        {
            IMessageSender email = new EmailSender();
            IMessageSender queue = new MSMQSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";

            message.MessageSender = email;
            message.Send();

            message.MessageSender = queue;
            message.Send();

            message.MessageSender = web;
            message.Send();

            UserMessage usermsg = new UserMessage();
            usermsg.Subject = "Test Message";
            usermsg.Body = "Hi, This is a Test Message";
            usermsg.UserComments = "I hope you are well";

            usermsg.MessageSender = email;
            usermsg.Send();

            Console.ReadKey();
        }

        public static void MediatorPattern()
        {
            ConcreteColleagueA Colleague1;
            ConcreteColleagueB Colleague2;
        }
    }
}
