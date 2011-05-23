using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ClassTesting
{
    class Program
    {
        public static void Main(string[] args)
        {
            // переменная, которая будет хранить команду пользователя
            string user_command = "";
 		

            //бесконечный цикл
            bool Infinity = true;

            Man SomeMan = null;

            while (Infinity) //пока Infinity равно true
            {
                //приглашение ввести команду
                System.Console.WriteLine("Введите команду");

                //получение строки (команды) от пользователя
                user_command = System.Console.ReadLine();

                //обработка команды с помощью оператора ветвления
                switch (user_command)
                {

                    case "create_man":
                        {
                            //проверяем, создан ли уже какой либо человек
                            if (SomeMan != null)
                            {
                                //человек уже существует... убиваем его (прихоть автора кода)
                                
                                SomeMan.Kill();

                            }
                            //просим ввести имя человека
                            System.Console.WriteLine("Пожалуйста, введите имя создаваемого человека ");

                            //получаем строку введенную пользователем
                            user_command = System.Console.ReadLine();

                            //создаем новый объект в памяти, в качестве примера передаем имя человека
                            SomeMan = new Man(user_command);

                            //сообщаем о создании
                            System.Console.WriteLine("Человек успешно создан.");

                            break;
                        }

                    case "kill_man":
                        {
                            //проверяем, что объект существует в памяти
                            if (SomeMan != null)
                            {
                                //вызываем функцию смерти
                                SomeMan.Kill();

                                System.Console.WriteLine(SomeMan.Name + " помер от ваших рук. :(");
                            }

                            break;
                        }

                    case "talk":
                        {
                            //проверяем, что объект существует в памяти
                            if (SomeMan != null)
                            {
                                //вызываем функцию разговора
                                SomeMan.Talk();
                            }
                            else //иначе
                            {
                                System.Console.WriteLine("Человека не создана! Команда нихт выполнятен.");
                            }

                            break;

                        }


                    case "go":
                        {
                            //проверяем, что объект существует в памяти
                            if (SomeMan != null)
                            {
                                //вызываем функцию передвижения
                                SomeMan.Go();
                            }
                            else
                            {
                                System.Console.WriteLine("Человека не создана! Команда нихт выполнятен.");
                            }

                            break;

                        }

                    //если user_command содержит строку exit
                    case "exit":
                        {
							lrgame.Weapon a = new lrgame.Weapon(12, "blunt", "wood", "near");
							lrgame.Armor b = new lrgame.Armor(12224443, true, "iron", 54, 2);


							Infinity = false;
                            //теперь цикл завершится и программа завершит свое выполнение
                            break;
                        }

                    // если user_command содержит строку help
                    case "help":
                        {

                            System.Console.WriteLine("Список команд:");
                            System.Console.WriteLine("---");

                            System.Console.WriteLine("create_man : команда создает человека, (экземпляр класса Man)");
                            System.Console.WriteLine("kill_man : команда убивает человека");
                            System.Console.WriteLine("talk : команда заставляет человека говорить (если создан экземпляр класса)");
                            System.Console.WriteLine("go : команда заставляет человека идти (если создан экземпляр класса)");

                            System.Console.WriteLine("---");
                            System.Console.WriteLine("---");

                            break;

                        }
                    //если команду определить не удалось
                    default:
                        {

                            System.Console.WriteLine("Ваша команда не определена, пожалуйста повторите снова");
                            System.Console.WriteLine("Для вывода списка команд введите команду help");
                            System.Console.WriteLine("Для завершения программы введите команду exit");
                            break;
                        }
                }


            }

        }



        public class Man
        {
            //констурктор класса (данная функция вызывается при создании нового экземпляра класса
            public Man(string _name)
            {
                Name = _name;
                isLife = true;

                //генерируем возраст от 15 до 50
                Age = (uint)rnd.Next(15, 50);
                //и здоровье, от 10 до 100%
                Health = (uint)rnd.Next(10, 100);
            }

            //закрытые члены, которые нельзя изменить извне класса


            //экземпляр класса Random для генерации случайных чисел
            private Random rnd = new Random();

            //строка, содержащая имя
            public string Name;

            //беззнаковое целое число, содержащая возраст
            private uint Age;

            //беззнаковое целове число, отражающее уровень здоровья
            private uint Health;

            //булевое, означающее жив ли данный человек
            private bool isLife;

            //заготовка функции "говорить"
            public void Talk()
            {
                //генерируем случайное число от 1 до 3
                int random_talk = rnd.Next(1, 3);

                //объявляем переменную, в которой будем хранить строку

                string tmp_str = "";

                //в зависимости от случайного значения random_talk
                switch (random_talk)
                {
                    case 1: //если 1 - называем свое имя
                        {
                            //генерируем текст сообщения
                            tmp_str = "Здрассе, меня зовут " + Name + ",рад нашему знакомству!";

                            // завершаем оператор выбора
                            break;
                        }

                    case 2: //возраст
                        {
                            //генерируем текст сообщения
                            tmp_str = "Мне " + Age + ". А тебе?";
                            //завершаем оператор выбора
                            break;
                        }

                    case 3: //говорим о своем здоровье
                        {

                            //в зависимости от параметров здоровья
                            if (Health > 50)
                                tmp_str = "Да я здоров как бык!";
                            else
                                tmp_str = "Со здоровьем у меня хреново, дожить бы до " + (Age + 10).ToString();

                            //завершаем оператор выбора
                            break;
                        }
                }
                //выводим в консоль сгенерированное сообщение
                System.Console.WriteLine(tmp_str);
            }

            //заготовка функции "идти"
            public void Go()
            {
                //если объеект жив
                if (isLife == true)
                {
                    //если показатель более 40
                    //считаем объект здоровым
                    if (Health > 40)
                    {
                        //генерируем строку текста
                        string outString = Name + " мирно прогуливается по городу";
                        //выводим в консоль
                        System.Console.WriteLine(outString);
                    }
                    else
                    {
                        //генерируем строку текста
                        string outString = Name + " болен и не может гулять по городу";
                        //выводим в консоль
                        System.Console.WriteLine(outString);
                    }
                }
                else
                {
                    //генерируем строку текста
                    string outString = Name + " не может идти, он умер :(";
                    System.Console.WriteLine(outString);
                }

            }

            public void Kill()
            {
                //устанавливаем значение isLife (жив) в false...
                isLife = false;
            }

            //функция, возвращающая показатель - жив ли данный человек
            public bool IsAlive()
            {
                //возвращаем значение, к которому мы не можем обратиться напрямую из
                //вне класса, так как оно имеет статус private
                return isLife;
            }

        }
    }
}
