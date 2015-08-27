using System;

namespace Task4
{
    class CarCollection<T> where T : Car
    {
        Car[] _cars;

        public CarCollection()
        {
            _cars = new Car[0];
        }

        public int Count
        {
            get { return _cars.Length; }
        }

        public Car this[int i]
        {
            get
            {
                if (i >= 0 && i <= _cars.Length)
                {

                    return _cars[i];
                }
                Console.WriteLine("Car not found");
                return default(Car);
            }
        }

        public void ClearArr()
        {
            _cars = new Car[0];
        }
        public void Add(Car car)
        {
            Car[] tempCarArr = new Car[_cars.Length + 1];
            for (int i = 0; i < _cars.Length; i++)
            {
                tempCarArr[i] = _cars[i];

            }
            tempCarArr[_cars.Length] = car;
            _cars = tempCarArr;
        }
    }
}
