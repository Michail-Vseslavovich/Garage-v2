using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage
{
    class Mechanic
    {
        public List<Car> garage { get; private set; }
        public Mechanic(int capacity)
        {
            garage = new List<Car>(capacity);
        }

        public void AddCar(Car car)
        {
            garage.Add(car);
        }
        public void ChangeSpeed(int speed, int index)
        {
            if (garage.Count < index)
            {
                Console.WriteLine("Извините, босс... У вас как-то многовато машин для вашего маленького гаража...");

            }
            else { garage[index].Speed = speed; }
        }
        public void PrepareToDrift(int index)
        {
            Console.WriteLine("Машина готова");
            garage[index].Drift();
        }
        public void CheckNitro(int index)
        {
            Console.WriteLine("Нитро готово,можно ехать");
            if (garage[index].GetType() == typeof(SportCar))
            {
                SportCar car = (SportCar)garage[index];
                car.SuperCharge();
            }
            else
            {
                Console.WriteLine("Извините, босс, но эта рухлядь для таких целей не подойдёт...");
            }
        }
        public void ShowCars()
        {
            foreach (var car in garage)
            {
                car.SayInfo();
            }
        }

    }
}
