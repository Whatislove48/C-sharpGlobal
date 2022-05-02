// Задача 3: Напишите программу,
//  которая задаёт массив из 8 
//  элементов и выводит их на экран.

string PrintArr(int[] array) // выводим массив
{
    int i = 0;
    int len = array.Length;
    string strarr = String.Empty;
    while (i<len){
        strarr += array[i] + " ";
        i+=1;
        }
    return strarr;
}

int[] createArray(int elements) // задаем массив
{
    int[] arr = new int [elements];
    int i = 0;
    while (i<arr.Length){
        arr[i] = new Random().Next(0,10);
        i++;
    }
    return arr;
}

int n = 8; // колличество элементов массива.
Console.WriteLine(PrintArr(createArray(n)));
