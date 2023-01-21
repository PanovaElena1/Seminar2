// Напишите программу, которая будет принимать
// на вход два числа и выводить, 
//является ли второе число кратным первому. 
// Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

Console.WriteLine ("Введите первое число: ");
int numb1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("введите второе число: ");
int numb2 = Convert.ToInt32 (Console.ReadLine ());

if (numb1 % numb2 == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine ($"не кратно, остаток {numb1 % numb2}");
}