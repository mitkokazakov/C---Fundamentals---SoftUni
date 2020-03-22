using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
    class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double TravelledDistance { get; set; }

        

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumption;
        }

        public void Drive(double desiredKilometers)
        {
            if (desiredKilometers * this.FuelConsumptionPerKm > this.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive.") ;
            }
            else
            {
                this.FuelAmount -= desiredKilometers * this.FuelConsumptionPerKm;
                this.TravelledDistance += desiredKilometers;
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
        }
    }
}
