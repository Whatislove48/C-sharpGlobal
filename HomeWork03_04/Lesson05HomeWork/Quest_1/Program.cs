// Задача 1
// Задайте массив заполненный случайными
//  положительными трёхзначными числами.
//   Напишите программу, которая покажет
//    количество чётных чисел в массиве.

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

int EvenNum(int[] array)
{
    int length = array.Length;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) result += 1;
    }
    return result;
}

int [] test = createArray(6);
Console.WriteLine(PrintArray(test));
Console.WriteLine("Колличество четных = " + EvenNum(test));
