// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру
// этого числа.

int numb = new Random().Next (100, 1000);

int result = (numb / 100) * 10 + (numb % 10); 
System.Console.WriteLine($"{numb} -> {result}");