using System;
using System.Collections.Generic;
using System.Linq;

namespace garage
{
    class Car
    {
        protected int _speed;
        protected int _maxSpeed;
        protected string _brand;


        public Car(int speed = 0, int maxSpeed = 10, string Brand = "TOYOTA")
        {
            _speed = speed;
            _maxSpeed = maxSpeed;
            _brand = Brand;

        }
        public int Speed

        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > _maxSpeed)
                {
                    _speed = _maxSpeed;
                }
                else
                {
                    _speed = value;
                }
            }
        }
        public void Drift()
        {
            if (_speed > _maxSpeed / 2)
            {
                Console.WriteLine("Not drift  :((");
            }
            else
            {
                Console.WriteLine("Drift  :))");
            }
        }
        public virtual void SayInfo()
        {
            Console.WriteLine($"Car speed : {_speed}\nCar max speed : {_maxSpeed}\nCar brand : {_brand}\n\n");
        }

    }




    sealed class SportCar : Car
    {
        private int super;
        public SportCar(int speed = 100, int maxspeed = 200, int supercharge = 1, string Brand = "audi") : base(speed, maxspeed, Brand)
        {
            super = supercharge;
        }

        public void SuperCharge()
        {
            if (super > 0)
            {
                Console.WriteLine("Super  :)");
                super--;
            }
            else
            {

                Console.WriteLine("Not super  :(");
            }
        }
        public void Drift()
        {
            if (_speed < _maxSpeed)
            {
                Console.WriteLine("DRIFT!!!!");

            }
            else
            {
                Console.WriteLine("Not drift  :(");
            }

        }
        public override void SayInfo()
        {
            base.SayInfo();
            Console.WriteLine($"Car nitro amount : {super}");
        }
    }

}
