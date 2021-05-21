using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        // Base Class 

        public class vehicle
        {
             public string name { get; set; }
             private string make { get; set; }
            public vehicle()
            {
                Console.WriteLine(" I am in the Constructor Vehicle");
            }

            public void set_Vname(string v_name) 
            {
                name = v_name;
            }
        }
        // Derived Class
        public class Truck : vehicle
        {
            public Truck()
            {
                Console.WriteLine(" I am in the Derived Truck ");

                Truck truck_obj = new Truck();
                truck_obj.name = "mercedes";
                truck_obj.set_Vname("Toyota");
                

            }
        }

    }
      
}
