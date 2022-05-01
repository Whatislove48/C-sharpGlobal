
// Задача 3: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным 
//  и минимальным элементов массива.

string PrintArray(double[] givearr){
    string result = String.Empty;
    for (int i = 0; i < givearr.Length; i++)
    {
        result += givearr[i] + " | ";
    }
    return result;
}



double[] createArray(int elements){
    double[] arr = new double [elements];
    int i = 0;
    while (i<arr.Length){
        arr[i] = Math.Round(new Random().NextDouble()*100,2);
        i++;
    }
    return arr;
}

double MaxMinDif(double[] arr){
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i< arr.Length;i++){
        if (max < arr[i]){
            max = arr[i];
        }
        if (min >= arr[i]){
            min = arr[i];
        }
    }
    return Math.Round(max - min,2);
}


double[] UserArr = createArray(6);
Console.WriteLine(PrintArray(UserArr));
Console.WriteLine(MaxMinDif(UserArr));


