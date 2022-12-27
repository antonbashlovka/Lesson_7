/*Задача 2. Напишите программу, которая на вход принимает 
позиции (два индекса) элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет*/

int inputNumber(string M){
    int i = 0;

    while (int.TryParse(M, out i) == false){
        Console.WriteLine("Ошибка. Вы ввели текст, необходимо число. Попробуйте еще раз");
        M = Console.ReadLine() ?? "неизвестное сообщение"; // проверка на NULL
    }

    return i;
}

void printArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();  
    }   
}

Random rand = new Random(); 

int m = rand.Next(2, 10);
int n = rand.Next(2, 10);

Console.WriteLine("Создаем произвольный двумерный массив, например " + m + " x " + n);

int [,] matrix = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = rand.Next(1, 10);
    }
}

printArray(matrix);

Console.WriteLine("Вывести элемент можно по индексу");
Console.WriteLine("введите номер строки:");
string userInput = Console.ReadLine()  ?? "неизвестное сообщение";
int line = inputNumber(userInput);

Console.WriteLine("введите номер столбца:");
userInput = Console.ReadLine()  ?? "неизвестное сообщение";
int col = inputNumber(userInput);

line = line-1;
col = col-1;

Console.WriteLine("Ищем элемент с индексом [" + line + "," + col +"]");

if ((line) < matrix.GetLength(0) && (col) < matrix.GetLength(1))
{
    Console.WriteLine(matrix[line,col]);
}
else
{
    Console.WriteLine("такого элемента нет");
}