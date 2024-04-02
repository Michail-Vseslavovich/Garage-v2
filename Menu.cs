

namespace garage
{
    class Menu
    {
        Mechanic Tom;

        public void Start()
        {
            Console.WriteLine("Вас приветствует ваш механик. Перед началом работы, прошу вас сообщить мне количество машиномест в вашем гараже!");
            int capacity = int.Parse(Console.ReadLine());
            Tom = new Mechanic(capacity);
            Console.WriteLine("Добро пожаловать в ваш гараж! ");
            CarChoice();
            while (true)
            {

                Console.WriteLine("Теперь вы можете выбрать действия, которые вы будете делать с вашими машинами! \n1)Изменить текущую максимальную скорость машины \n2)Устроить дрифт на вашей машине \n3)Добавить новую машину \n4)Использовать Нитро (только спорткары)\n5)получить полный список машин");
                int UserChoice = int.Parse(Console.ReadLine());
                switch (UserChoice)
                {
                    case 3:
                        CarChoice();
                        break;
                    case 5:
                        Tom.ShowCars();
                        break;
                    default:
                        Console.WriteLine("Введите парковочное место нужной машины :");
                        int index = int.Parse(Console.ReadLine());
                        switch (UserChoice)
                        {
                            case 1:

                                Console.WriteLine("Введите новую скорость:");
                                int new_speed = int.Parse(Console.ReadLine());
                                Tom.ChangeSpeed(new_speed, index - 1);
                                break;
                            case 2:


                                Tom.PrepareToDrift(index - 1);
                                break;

                            case 4:
                                Tom.CheckNitro(index - 1);
                                break;

                        }
                        break;

                }



            }

        }



        private void CarChoice()
        {
            Console.WriteLine(" Давайте добавим новую машину!\n Напишите 1, если хотите добавить обычную машину и 2, если хотите спортивную.");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    //usual car
                    Console.WriteLine("Введите скорость, с которой ваша машина сейчас может ехать");
                    int Speed = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите максимальную скорость, до которой можно улучшить двигатель");
                    int MaxSpeed = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите марку машины:");
                    string name = Console.ReadLine();
                    Car car = new Car(Speed, MaxSpeed, name);
                    Tom.AddCar(car);
                    break;

                case 2:
                    //usual car
                    Console.WriteLine("Введите скорость, с которой ваша машина сейчас может ехать");
                    int SportSpeed = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите максимальную скорость, до которой можно улучшить двигатель");
                    int SportMaxSpeed = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество нитро-ускорителя у спорткара");
                    int Nitro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите марку машины:");
                    string SportName = Console.ReadLine();
                    SportCar SportCar = new SportCar(SportSpeed, SportMaxSpeed, Nitro, SportName);
                    Tom.AddCar(SportCar);
                    break;

                default:
                    Console.WriteLine("Не совсем вас понял... \n Давайте попробуем снова!");
                    CarChoice();
                    break;
            }
        }
    }
}
