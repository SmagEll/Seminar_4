// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numA = ReadInt("Введите число A: ");
int numB = ReadInt("Введите число B: ");
ToDegree(numA, numB);

void ToDegree(int a, int b)
{
 int res = 1;
 for (int i = 1; i <= b; i++)
    {
    res = res * a;
    }
 Console.WriteLine(res);
}

int ReadInt(string message)
{
 Console.WriteLine(message);
 return Convert.ToInt32(Console.ReadLine());
}