/*Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.
m = 3, n = 4.
0.5 7.96 -2.78 -0.2
1.7 -3.3 8.574 -9.9
8.5 7.87 -7.1 9.15*/

int inputNumber(string M){
    int i = 0;

    while (int.TryParse(M, out i) == false){
        Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
        M = Console.ReadLine() ?? "неизвестное сообщение"; // проверка на NULL
    }

    return i;
}

void printArray(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();  
    }
    
    
}

Console.WriteLine("Нужен двумерный массив чисел m*n, введите m");
string userInput = Console.ReadLine()  ?? "неизвестное сообщение";
int m = inputNumber(userInput);

Console.WriteLine("Нужен двумерный массив чисел m*n, введите n");
userInput = Console.ReadLine()  ?? "неизвестное сообщение";
int n = inputNumber(userInput);

Console.WriteLine("Создаем массив " + m + " x " + n);

Random rand = new Random(); 

double [,] matrix = new double[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = Math.Round((rand.Next(-100, 100) + rand.NextDouble()), 2);
    }
}

printArray(matrix);