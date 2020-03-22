using System;
using System.Linq;
using System.Collections.Generic;

namespace Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();
            for (int i = 0; i < numOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumPerKm = double.Parse(carInfo[2]);

                Car car = new Car(model,fuelAmount,fuelConsumPerKm);

                listOfCars.Add(car);

            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] commandArgs = commands.Split();
                string model = commandArgs[1];
                double kmToTravell = double.Parse(commandArgs[2]);

                foreach (var car in listOfCars)
                {
                    if (model == car.Model)
                    {
                        car.Drive(kmToTravell);
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(String.Join(Environment.NewLine,listOfCars));
        }
    }
}
