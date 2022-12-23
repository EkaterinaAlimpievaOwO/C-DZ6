// Урок 6. Одномерные массивы. Продолжение
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3




// int[] numbersArray = GetNumbersFromString(Console.ReadLine());

// PrintArray(numbersArray);
// Console.WriteLine("Пользователь ввел " + CountPositive(numbersArray) + " чисел больше 0.");



// int[] GetNumbersFromString(string str)
// {
//     string[] strs = str.Split(",", StringSplitOptions.RemoveEmptyEntries);
//     int[] array = new int[strs.Length];
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         bool isNumber = int.TryParse(strs[i], out int number);
//         if (isNumber)
//         {
//             array[i] = number;
//         }
//         else
//         {
//             array[i] = 0;
//         }
//     }
    
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.WriteLine("Элементы массива:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int CountPositive(int[] array)
// {
//     int positiveNumbers = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             positiveNumbers++;
//         }
//     }
//     return positiveNumbers;
// }

// ------------------------------------------------------------------->



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("b1 = ");
// float b1 = NumberFromString(Console.ReadLine());
// Console.WriteLine();

// Console.Write("k1 = ");
// float k1 = NumberFromString(Console.ReadLine());
// Console.WriteLine();

// Console.Write("b2 = ");
// float b2 = NumberFromString(Console.ReadLine());
// Console.WriteLine();

// Console.Write("k2 = ");
// float k2 = NumberFromString(Console.ReadLine());

// FindCross(b1, k1, b2, k2);

// float NumberFromString(string str)
// {
//     float.TryParse(str, out float number);
//     return number;
// }

// void FindCross(float b1, float k1, float b2, float k2)
// {
//     if ((k1 == k2) && (b1 == b2))
//     {
//         Console.WriteLine("Одинаковые прямые");
//         return;
//     }
//     if (k1 == k2)
//     {
//         Console.WriteLine("Прямые параллельны и не пересекаются");
//         return;
//     }
    
//     float x = (b2-b1)/(k1-k2);
//     float y = (k1*(b2-b1))/(k1-k2)+b1;

//     Console.WriteLine("Точка пересечения: (" + x + "; " + y + ").");
// }






// ------------------------------------------------------------------->

