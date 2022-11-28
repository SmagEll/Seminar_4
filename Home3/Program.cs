// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int lenArray = ReadInt("Введите длинну массива: ");

int[] ranAr = new int[lenArray];
for (int i = 0; i < ranAr.Length; i++)
{
    ranAr[i] = new Random().Next(1,100);
    Console.Write(ranAr[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}