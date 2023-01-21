// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] 
// и показывает наибольшую цифру числа
// 25 => 5
int numb = new Random().Next (10,100);
Console.WriteLine (numb);

int firstNumb = numb / 10;
int secondNumb = numb % 10;

if(firstNumb > secondNumb)
{
    System.Console.WriteLine(firstNumb);
}
else
{
    System.Console.WriteLine(secondNumb);
}