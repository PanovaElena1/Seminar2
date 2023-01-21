// Напишите программу, которая принимает
// на вход число и проверяет, кратно ли  
//оно одновременно 7 и 23

Console.Write ("Введите число: ");
int numb  = Convert.ToInt32 (Console.ReadLine());

if ((numb % 7 == 0) && (numb % 23 == 0))
{
    System.Console.WriteLine("кратно");
}
else 
{
    System.Console.WriteLine("некратно");
}

