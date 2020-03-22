using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < numOfCars; i++)
            {
                string[] info = Console.ReadLine().Split();

                string model = info[0];
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                int cargoWeight = int.Parse(info[3]);
                string cargoType = info[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Engine engine = new Engine(engineSpeed, enginePower);
                Car car = new Car(model, cargo, engine);

                listOfCars.Add(car);

            }

            string filterCargo = Console.ReadLine();

            if (filterCargo == "fragile")
            {
                listOfCars = listOfCars.Where(x => x.Cargo.CargoType == "fragile" && x.Cargo.CargoWeight < 1000).ToList();
            }
            else if (filterCargo == "flamable")
            {
                listOfCars = listOfCars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();
            }

            Console.WriteLine(String.Join(Environment.NewLine, listOfCars));
        }
    }
}
