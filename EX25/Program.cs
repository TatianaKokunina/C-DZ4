/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int userNumberA = new int();
int userNumberB = new int();
Console.WriteLine("Введите число A");
userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
userNumberB = Convert.ToInt32(Console.ReadLine());
double result = 1;
for (int i = 1; i <= userNumberB; i++)
{
 result = result * userNumberA;
 }

Console.WriteLine(result);