/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int SecondDigit(int number)
{
    return number / 10 % 10;
}

int number;
do
{
    Console.Write("Enter number (100..999): ");
    number = Convert.ToInt32(Console.ReadLine());
} while(number < 100 || number > 999);

Console.WriteLine("The second digit of the number is: " + SecondDigit(number));

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
645 -> 5
32679 -> 6
21 -> -1
*/

int ThirdLeftDigit(int number)
{
    if (number < 100)
        return -1; 
    while(number > 1000)
    {
        number /= 10;
    }
    return number % 10;
}

Console.Write("Enter number: ");
int number13 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The third left digit of the entered number is: " + ThirdLeftDigit(number13));

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

bool IsWeekend(int day)
{
    return day == 6 || day == 7;
}

Console.Write("Enter the number of the day of the week: ");
int number15 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The day is " + (IsWeekend(number15) ? "":"not ") + "the day off");