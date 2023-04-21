/// Пользователь вводит стороны прямоугольника . И стороны квадрата. Задача узнать поместиться ли квадрат в прямоугольник. И если да,  то сколько таких квадратов поместиться .



int revisor()
{
    int number;
    while (true)
    {
        Console.Write("введите размер (см): ");
        string s1 = Console.ReadLine();
        if (int.TryParse(s1, out number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Ошибка при вводе!!!");
        }
    }
}



void result ()
{
    Console.WriteLine("сторона прямоугольника А");
    int a = revisor();
    Console.WriteLine(" сторона прямоугольника B");
    int b = revisor();
    Console.WriteLine("сторона квадрата");
    int c = revisor();
    
   
    if (c <= b && c <= a)
    {
        Console.WriteLine("Квадрат помесился в прямоугольник");
        col(a, b, c);
    }
    else
    {
        Console.WriteLine(" Не поместился");
    }
}






void col (int a, int b , int c)
{
    int result = (a/c) * (b/c);
    Console.WriteLine($"поместится квадратов в прямоугольник - {result} ");

}



result();

