// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12




// Решение через STRING

// void result (string s)                                            
// {   
//     int sum = 0;
//     int leng = s.Length;
//     for (int i = 0; (i < leng); i++)
//     { 
//         sum = sum + (int)Char.GetNumericValue(s[i]);
//     }

        
    
// Console.WriteLine(sum);
// }
    





// void protect()
// {   
//     int number;
//     while (true)
//     {
//     Console.WriteLine("введите число ");
//     string s  = Console.ReadLine();
//     if (int.TryParse(s, out number))
//         {
//             result(s);
//             break;
//         }
//     else
//     {
//         Console.WriteLine("это не  число");
//     }
//     }

// }




// protect();







///Решение через ИНТ 

void result(int n)
{
int sum = 0;
while (n > 0)
{
sum += n % 10;
n /= 10;
}
Console.WriteLine($"Сумма цифр в числе: {sum}");
}

void protect()
{
int number;
while (true)
{
Console.WriteLine("Введите число: ");
string s = Console.ReadLine();
if (int.TryParse(s, out number))
{
result(number);
break;
}
else
{
Console.WriteLine("Это не число.");
}
}
}

protect();





