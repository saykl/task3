using System;

class Ascon_task3
{
  static void Main()
  {
    int[] numbers = new int[5];
    int count = 0;
    int errors = 0;

    while (true)
    {
      Console.WriteLine("Введите число или Q для завершения:");
      string input = Console.ReadLine();

      if (input == "Q" || input == "q")
      {
        Console.WriteLine("Массив:");
        for (int i = 0; i < count; i++)
        {
          Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Что делать? C - Очистить, P - Продолжить, E - Выйти");
        string action = Console.ReadLine();

        if (action == "C" || action == "c")
        {
          numbers = new int[5];
          count = 0;
          Console.WriteLine("Массив очищен.");
        }
        else if (action == "E" || action == "e")
        {
          Console.WriteLine("Введено чисел: " + count);
          Console.WriteLine("Ошибок: " + errors);
          break;
        }
        else if (action == "P" || action == "p")
        {
          // ничего не делаем, продолжаем цикл
        }
        else
        {
          Console.WriteLine("Неправильная команда.");
        }
      }
      else
      {
        int number;
        if (int.TryParse(input, out number))
        {
          if (count == numbers.Length)
          {
            int[] newNumbers = new int[numbers.Length * 2];
            for (int i = 0; i < numbers.Length; i++)
            {
              newNumbers[i] = numbers[i];
            }
            numbers = newNumbers;
          }

          numbers[count] = number;
          count++;
        }
        else
        {
          Console.WriteLine("Это не число!");
          errors++;
        }
      }
    }
  }
}