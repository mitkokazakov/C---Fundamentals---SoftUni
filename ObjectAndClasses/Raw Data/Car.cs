using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    class Car
    {
        public string Model { get; set; }
        public Cargo Cargo { get; set; }
        public Engine Engine { get; set; }

        public Car(string model, Cargo cargo, Engine engine)
        {
            this.Model = model;
            this.Cargo = cargo;
            this.Engine = engine;
        }

        public override string ToString()
        {
            return $"{this.Model}";
        }
    }
}