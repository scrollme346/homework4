using System;

public class Program
{
    enum MathActions//перечисление арифметических операций
    {
        Plus = '+',
        Minus = '-',
        Multiply = '*',
        Divide = '/'
    }

    public static void Main(string[] args)
    {
        try//обработка исключений
        {
            Console.WriteLine("Enter first number: ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());// запрос на ввод первого числа

            Console.WriteLine("Enter second number: ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());// запрос на ввод второго числа

            Console.WriteLine("Enter math action: (+ - * /) ");
            var mathAction = Convert.ToChar(Console.ReadLine() ?? string.Empty);//на ввод ариф знака

            switch (mathAction)
            {
                case (char)MathActions.Plus:
                    Console.WriteLine($"{firstNumber} {mathAction} {secondNumber} = {firstNumber + secondNumber}");// выводим результат сложения
                    break;
                case (char)MathActions.Minus:
                    Console.WriteLine($"{firstNumber} {mathAction} {secondNumber} = {firstNumber - secondNumber}");// вычитания
                    break;
                case (char)MathActions.Multiply:
                    Console.WriteLine($"{firstNumber} {mathAction} {secondNumber} = {firstNumber * secondNumber}");// умножения
                    break;
                case (char)MathActions.Divide:
                    Console.WriteLine($"{firstNumber} {mathAction} {secondNumber} = {firstNumber / secondNumber}"); // деления                  
                    break;
                default:
                    Console.WriteLine("Incorrect math action!");//сообщение об ошибке если введено чтото не так
                    break;
            }
        }
        catch (DivideByZeroException)// ловим в сети если пользователь пытается поделить на ноль
        {
            Console.WriteLine("Не дели пожалуйста на ноль");
        }
        catch (FormatException)//ловим в сети если пользователь пытается пообщатся со мной в калькуляторе
        {
            Console.WriteLine("Нужно ввести цифру или арифметический символ");
        }
        catch (OverflowException)// ловим в сети если пользователь хочет просчитать число ПИ в полную величину
        {
            Console.WriteLine("Результат операции слишком большой для данного типа данных");
        }
        catch (Exception ex)// ловим в сети если пользователь непредсказуем 
        {
            Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
        }
    }
}
