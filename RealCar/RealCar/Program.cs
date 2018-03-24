using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car model = retriveCarFromDatabase();

            //Create a view : to write student details on console
            CarProperties view = new CarProperties();

            CarController controller = new CarController(model, view);

            controller.updateView();

            //update model data
            controller.setCarName("Hummer");

            controller.updateView();
            Console.ReadKey();
        }

        private static Car retriveCarFromDatabase()
        {
            Car car = new Car();
            car.setName("BMW");
            car.setColor("Yellow");
            return car;
            
        }
    }
}

