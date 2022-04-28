/*

int GetNumber(int x){
    int i = 10;
    while (i<10){
        int value = new Random().Next(10,100);
        int a = value /10;
        int b = value %10;
        i++;
        System.Console.WriteLine($"value: {value} a: {a} b: {b}");
        int max = a;

        if (b>max) max = b;
        return max;
    }
}

Console.WriteLine(GetNumber(5));

*/

//2. Напишите программу,
 //которая принимает на вход
 // трёхзначное число и на выходе
  // показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/*

int num = new Random().Next(100,1000);
int N = 265;
if (N < 100 && N >1000 ){
    Console.WriteLine("----- Work------");
}

*/


//3. Напишите программу, которая будет
 //принимать на вход два числа и выводить, 
 //является ли второе число кратным первому.
  //Если число 2 не кратно числу 1, 
  //то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно


/*
int N = 16; //1 
int B = 3;  //2


if (N%B == 0){
    Console.WriteLine("Кратно");
}
else{
   Console.WriteLine(N%B);
}

*/


//4. Напишите программу, которая принимает 
//на вход число и проверяет,
 //кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да


/*
int N = 161;

if ((N%7) == 0 && (N%23) == 0){
    Console.WriteLine("да");
}
else{
    Console.WriteLine("Нет");
}

*/
/*

5. Напишите программу, которая 
принимает на вход два 
числа и проверяет, является
 ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет

*/

/*

int N = -4;
int B = 16;

if ((N*N) == B || (B*B) == N){
    Console.WriteLine("Да, Квадрат");
}
else{
    Console.WriteLine("нет, не квадрат");
}





Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125



1 . Напишите программу,
 которая принимает
 на вход координаты точки (X и Y),
  причём X ≠ 0 и Y ≠ 0 и выдаёт
   номер четверти плоскости,
    в которой находится эта точка.
     2 |  1  
-------------------
     3 | 4 

//Console.WriteLine(Math.Sqrt(25));

*/ 

/*
int SpaceVector(int x,int y){
    if (x > 0 && y > 0) return 1;
    if (x > 0 && y < 0) return 4;
    if (x < 0 && y < 0) return 3;
    if (x < 0 && y > 0) return 2;
    return 5;
}

int X = 1;
int Y = -2;
int flag = SpaceVector(X,Y);
if (flag > 0 && flag <5){
    Console.WriteLine(flag + " Четверть");
}
else {
    Console.WriteLine(" Такого нету");
}

*/ 

/*

double length(double x1, double y1, double x2, double y2)
{
    // x1 = 1, y1 = 1
    // x2 = 3, y2 = 5
    double deltaX = Math.Abs(x1 - x2);
    double deltaY = Math.Abs(y1 - y2);
    double deltaXY = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
    return deltaXY;
}

double ax = 3;
double ay = 2;
double bx = 6;
double by = 1;

Console.WriteLine("lenght " + Math.Round(length(ax, ay, bx, by),2));

*/

/*

int[] BoxSq(int N){
    int i = 0;
    int[] arr = new int [N+1];
    while (i<arr.Length){
        arr[i] = i*i;
        //Console.WriteLine(arr[i]);
        i++;
    }
    return arr;
}

string PrintArr(int[] array){
    int i = 1;
    int len = array.Length;
    string strarr = String.Empty;
    while (i<len){
        strarr += array[i] + " ";
        i+=1;
        }
    return strarr;


}

int num = 7;
Console.WriteLine(PrintArr(BoxSq(num)));
*/

// Написать программу замену элементов массива на противоположные 


// создать массив 
// заполнить массив 
// инверсия 
// печать массива в консоль

// 1) createArreay()
// 2) inversionArray()
// 3) printArray()


/*

int[] createArray (int elements, int min, int max){
    //int num = new Random().Next(10,50);
    int[] arr = new int [elements];
    int i = 0;
    while (i<arr.Length){
        arr[i] = new Random().Next(min,max +1);
        i++;
    }
    return arr;
}


// array[i] = Converte.ToInt32(Console.ReadLine())

int[] InversionArray(int[] NormalArr){
    int len = NormalArr.Length;
    int[] result = new int [len];
    for (int i = 0; i < len; i++){
        result[i] = -(NormalArr[i]);
    }
    return result;
}

/*

string PrintArray(int[] givearr){
    string result = String.Empty;
    for (int i = 0; i < givearr.Length; i++)
    {
        // result += $"{givearr[i]}";
        result += givearr[i] + " | ";
    }
    return result;
}

int[] Myarray = createArray(10,10,50);
//InversionArray(Myarray);
Console.WriteLine(PrintArray(InversionArray(Myarray)) + " ");

*/

*/


// Задать массив из 8 элементов 
// и вывести их на экран


/*

int[] createArray(int elements){
    //int num = new Random().Next(10,50);
    int[] arr = new int [elements];
    int i = 0;
    while (i<arr.Length){
        arr[i] = new Random().Next(0,10);
        i++;
    }
    return arr;
}

string PrintArray(int[] givearr){
    string result = String.Empty;
    for (int i = 0; i < givearr.Length; i++)
    {
        // result += $"{givearr[i]}";
        result += givearr[i] + " | ";
    }
    return result;
}


int num = 8;
Console.WriteLine(PrintArray(createArray(num)));



*/


//  Задайте массив заполненный случайными 
//  положительными трёхзначными числами.
//  Напишите программу, которая покажет
//  количество чётных чисел в массиве.
/*
int[] array = { 203, 511, 516, 612 };

void PrintNew(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int[] createArray(int elements)
{
    //int num = new Random().Next(10,50);
    int[] arr = new int[elements];
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = new Random().Next(100, 1000);
        i++;
    }
    return arr;
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

int [] test = createArray(10);
PrintNew(test);
Console.WriteLine();
Console.WriteLine(EvenNum(test));
*/

/*

int[] array = { 203, 511, 516, 612 };

void PrintNew(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int[] createArray(int elements) //Возвращает массив с рандомными числами
{
    //int num = new Random().Next(10,50);
    int[] arr = new int[elements];
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = new Random().Next(0, 100);
        i++;
    }
    return arr;
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

int SumOfUneven(int[] numbers)  //Возвращает сумму элементов, находящихся на нечетных позициях(с нечетн индексом)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
        if (i % 2 != 0) result += numbers[i];
    return result;
}
int[] test = createArray(5);
PrintNew(test);
Console.WriteLine();
Console.WriteLine(SumOfUneven(test));

*/

/*

double[] newarray(int n)
{
    double[] array = new double[n];
    return array;
}

double[] randomArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*10;
        Console.Write(" " + array[i]);
    }
    Console.WriteLine();
    return array;
}

double summ(double[] ar)
{
    double summ = 0;
    double min = ar[0];
    double max = ar[0];

    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] < min)
        {
            min = ar[i];
        }
        if (ar[i] > max)
        {
            max = ar[i];
        }
        summ = max - min;
    }
    return summ;
}
int n = 5;
double[] array = newarray(n);
array = randomArray(array);
double summa = summ(array);
Console.WriteLine(summa);

  
  */


