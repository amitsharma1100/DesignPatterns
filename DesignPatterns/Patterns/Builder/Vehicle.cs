using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Builder
{
    public class Vehicle
    {
        private VehicleType _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string> { };

        public Vehicle(VehicleType type)
        {
            _vehicleType = type;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Vehicle Type: {_vehicleType}");
            Console.WriteLine($" Frame : {_parts["frame"]}");
            Console.WriteLine($" Engine : {_parts["engine"]}");
            Console.WriteLine($" #Wheels: { _parts["wheels"]}");
            Console.WriteLine($" #Doors : {_parts["doors"]}");
        }
    }
}
