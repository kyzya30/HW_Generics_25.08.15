using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();
            Car miniVan = new Car();
            miniVan.Name = "MiniVanCar1";
            miniVan.ManufactureDate = DateTime.Parse("01.01.15");
            Car miniCar = new Car();
            miniCar.Name = "Mini";
            miniCar.ManufactureDate = DateTime.Parse("10.10.10");
            carCollection.Add(miniVan);
            carCollection.Add(miniCar);
            ShowCars(ref carCollection);
        }

        private static void ShowCars(ref CarCollection<Car> carCollection)
        {
            for (int i = 0; i < carCollection.Count; i++)
            {
                Console.WriteLine("CarName -> {0}  Manufactured -> {1}", carCollection[i].Name, carCollection[i].ManufactureDate);
            }
        }
    }

    
}
