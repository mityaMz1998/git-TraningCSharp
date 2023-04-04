try
{
    int[] numbers = new int[4];
    numbers[7] = 9;     // IndexOutOfRangeException

    int x = 5;
    int y = x / 0;  // DivideByZeroException
    Console.WriteLine($"Результат: {y}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Возникло исключение DivideByZeroException");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

Console.Read();

