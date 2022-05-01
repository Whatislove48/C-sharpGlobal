// Задача 2: Задайте одномерный массив,
// заполненный случайными числами.
//  Найдите сумму элементов, стоящих 
//  на нечётных позициях.

int SumOfUneven(int[] numbers)  //Возвращает сумму элементов, 
{                               // находящихся на нечетных позициях(с нечетн индексом)
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
        if (i % 2 != 0) result += numbers[i];
    return result;
}

int[] createArray(int elements){
    int[] arr = new int [elements];
    int i = 0;
    while (i<arr.Length){
        arr[i] = new Random().Next(100,1000);
        i++;
    }
    return arr;
}

string PrintArray(int[] givearr){
    string result = String.Empty;
    for (int i = 0; i < givearr.Length; i++)
    {
        result += givearr[i] + " | ";
    }
    return result;
}


int[] test = createArray(5);
Console.WriteLine(PrintArray(test));
Console.WriteLine("Сумма элементов стоящих на нечетных позициях = " + SumOfUneven(test));





