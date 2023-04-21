// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void ar()
{
    int size = 8;
    int [] arr  = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0,101);
        // Console.WriteLine(arr[i]); можно вывести так
        
    }
    string joinArr = string.Join(", ", arr);
    Console.WriteLine(joinArr);

}




ar();