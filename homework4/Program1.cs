using System;

public class Program
{
    enum MenuP
    {
        Peperoni = 1,
        Margarita,
        Miasnaya,
        KvadroFormadjo,
        Kola,
        Fanta,
        Sprite
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine($"Приветствуем вас в нашей мини-пиццерии PizzaDay \nВот наше меню \n Пицца(Все пиццы по 10$)");
            Console.WriteLine($"\n  Пеперони(острая) (код - {(int)MenuP.Peperoni}) \n  Маргарита (код - {(int)MenuP.Margarita}) \n  Мясная (код - {(int)MenuP.Miasnaya}) \n  Квадро Формаджо (код - {(int)MenuP.KvadroFormadjo})");
            Console.WriteLine($"\n Напитки (По 2$)\n\n  Кока-кола (код - {(int)MenuP.Kola})  \n  Фанта (код - {(int)MenuP.Fanta}) \n  Спрайт (код - {(int)MenuP.Sprite})");//меню приветсвия и меню заведения

            Console.WriteLine("Введите код Пиццы");
            int poz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество Пиццы");
            int colvo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите код Пиццы");
            int poz1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество Пиц");
            int colvo1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите код Пиццы");
            int poz2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество Пиц");
            int colvo2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите код Пиццы");
            int poz3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество Пиц");
            int colvo3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите код Напитка");
            int poz4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество Напитка");
            int colvo4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите код Напитка");
            int poz5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество Напитка");
            int colvo5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите код Напитка");
            int poz6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество Напитка");
            int colvo6 = Convert.ToInt32(Console.ReadLine());

            string pizzaOrder = "";//переменая с пицами
            string drinkOrder = "";// переменая с напитками

            switch (poz)
            {
                case (int)MenuP.Peperoni:
                    pizzaOrder += $"{colvo} Пеперони, ";
                    break;
                case (int)MenuP.Margarita:
                    pizzaOrder += $"{colvo} Маргарита, ";
                    break;
                case (int)MenuP.Miasnaya:
                    pizzaOrder += $"{colvo} Мясная, ";
                    break;
                case (int)MenuP.KvadroFormadjo:
                    pizzaOrder += $"{colvo} Квадро формаджо, ";
                    break;
            }

            switch (poz1)
            {
                case (int)MenuP.Peperoni:
                    pizzaOrder += $"{colvo1} Пеперони, ";
                    break;
                case (int)MenuP.Margarita:
                    pizzaOrder += $"{colvo1} Маргарита, ";
                    break;
                case (int)MenuP.Miasnaya:
                    pizzaOrder += $"{colvo1} Мясная, ";
                    break;
                case (int)MenuP.KvadroFormadjo:
                    pizzaOrder += $"{colvo1} Квадро формаджо, ";
                    break;
            }

            switch (poz2)
            {
                case (int)MenuP.Peperoni:
                    pizzaOrder += $"{colvo2} Пеперони, ";
                    break;
                case (int)MenuP.Margarita:
                    pizzaOrder += $"{colvo2} Маргарита, ";
                    break;
                case (int)MenuP.Miasnaya:
                    pizzaOrder += $"{colvo2} Мясная, ";
                    break;
                case (int)MenuP.KvadroFormadjo:
                    pizzaOrder += $"{colvo2} Квадро формаджо, ";
                    break;
            }

            switch (poz3)
            {
                case (int)MenuP.Peperoni:
                    pizzaOrder += $"{colvo3} Пеперони, ";
                    break;
                case (int)MenuP.Margarita:
                    pizzaOrder += $"{colvo3} Маргарита, ";
                    break;
                case (int)MenuP.Miasnaya:
                    pizzaOrder += $"{colvo3} Мясная, ";
                    break;
                case (int)MenuP.KvadroFormadjo:
                    pizzaOrder += $"{colvo3} Квадро формаджо, ";
                    break;
            }

            switch (poz4)
            {
                case (int)MenuP.Kola:
                    drinkOrder += $"{colvo4} Кока-кола, ";
                    break;
                case (int)MenuP.Fanta:
                    drinkOrder += $"{colvo4} Фанта, ";
                    break;
                case (int)MenuP.Sprite:
                    drinkOrder += $"{colvo4} Спрайт, ";
                    break;
            }

            switch (poz5)
            {
                case (int)MenuP.Kola:
                    drinkOrder += $"{colvo5} Кока-кола, ";
                    break;
                case (int)MenuP.Fanta:
                    drinkOrder += $"{colvo5} Фанта, ";
                    break;
                case (int)MenuP.Sprite:
                    drinkOrder += $"{colvo5} Спрайт, ";
                    break;
            }

            switch (poz6)
            {
                case (int)MenuP.Kola:
                    drinkOrder += $"{colvo6} Кока-кола, ";
                    break;
                case (int)MenuP.Fanta:
                    drinkOrder += $"{colvo6} Фанта, ";
                    break;
                case (int)MenuP.Sprite:
                    drinkOrder += $"{colvo6} Спрайт, ";
                    break;
            }

            int sumNap = (colvo4 + colvo5 + colvo6) * 2;// сумма напитков
            if (sumNap > 3)// если сума больше 3 то 
            {
                double proc0 = (15.0 / 100.0) * sumNap; // Вычисляем скидку
                double skidka0 = sumNap - proc0;
                Console.WriteLine("\n Скидка на напитки 15%(Активна/Только на напитки)");
            }

            int summa = (colvo + colvo1 + colvo2 + colvo3) * 10 + sumNap; //сумма заказа

            int colvoP = colvo + colvo1 + colvo2 + colvo3; // общее количество пицц
            int freePizzas = colvoP / 5; //сколько пицц идет в подарок
            if (freePizzas > 0)
            {
                Console.WriteLine($" Вы получили {freePizzas} пицц(ы) в подарок.");
                summa -= (freePizzas * 10);
            }

            if (summa >= 50)
            {
                double proc = (20.0 / 100.0) * summa; // Вычисляем скидку
                double skidka = summa - proc;
                Console.WriteLine(" Скидка на заказ свыше 50$(Активна)");
                Console.WriteLine($"\nВаш заказ: {pizzaOrder}{drinkOrder} \n Ваш чек на сумму: {skidka}$ ");
            }
            else if (summa < 50)
            {
                Console.WriteLine($"\nВаш заказ: {pizzaOrder}{drinkOrder} \n Ваш чек на сумму: {summa}$ ");
            }
        }
        
        catch (FormatException)//ловим в сети если пользователь пытается пообщатся со мной в калькуляторе
        {
            Console.WriteLine("Введите код товара или его количество(Цифры)");
        }
        catch (OverflowException)// ловим в сети если пользователь хочет просчитать число ПИ в полную величину
        {
            Console.WriteLine("Результат операции слишком большой для данного типа данных");
        }
        catch (Exception ex)// ловим в сети если пользователь непредсказуем 
        {
            Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
        }
