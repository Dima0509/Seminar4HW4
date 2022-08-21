// Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит 
// число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите переменную A");
int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите переменную B");
    int b = Convert.ToInt32(Console.ReadLine());
    int b2 = b;
            int a2 = a;
            Console.Write(a);
            // for(;b>1;b--)
    while (b > 1)
    {
      b = b - 1;
      a = a * a2;
      Console.WriteLine(a);
    }
                  Console.WriteLine("A в степени B = " + a);