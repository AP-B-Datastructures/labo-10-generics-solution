using System;
using Generics.helpers;

namespace Generics.tests.Methods.Car_tests
{
    [TestClass]
    public class BinarySearch_tests
    {

        [TestMethod]
        public void BinarySearch_SortedByMileage()
        {
            Car car1 = new Car() { Color = "red", Manufacturer = Car.MANUFACTURER.BMW, Mileage = 100000f, NumberOfDoors = 5 };
            Car car2 = new Car() { Color = "green", Manufacturer = Car.MANUFACTURER.DACIA, Mileage = 200000f, NumberOfDoors = 4 };
            Car car3 = new Car() { Color = "blue", Manufacturer = Car.MANUFACTURER.RENAULT, Mileage = 300000f, NumberOfDoors = 3 };

            Car[] cars = new Car[] { car1, car2, car3 };
            
            // throw new NotImplementedException();
        }
    }
}
