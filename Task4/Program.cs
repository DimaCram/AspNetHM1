using System;
using System.Collections.Generic;
using Task4.Decorator;
using Task4.Decorator.ConcreteComponents;
using Task4.Decorator.ConcreteDecorators;

namespace Task4
{
    class Program
    {
        private static readonly Dictionary<int, string> pizzaTypes = new Dictionary<int, string>
        {
            {1, "Мексиканская"},
            {2, "Пеперони"},
            {3, "Карбонара"}
        };
        private static readonly Dictionary<int, string> pizzaAdditives = new Dictionary<int, string>
        {
            {0, "Без добавок"},
            {1, "Шампиньоны"},
            {2, "Сыр"},
            {3, "Перец чили"},
            {4, "Лук"},
            {5, "Томаты"}
        };

        static void Main(string[] args)
        {

            Console.WriteLine("Здравствуйте. Вас приветсвует пиццерия 'Марио'. Представьтесь, пожалуйста.");
            Console.Write("Введите ваше имя: ");
            string userName = Console.ReadLine();

            Pizza pizza;

            do
            {
                pizza = GetPizzaType(userName);
            }
            while (pizza == null);


            while (true)
            {
                pizza = GetShaurmaAdding(pizza, out bool finish);

                if (finish)
                    break;
            }

            Console.WriteLine($"{pizza.Name} готова. Стоимость {pizza.Price} рублей.");

            Console.ReadLine();
        }

        private static Pizza GetPizzaType(string userName)
        {
            Console.WriteLine($"{userName}, выберите, пожалуйста, пиццу из представленных:");

            foreach(var pizaType in pizzaTypes)
            {
                Console.WriteLine($"{pizaType.Key} - {pizaType.Value}");
            }
            var selectedType = Console.ReadLine();

            if (int.TryParse(selectedType, out int pizzaType))
            {
                return pizzaType switch
                {
                    1 => new MexicanPizza(),
                    2 => new PeperoniPizza(),
                    3 => new СarbonaraPizza(),
                    _ => null,
                };
            }
            return null;
        }
        private static Pizza GetShaurmaAdding(Pizza pizza, out bool finish)
        {
            finish = false;

            Console.WriteLine("Хотите добавить что-то из нашего списка в пиццу?");

            foreach (var pizaAdditive in pizzaAdditives)
            {
                Console.WriteLine($"{pizaAdditive.Key} - {pizaAdditive.Value}");
            }
            var selectedAdditive = Console.ReadLine();

            if (int.TryParse(selectedAdditive, out int pizzaAdditive))
            {
                switch (pizzaAdditive)
                {
                    case 0:
                        finish = true;
                        return pizza;
                    case 1:
                        return new ChampignonPizza(pizza);
                    case 2:
                        return new CheesePizza(pizza);
                    case 3:
                        return new ChilliPizza(pizza);
                    case 4:
                        return new OnionPizza(pizza);
                    case 5:
                        return new TomatoPizza(pizza);
                    default:
                        return pizza;
                }
            }
            return pizza;
        }

    }
}
