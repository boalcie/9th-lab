using System;

public class CustomException : Exception
{ 
    public CustomException(string message) : base(message) { }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ProcessData(15);

        }
        catch (CustomException ex)
        {
            Console.WriteLine("Власний виняток: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Вийшла помилка: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Програма добре відпрацювала");
        }
    }

    static void ProcessData(int value)
    {
        if (value > 100)
        {
            throw new CustomException("Значення не повинно бути більше ніж 100");
        }
        Console.WriteLine("Обробка даних для значення: " + value);
    }
}