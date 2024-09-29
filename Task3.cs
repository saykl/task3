using System;

class MySecondProgram
{
  static void Main()
  {
    int[] numbers = new int[5];
    int count = 0;
    int mistakes = 0;

    while (true)
    {
      Console.WriteLine("Введи число или Q чтобы закончить:");
      string input = Console.ReadLine();

      if (input == "Q" || input == "q")
      {
        Console.WriteLine("Вот что в массиве:");
        for (int i = 0; i < count; i++)
        {
          Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Что дальше? C - Очистить, P - Продолжить, E - Выйти");
        string action = Console.ReadLine();

        if (action == "C" || action == "c")
        {
          numbers = new int[5];
          count = 0;
          Console.WriteLine("Массив пустой теперь.");
        }
        else if (action == "E" || action == "e")
        {
          Console.WriteLine("Всего чисел: " + count);
          Console.WriteLine("Было ошибок: " + mistakes);
          break;
        }
        else if (action == "P" || action == "p")
        {
          // ничего не делаем, идём дальше
        }
        else
        {
          Console.WriteLine("Не понял команду.");
        }
      }
      else
      {
        int number;
        if (int.TryParse(input, out number))
        {
          if (count == numbers.Length)
          {
            int[] biggerArray = new int[numbers.Length * 2];
            for (int i = 0; i < numbers.Length; i++)
            {
              biggerArray[i] = numbers[i];
            }
            numbers = biggerArray;
          }
          numbers[count] = number;
          count++;
        }
        else
        {
          Console.WriteLine("Эй, это не число!");
          mistakes++;
        }
      }
    }
  }
}