/*Задача 3. Необязательная, дополнительная задача 
Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
В каждом столбце найдите среднее арифметическое среди тех элементов, 
которые являются палиндромами (если палиндромов нет, то среднее арифметическое считать равным 0). 
Полученные средние арифметические занести в одномерный массив.
Например, задан массив:
100 404 504 225
550 478 800 363
505 101 410 479
=> [505, 252.5, 0, 363 ]*/

void fillArray(ref int[,] arr, int m, int n){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = new Random().Next(100, 999);
        }
    }
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

bool isPalindrome(int intNumber){
    int reverseNumber = 0;
    int num = intNumber;
    
    while (num > 0) {
        // набор перевернутого числа
        reverseNumber =  reverseNumber*10 + num % 10;
        num = num / 10;
    }
    
    if (intNumber == reverseNumber){ // сравнение перевернутого и исходного числа
        return true;
    }else{
        return false;
    }

} 

int m = 10;
int n = 10;

Console.WriteLine("Создаем произвольный двумерный массив, например " + m + " x " + n);

int [,] matrix = new int[m,n];

fillArray(ref matrix, m, n);

printArray(matrix);

Console.WriteLine();
int sum = 0;
int count = 1;
float average = 0;
string res = "";

    for (int j = 0; j < n; j++) // перебираем столбцы
    {
        for (int i = 0; i < m; i++) // перебираем строки
        {
            //Console.Write(matrix[i,j] + "*");
            if (isPalindrome(matrix[i,j])) // проверка на палиндром
            {
                sum = sum + matrix[i,j];
                average = sum/count;
                count ++;
            }
        }       
        
        if (average>0){
            res = res + Convert.ToString(average) + ","; // не понятно как создать массив, в котором заранее не знаешь длину, поэтому записал в строку
        }
        
        count = 1;
        average = 0;
        sum = 0;
    }

if (res.Length > 0)
{
    res = res.TrimEnd(new Char[] {',', ' '});

    string[] avg = res.Split(','); // заносим полученные средние в одномерный массив конвертацией строки с результатами.

    foreach (var val in avg) // выводим массив
    {
        Console.WriteLine(val);
    }
}


