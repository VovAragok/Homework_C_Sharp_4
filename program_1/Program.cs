// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



void result()
{
    Console.WriteLine("Число А");
    int a = revisor();
    Console.WriteLine("Число B");
    int b = revisor();
    int  result = 1 ;
    for (int i = 0; (i < b); i++)
    {  
        result *= a;
    }
Console.WriteLine(result);}
    
    
    


int revisor()
{
    int number;
    while (true)
    {
        Console.Write("введите число: ");
        string s1 = Console.ReadLine();
        if (int.TryParse(s1, out number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }
}



result();


