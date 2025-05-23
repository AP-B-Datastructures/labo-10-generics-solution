using System;

namespace Generics.helpers
{
    public class Car
    {
        public enum MANUFACTURER { 
            BMW,
            AUDI,
            PEUGEOT,
            RENAULT,
            ALPHA_ROMEO,
            DACIA
        }
        public string Color { get; set; }
        public MANUFACTURER Manufacturer { get; set; }
        public int NumberOfDoors { get; set; }
        public float Mileage { get; set; }
    }
}