// Seminar 2

//Theory
/*
____________________________________________________________

13254 / 10 = 1325
13254 / 100 = 132
13254 / 1000 = 12
13254 / 10000 = 1

13254 % 10 = 4
13254 % 100 = 54
13254 % 1000 = 254
13254 % 10000 = 3254

24365 -> 43
24365 / 100 = 243
24365 % 100 = 43
____________________________________________________________
*/

//Task 1. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
/*
____________________________________________________________

int  CutNumber (int num)
{
    int hundresd = num / 100;
    int units = num % 10;

    return hundresd * 10 + units;
    //351 -> 3 1 -> 31
}

int randNumber = new Random ().Next (100, 1000);
int resul = CutNumber (randNumber);
Console.WriteLine ($"{randNumber} cunvert to  {resul}");
____________________________________________________________
*/

//Task 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно а и b
/*
____________________________________________________________

bool IsDividable(int num, int div1, int div2)
{
   / if (num % div1 == 0 && num % div2 == 0)
        return true;
    else
        return false;   
   /     
    return (num % div1 == 0 && num % div2 == 0);
}

Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int devider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second devider: ");
int devider2 = Convert.ToInt32(Console.ReadLine());

bool res = IsDividable(number, devider1, devider2);

if(res) Console.WriteLine("Yes");
else Console.WriteLine("No");
____________________________________________________________
*/

//Task3. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
____________________________________________________________

int MaxNumTwodigit (int num)
{
    int part1 = num / 10;
    int part2 = num % 10;
    if (part1 > part2) return part1;
    else return part2;
}
int number = new Random () .Next (10, 100);
Console.WriteLine ("Иходное обрабатываемое число: " + number);
int resul = MaxNumTwodigit(number);
Console.WriteLine ("Наибольшее составляеющее число: " + resul);
____________________________________________________________
*/

//Task4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
____________________________________________________________

bool SquereChech (int num1, int num2) 
{
    return (num1 == num2 * num2 || num2 == num1 * num1);
   
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool res = SquereChech(num1, num2);

if(res) Console.WriteLine("Одно из чисел кратно другому.");
else Console.WriteLine("Ни одно из чисел не кратно другому.");
____________________________________________________________
*/