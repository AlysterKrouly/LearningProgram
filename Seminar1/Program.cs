/* Список стандартных операторов.
int intNumber = 25; // Целые числа
 double dobleNumber = 12.12; // Вещественные числа
 string text = "some text"; // Текст
 bool logicVar = true; // оператор условия +/- 
*/



int num1 = 5;
int num2 = 10;

Console.WriteLine("My number are " + num1 + " and " + num2 + " and it is good!");
Console.WriteLine($"My number are {num1} and {num2} and it is good!");
Console.WriteLine("success");

Console.WriteLine("input a number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);