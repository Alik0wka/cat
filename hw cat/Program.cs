using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_cat
{
    enum Food
    {
        fish = 10,
        kiticat = 20,
        mouse = 5,
        meat = 20
    }

    public class Cat
    {
        public int full; 
        public string name;
        public Cat(string Name, int hourse)
        {
            name = Name;
            if (hourse <= 0)
                full = 100;
            else if (hourse >= 1 && hourse <= 3)
                full = 80;
            else if (hourse >= 4 && hourse <= 10)
                full = 30;
            else if (hourse > 10)
                full = 0;
        }

        public int CatEat(int food)
        {
            full += food;
            return full;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool hungry = true;

            Console.WriteLine("Имя котэ?");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько он жрал твои носки, а не нормальную еду?");
            int hours = Convert.ToInt32(Console.ReadLine());

            Cat Vasya = new Cat(name, hours);

            if (Vasya.full > 0)
                Console.WriteLine("Кот " + Vasya.name + " хочет жрать. Его сытость " + Vasya.full + "%");
            else
                Console.WriteLine("Кот " + Vasya.name + " п**дец как хочет жрать! Его сытость " + Vasya.full + "%");

            while (hungry)
            {
                Console.WriteLine("Чем будешь кормить котэ изверг?");
                Console.WriteLine("1. Рыба");
                Console.WriteLine("2. Корм");
                Console.WriteLine("3. Мышь");
                Console.WriteLine("4. Мясо");
                Console.WriteLine("Что дашь ему мразь?");
                int eat = Convert.ToInt32(Console.ReadLine());
                switch (eat)
                {
                    case 1:
                        Vasya.CatEat((int)Food.fish);
                        break;
                    case 2:
                        Vasya.CatEat((int)Food.kiticat);
                        break;
                    case 3:
                        Vasya.CatEat((int)Food.mouse);
                        break;
                    case 4:
                        Vasya.CatEat((int)Food.meat);
                        break;
                }
                Console.WriteLine("Теперь твой котэ не умрет." + Vasya.name + " сыт на " + Vasya.full + "%");

                if (Vasya.full >= 100) hungry = false;
            }
            Console.WriteLine("Твой котэ нажрался, хватит пихать еду!");
            if (Vasya.full > 100) Console.WriteLine("Он скоро от ожирения умрет, как Аслан");
            Console.ReadKey();
        }
    }
}
