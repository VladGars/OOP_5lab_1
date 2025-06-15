using System;

// 1. Створення інтерфейсу
public interface ICalculable
{
    int Calculate(int a, int b);
}

// 2. Реалізація інтерфейсу в класі
public class Calculator : ICalculable
{
    public int Calculate(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 3. Використання інтерфейсу для виклику методу
        ICalculable calc = new Calculator();
        int result = calc.Calculate(10, 5);

        Console.WriteLine($"Результат обчислення: {result}"); // Виведе 15
    }
}