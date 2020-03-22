using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            List<Vehicles> listOfVehicles = new List<Vehicles>();

            while (inputData != "End")
            {
                string[] inputArr = inputData.Split();
                string typeVehicle = inputArr[0];
                string model = inputArr[1];
                string color = inputArr[2];
                int horsePower = int.Parse(inputArr[3]);

                Vehicles vehicles = new Vehicles(typeVehicle, model, color, horsePower);

                listOfVehicles.Add(vehicles);


                inputData = Console.ReadLine();
                
            }

            string modelVehicle = Console.ReadLine();

            while (modelVehicle != "Close the Catalogue")
            {
                foreach (Vehicles x in listOfVehicles)
                {
                    if (x.Model == modelVehicle)
                    {
                        if (x.Type == "car")
                        {
                            Console.WriteLine($"Type: Car");
                        }
                        else if (x.Type == "truck")
                        {
                            Console.WriteLine($"Type: Truck");
                        }

                        Console.WriteLine($"Model: {x.Model}");
                        Console.WriteLine($"Color: {x.Color}");
                        Console.WriteLine($"Horsepower: {x.HorsePower}");
                        
                    }
                }
                modelVehicle = Console.ReadLine();
            }
            double sumCar = 0;
            double averageHorsepowerCars = 0;
            double sumTruck = 0;
            double averageHorsepowerTruck = 0;
            int counterCars = 0;
            int counterTrucks = 0;

            foreach (Vehicles type in listOfVehicles)
            {
                
                if (type.Type == "car")
                {
                    sumCar += type.HorsePower;
                    counterCars++;
                }
                else if (type.Type == "truck")
                {
                    sumTruck += type.HorsePower;
                    counterTrucks++;
                }
            }

            averageHorsepowerCars = sumCar / counterCars;
            averageHorsepowerTruck = sumTruck / counterTrucks;

            if (averageHorsepowerCars > 0 && averageHorsepowerTruck > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageHorsepowerCars:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageHorsepowerTruck:f2}.");
            }
            else if (averageHorsepowerCars > 0 && counterTrucks == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageHorsepowerCars:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            else if (counterCars == 0 && averageHorsepowerTruck > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageHorsepowerTruck:f2}.");
            }
            else if (counterCars == 0 && counterTrucks == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

        }
    }
}
