/* Список стандартных операторов.
int intNumber = 25; // Целые числа
 double dobleNumber = 12.12; // Вещественные числа
 string text = "some text"; // Текст
 bool logicVar = true; // оператор условия +/- 
*/


/* Список примеров с вводом и выводом чисел и текста 
int num1 = 5;
int num2 = 10;

Console.WriteLine("My number are " + num1 + " and " + num2 + " and it is good!");
Console.WriteLine($"My number are {num1} and {num2} and it is good!");
Console.WriteLine("success");

Console.WriteLine("input a number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
*/

//Task1. Напишите программу, которая на вход принимает два числа и проверяет,является ли первое число квадратом второго.
/*
Console.WriteLine("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/

//Task2. Напишите программу которая на вход принимает положительное число (N), а на выводе показывает все целые числа в промежутке -N до N. 
/*
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/
