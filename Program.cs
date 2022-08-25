// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Большее число " + firstNumber);
//     Console.WriteLine("Меньшее число " + secondNumber);
// }

// else
// {
//     Console.WriteLine("Большее число " + secondNumber);
//     Console.WriteLine("Меньшее число " + firstNumber);
// } 

// 
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.  
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите 3 числа: ");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// int num_2 = Convert.ToInt32(Console.ReadLine());
// int num_3 = Convert.ToInt32(Console.ReadLine());

// int max = num_1;

// if (num_2 > max)
// {
//     max = num_2;
// }

// if (num_3 > max)
// {
//     max = num_3;
// }

// Console.WriteLine("Максимальное из введённых: " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());

// if (Number % 2 == 0)
// {
//     Console.WriteLine("Число " + Number + " является: Чётным");
// }

// else
// {
//     Console.WriteLine("Число " + Number + " является: Нечётным");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// int i = 1;

// Console.WriteLine("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Чётные числа от 1 до " + Number);
// while (i <= Number)
// {
//     if (i % 2 != 1)
//     {
//         Console.WriteLine(i + ", ");
//     }
//     i++;
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Задача 10 ");

// Console.WriteLine("Введите трёхзначное число: ");

// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

// string stringNumber = Convert.ToString(threeDigitNumber);

// Console.WriteLine("вторая цифра этого числа = " + stringNumber[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");

// int anyNumber = Convert.ToInt32(Console.ReadLine());

// string anyNumberText = Convert.ToString(anyNumber);

// if (anyNumberText.Length > 2)
// {
//     Console.WriteLine("третья цифра " + anyNumberText[2]);
// }
// else
// {
//     Console.WriteLine(" третьей цифры нет");
// }

// 
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите цифру, обозначающую день недели: ");

// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void CheckingTheDayofTheWeek (int dayNumber)
//  {
//     if (dayNumber == 6 || dayNumber ==7)
//     {
//        Console.WriteLine("(этот день выходной)  да"); 
//     } 
// else if (dayNumber < 1 || dayNumber > 7)
// {
//     Console.WriteLine("это вообще не день недели");
// }
// else Console.WriteLine("(этот день не выходной) нет");
// }
// CheckingTheDayofTheWeek(dayNumber);