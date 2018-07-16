using DesignPatterns.Patterns.Builder;
using DesignPatterns.Patterns.Decorator;
using DesignPatterns.Patterns.FacadeDesign;
using DesignPatterns.Patterns.Factory;
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
            switch(option)
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

            Console.WriteLine($"{ customer.Name} has been" + (eligible ? _approved  : _rejected));
           
   
            // Wait for user
               Console.ReadKey();
        }
    }
}